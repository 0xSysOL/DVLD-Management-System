using DVLD.Sub_Forms.License;
using DVLD_BussinessLogic.Application_Classes;
using DVLD_BussinessLogic.Application_Classes.Application;
using DVLD_BussinessLogic.License_Class;
using DVLD_BussinessLogic.License_Classes;
using DVLD_BussinessLogic.RenewLocalDrivingLicense;
using DVLD_BussinessLogic.Users_Classes.User_Setting;
using System;
using System.Windows.Forms;

namespace DVLD.Sub_Forms.Application.Manage_Applications
{
    public partial class Frm_RenewLocalDrivingLicenseApp : Form
    {
        public Frm_RenewLocalDrivingLicenseApp()
        {
            InitializeComponent();
            LinkLabel_LicenseInfo.Enabled = false;
            LinkLabel_LicenseHistory.Enabled = false;

        }
        decimal _ApplicationFees = -1;
        decimal _LicensePrice = -1;
        int _LicenseID = -1;
        private void RenewLocalDrivingLicenseApp_Load(object sender, EventArgs e)
        {
            Label_Variable_AppDate.Text = DateTime.Now.ToShortDateString();
            Label_Variable_IssueDate.Text = DateTime.Now.ToShortDateString();
            Label_Variable_CreateBy.Text = CurrentUser.GetUserName();

            // FIXME: Add Application fees
            int ApplicationTypeID = (int)clsApplication_BL.enApplicationType.RenewDrivingLicense;
            _ApplicationFees = clsManageApplicationTypes_BL.GetFeesByID(ApplicationTypeID);
            Label_Variable_APPFees.Text = _ApplicationFees.ToString();

        }

        private void AddValuesToLabels(int LicenseID)
        {
            Label_Variable_OldLicenseID.Text = LicenseID.ToString();
            int LicenseClassID = clsLicense_BL.GetLicenseClassIDByLicenseID(LicenseID);
            _LicensePrice = clsLicenseClass_BL.GetLicensePrice(LicenseClassID);
            Label_Variable_LicenseFees.Text = _LicensePrice.ToString();

            DateTime ExDate = DateTime.Now.AddYears(clsLicenseClass_BL.GetDefaultValidityLength(LicenseClassID));
            Label_Variable_ExpireDate.Text = ExDate.ToShortDateString();

            Label_Variable_TotalFees.Text = (_LicensePrice + _ApplicationFees).ToString();

        }
        private void DeleteLabelsValue()
        {
            _LicensePrice = 0;
            Label_Variable_OldLicenseID.Text = "No Value";
            Label_Variable_LicenseFees.Text = _LicensePrice.ToString();
            Label_Variable_ExpireDate.Text = "No Value";
            Label_Variable_TotalFees.Text = "0";


        }
        private void UC_LicenseFilter_evSendResult(int LicenseID)
        {

            if (Utilities.Methods.Fill_UC_LicenseInfo(UC_LicenseInfo, LicenseID, "LicenseID"))
            {
                if (!clsLicense_BL.IsLicenseActive(LicenseID))
                {
                    MessageBox.Show("Your License Not Active!!", "Info",
           MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Btn_Renew.Enabled = false;
                    LinkLabel_LicenseHistory.Enabled = true;
                    _LicenseID = LicenseID;
                    return;
                }
                else if (DateTime.Now < clsLicense_BL.GetExpirationDate(LicenseID))
                {
                    MessageBox.Show("Your License Is Not Expired!!", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Btn_Renew.Enabled = false;
                    LinkLabel_LicenseHistory.Enabled = true;
                    _LicenseID = LicenseID;
                    return;
                }
                _LicenseID = LicenseID;
                AddValuesToLabels(LicenseID);
                Btn_Renew.Enabled = true;
                LinkLabel_LicenseHistory.Enabled = true;

                return;
            }
            else
            {
                DeleteLabelsValue();
                LinkLabel_LicenseHistory.Enabled = false;
                _LicenseID = -1;

            }

        }

        private void Btn_Renew_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are Sure You Want To Do This Process??", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;


            clsWF_RenewLocalDrivingLicense_BL RLDL
                = new clsWF_RenewLocalDrivingLicense_BL(_LicenseID, TB_Note.Text);

            if (RLDL.Save())
            {
                Label_Variable_LL_LicenseID.Text = RLDL.GetNewLicenseID().ToString();
                Label_Variable_RLAPPID.Text = RLDL.GetApplicationID().ToString();

                MessageBox.Show($"License Renewed Successfully (:\nLicense ID:{RLDL.GetNewLicenseID().ToString()}", "Information",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                Btn_Renew.Enabled = false;
                UC_LicenseFilter.Enabled = false;

            }
            else
            {
                MessageBox.Show("Something Wrong Please Talk with your Admin ):", "Error",
         MessageBoxButtons.OK, MessageBoxIcon.Error);
                Btn_Renew.Enabled = false;
            }


        }

        private void LinkLabel_LicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int PersonID = clsLicense_BL.GetPersonIDByLicenseID(_LicenseID);
            Frm_ShowPersonLicenseHistory SPLH = new Frm_ShowPersonLicenseHistory(PersonID, "Person");

            SPLH.ShowDialog();


        }

        private void LinkLabel_LicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }




    }
}
