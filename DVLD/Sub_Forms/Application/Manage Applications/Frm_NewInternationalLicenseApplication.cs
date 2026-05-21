using DVLD_BussinessLogic.Application_Classes;
using DVLD_BussinessLogic.Application_Classes.Application;
using DVLD_BussinessLogic.Application_Classes.New_International_License_App;
using DVLD_BussinessLogic.Drivers;
using DVLD_BussinessLogic.License_Classes;
using DVLD_BussinessLogic.Users_Classes.User_Setting;
using System;
using System.Windows.Forms;

namespace DVLD.Sub_Forms.Application.Manage_Applications
{
    public partial class Frm_NewInternationalLicenseApplication : Form
    {
        int _DriverID;
        int _LicenseDriverID;
        public Frm_NewInternationalLicenseApplication()
        {
            InitializeComponent();
            _DriverID = -1;
            _LicenseDriverID = -1;

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
                UC_ApplicationInfo.SetLabelLLAPPID(NIDLAPP.GetApplicationID());
                UC_ApplicationInfo.SetLabelLL_LicenseID(NIDLAPP.GetILicenseID());
            }
            else
            {
                MessageBox.Show("Error Please Try Again", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void UC_LicenseFilter_evSendResult(int LicenseID)
        {

            if (Utilities.Methods.Fill_UC_LicenseInfo(UC_LicenseInfo, LicenseID, "LicenseID"))
            {
                _DriverID = UC_LicenseInfo.GetLabelDriverID();
                _LicenseDriverID = UC_LicenseInfo.GetLabelLicenseID();
                UC_ApplicationInfo.SetLabelLocalLicenseID(_LicenseDriverID);

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




    }
}
