using DVLD.Sub_Forms.Drivers;
using DVLD.Sub_Forms.License;
using DVLD.User_Controls.Detain;
using DVLD_BussinessLogic.Application_Classes;
using DVLD_BussinessLogic.Application_Classes.Application;
using DVLD_BussinessLogic.Detained;
using DVLD_BussinessLogic.License_Classes;
using DVLD_BussinessLogic.Users_Classes.User_Setting;
using DVLD_BussinessLogic.Workflows.ReleaseDetain;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace DVLD.Sub_Forms.Application.Detained_License
{
    public partial class Frm_ReleaseDetainLicense : Form
    {
        int _LicenseID = -1;
        private void OpenThisFromManageDetain(int LicenseID) 
        {
            SearchForLicense(LicenseID);
        }
        public Frm_ReleaseDetainLicense()
        {
            InitializeComponent();

        }
        public Frm_ReleaseDetainLicense(int LicenseID) :this()
        {
            SearchForLicense(LicenseID);
            UC_LicenseFilter.Enabled = false;
        }

        private void EnableBtnDet(bool Key)
        {
            Btn_Detain.Enabled = Key;
        }
        private void EnableShowLicenseHis(bool Key)
        {
            LinkLabel_LicenseHistory.Enabled = Key;
        }
        private void EnableShowLicenseInfo(bool Key)
        {
            LinkLabel_LicenseInfo.Enabled = Key;
        }

        private void Frm_ReleaseDetainLicense_Load(object sender, EventArgs e)
        {

        }
        private void Fill_UC_ShowDetainInfo(int LicenseID)
        {
            int DetainID = -1;
            DateTime DetainDate = DateTime.Now;
            string UserName = "";
            decimal FineFees = 0;
            clsDetained_BL.GetDetainByLicenseID(LicenseID, ref DetainID, ref DetainDate, ref UserName, ref FineFees);

            if(DetainID == -1)
            {

                UC_ShowDetainInfo.SetDetainID(0);
                UC_ShowDetainInfo.SetDetainDate(DetainDate);
                UC_ShowDetainInfo.SetUserName(CurrentUser.GetUserName());
                UC_ShowDetainInfo.SetFineFees(0);
                UC_ShowDetainInfo.SetApplicationFees(0);
                UC_ShowDetainInfo.SetTotalFees(0);
                MessageBox.Show("Your License Not Detain!!", "Info",
                 MessageBoxButtons.OK, MessageBoxIcon.Warning);

                EnableBtnDet(false);
                EnableShowLicenseHis(false);
                EnableShowLicenseInfo(false);
                return;
            }    
            UC_ShowDetainInfo.SetDetainID(DetainID);
            UC_ShowDetainInfo.SetDetainDate(DetainDate);
            UC_ShowDetainInfo.SetUserName(UserName);
            UC_ShowDetainInfo.SetFineFees(FineFees);

            int LicenseClassID = clsLicense_BL.GetLicenseClassIDByLicenseID(LicenseID);

            decimal ApplicationFees = clsManageApplicationTypes_BL.GetFeesByID((int)
                clsApplication_BL.enApplicationType.ReleaseDetained);

            UC_ShowDetainInfo.SetApplicationFees(ApplicationFees);
            UC_ShowDetainInfo.SetTotalFees((ApplicationFees + FineFees));

        }
        private void SearchForLicense(int LicenseID)
        {
     if (Utilities.Methods.Fill_UC_LicenseInfo(UC_LicenseInfo, LicenseID, "LicenseID"))
            {
                EnableBtnDet(true);
                EnableShowLicenseHis(true);
                EnableShowLicenseInfo(true);
                _LicenseID = LicenseID;

                UC_ShowDetainInfo.SetLicenseID(LicenseID);
                Fill_UC_ShowDetainInfo(LicenseID);

            }
            else
            {
                EnableBtnDet(false);
                EnableShowLicenseHis(false);
                EnableShowLicenseInfo(false);

                _LicenseID = -1;
            }
        }
        private void UC_LicenseFilter_evSendResult(int LicenseID)
        {

            SearchForLicense(LicenseID);




        }
        private void Btn_Release_Click(object sender, EventArgs e)
        {
            if (_LicenseID == -1)
            {
                MessageBox.Show("Please Enter License ID!!", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Utilities.Methods.IsLicenseReleasedFromDetain(_LicenseID))
                return;

         

            clsWF_ReleaseDetain_BL ReleaseDetain = new clsWF_ReleaseDetain_BL(_LicenseID);


            if (ReleaseDetain.Save())
            {
                UC_ShowDetainInfo.SetApplicationID(ReleaseDetain.GetApplicationID());
                MessageBox.Show("Your License Released Successfully", "Info",
                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                UC_LicenseFilter.Enabled = false;
                EnableBtnDet(false);
                EnableShowLicenseHis(false);
                EnableShowLicenseInfo(false);
            }
            else
            {
                MessageBox.Show("Something Wrong!!", "Info",
                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            Frm_DrivingLicenseInfo DLI = new Frm_DrivingLicenseInfo(_LicenseID, "LicenseID");

            DLI.ShowDialog();

        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
