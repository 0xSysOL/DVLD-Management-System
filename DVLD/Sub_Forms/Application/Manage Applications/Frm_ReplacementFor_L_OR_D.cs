using DVLD.Sub_Forms.Drivers;
using DVLD.Sub_Forms.License;
using DVLD_BussinessLogic.Application_Classes;
using DVLD_BussinessLogic.Application_Classes.Application;
using DVLD_BussinessLogic.License_Classes;
using DVLD_BussinessLogic.Users_Classes.User_Setting;
using DVLD_BussinessLogic.Workflows.ReplacementLocalDrivingLicense;
using System;
using System.Windows.Forms;

namespace DVLD.Sub_Forms.Application
{
    public partial class Frm_ReplacementFor_L_OR_D : Form
    {
        public Frm_ReplacementFor_L_OR_D()
        {
            InitializeComponent();

        }
        clsApplication_BL.enApplicationType SaveAppType;
        decimal SaveAppFees_Lost;
        decimal SaveAppFees_Damage;
        int _LicenseID = -1;
        int _ApplicationID = -1;
        private void Frm_ReplacementFor_L_OR_D_Load(object sender, EventArgs e)
        {
            SaveAppFees_Lost = clsManageApplicationTypes_BL.GetFeesByID((int)clsApplication_BL.enApplicationType.ReplacementLost);
            SaveAppFees_Damage = clsManageApplicationTypes_BL.GetFeesByID((int)clsApplication_BL.enApplicationType.ReplacementDamaged);
            BtnRadio_Damage_CheckedChanged(sender, e);
            Label_Variable_CreateBy.Text = CurrentUser.GetUserName();

        }

        private void BtnRadio_Damage_CheckedChanged(object sender, EventArgs e)
        {
            Label_Const_FormTitle.Text = "Replacement For Damage License";
            Label_Variable_APPFees.Text = SaveAppFees_Damage.ToString();
            SaveAppType = clsApplication_BL.enApplicationType.ReplacementDamaged;
        }

        private void BtnRadio_Lost_CheckedChanged(object sender, EventArgs e)
        {
            Label_Const_FormTitle.Text = "Replacement For Lost License";
            Label_Variable_APPFees.Text = SaveAppFees_Lost.ToString();
            SaveAppType = clsApplication_BL.enApplicationType.ReplacementLost;

        }
        private void LinkLabel_LicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            int PersonID = clsLicense_BL.GetPersonIDByLicenseID(_LicenseID);
            Frm_ShowPersonLicenseHistory SPLH = new Frm_ShowPersonLicenseHistory(PersonID, "Person");

            SPLH.ShowDialog();
            Label_Variable_AppDate.Text = DateTime.Now.ToShortDateString();
        }

        private void LinkLabel_LicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_DrivingLicenseInfo DLI = new Frm_DrivingLicenseInfo(_ApplicationID);

            DLI.ShowDialog();
        }
        private void EnabliationLinkLabel_LicenseInfo(bool Key)
        {
            LinkLabel_LicenseInfo.Enabled = Key;
        }
        private void EnabliationLinkLabel_LicenseHistory(bool Key)
        {
            LinkLabel_LicenseHistory.Enabled = Key;
        }
        private void UC_LicenseFilter_evSendResult(int LicenseID)
        {

            if (Utilities.Methods.Fill_UC_LicenseInfo(UC_LicenseInfo, LicenseID, "LicenseID"))
            {

                if (!Utilities.Methods.IsLicenseActive_M(LicenseID))
                {
                    _LicenseID = -1;
                    EnabliationLinkLabel_LicenseHistory(false);
                    Btn_IssueReplacement.Enabled = false;
                    return;
                }

                _LicenseID = LicenseID;
                Label_Variable_OldLicenseID.Text = _LicenseID.ToString();
                EnabliationLinkLabel_LicenseHistory(true);
                Btn_IssueReplacement.Enabled = true;

            }
            else
            {
                EnabliationLinkLabel_LicenseHistory(false);
                _LicenseID = -1;
                Btn_IssueReplacement.Enabled = false;

            }




        }

        private void ChangeControlsValuesAfterIssue(int NewLicenseID, int ApplicationID)
        {

            _LicenseID = NewLicenseID;
            Label_Variable_LRAPPID.Text = ApplicationID.ToString();
            UC_LicenseFilter.Enabled = false;
            Btn_IssueReplacement.Enabled = false;
            Label_Variable_RL_ID.Text = _LicenseID.ToString();         
            _ApplicationID = ApplicationID;
            EnabliationLinkLabel_LicenseInfo(true);
            GroupBox_BtnRadio.Enabled = false;
        }
        private void Btn_IssueReplacement_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are Sure You Want To Do This Process??", "Confirmation",
             MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            clsWF_ReplacementLocalDrivingLicense RLDL
                = new clsWF_ReplacementLocalDrivingLicense(_LicenseID, (int)SaveAppType);
            if (RLDL.Save())
            {
                string Status = SaveAppType == clsApplication_BL.enApplicationType.ReplacementDamaged ?
                       "For Damaged" : "For Lost";

                MessageBox.Show($"License {Status} Added Successfully (:\nLicense ID:{RLDL.GetNewLicenseID().ToString()}", "Information",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

                ChangeControlsValuesAfterIssue(RLDL.GetNewLicenseID(), RLDL.GetApplicationID());


            }
            else
            {
                MessageBox.Show("Something Wrong Please Talk with your Admin ):", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }



    }
}
