using DVLD.Sub_Forms.Drivers;
using DVLD.Sub_Forms.License;
using DVLD_BusinessLogic;
using DVLD_BussinessLogic.Application_Classes;
using DVLD_BussinessLogic.Application_Classes.Application;
using DVLD_BussinessLogic.Application_Classes.New_International_License_App;
using DVLD_BussinessLogic.Drivers;
using DVLD_BussinessLogic.License_Classes;
using DVLD_BussinessLogic.Users_Classes.User_Setting;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DVLD.Sub_Forms.Application.Manage_Applications
{
    public partial class Frm_NewInternationalLicenseApplication : Form
    {
        int _DriverID;
        int _LicenseDriverID;
        int _ApplicationID;
     
        public Frm_NewInternationalLicenseApplication()
        {
            InitializeComponent();
            _DriverID = -1;
            _LicenseDriverID = -1;
            LinkLabel_LicenseInfo.Enabled = false;


        }

        private void Frm_NewInternationalLicenseApplication_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Issue_Click(object sender, EventArgs e)
        {

            #region Validation
            if (_DriverID <= 0 || _LicenseDriverID <= 0)
            {
                MessageBox.Show("Chose License", "Info",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;

            }
            if (clsDriver_BL.IsDriverHaveInternationalLicense(_DriverID))
            {
                MessageBox.Show("Driver Already Have International License", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if (!clsLicense_BL.IsLicenseActive(_LicenseDriverID))
            {
                MessageBox.Show("License Not Active", "Info",
              MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if (clsLicense_BL.IsLicenseExpired(_LicenseDriverID))
            {
                MessageBox.Show("License Expired", "Info",
           MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            #endregion End

            clsWF_NewInternationalDriverLicenseApp_BL NIDLAPP =
                new clsWF_NewInternationalDriverLicenseApp_BL(_DriverID, _LicenseDriverID);


            if (NIDLAPP.Save())
            {
                MessageBox.Show("International Added Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UC_ApplicationInfo.SetLabelLLAPPID(_ApplicationID = NIDLAPP.GetApplicationID());
                UC_ApplicationInfo.SetLabelLL_LicenseID(NIDLAPP.GetILicenseID());
                LinkLabel_LicenseInfo.Enabled = true;
            }
            else
            {
                MessageBox.Show("Error Please Try Again", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void AddImage()
        {

            string ImageKey = clsPeople_BL.GetImagePath(clsDriver_BL.GetPersonIDByDriverID(_DriverID));
            if (!string.IsNullOrEmpty(ImageKey))
            {
                string ImagePath = clsPeople_BL.FindImagePath(ImageKey);
                Image image = Image.FromFile(ImagePath);
                UC_LicenseInfo.SetImage(image);
            }
        }
        private void UC_LicenseFilter_evSendResult(int LicenseID)
        {

            if (Utilities.Methods.Fill_UC_LicenseInfo(UC_LicenseInfo, LicenseID, "LicenseID"))
            {
                _DriverID = UC_LicenseInfo.GetLabelDriverID();
                _LicenseDriverID = UC_LicenseInfo.GetLabelLicenseID();
                UC_ApplicationInfo.SetLabelLocalLicenseID(_LicenseDriverID);
                AddImage();
            }
            else
            {
                _DriverID = -1;
                _LicenseDriverID = -1;
                UC_ApplicationInfo.SetLabelLocalLicenseID(-1);
                UC_LicenseInfo.RefreshLabels();

            }


        }

        private void UC_ApplicationInfo_Load(object sender, EventArgs e)
        {

            UC_ApplicationInfo.SetLabelCreateBy(CurrentUser.GetUserName());
            UC_ApplicationInfo.SetLabelFees(clsManageApplicationTypes_BL.GetFeesByID((int)clsApplication_BL.enApplicationType.NewInternationalLicense));

        }

        private void UC_LicenseInfo_Load(object sender, EventArgs e)
        {



        }

        private void LinkLabel_LicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_DriverID < 0)
                return;

            Frm_ShowPersonLicenseHistory _ShowPLH =
                new Frm_ShowPersonLicenseHistory(clsDriver_BL.GetPersonIDByDriverID(_DriverID),"Person");

            _ShowPLH.ShowDialog();


        }

        private void LinkLabel_LicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Frm_InternationalDrivingLicenseInfo IDLI = 
                new Frm_InternationalDrivingLicenseInfo(_ApplicationID);
            IDLI.ShowDialog();


        }

        private void UC_LicenseFilter_Load(object sender, EventArgs e)
        {

        }
















    }
}
