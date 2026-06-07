using DVLD.Sub_Forms;
using DVLD.Sub_Forms.Application;
using DVLD.Sub_Forms.Application.Detained_License;
using DVLD.Sub_Forms.Application.Drving_Licenses_Services.New_Driving_License;
using DVLD.Sub_Forms.Application.Manage_Applications;
using DVLD.Sub_Forms.Application.ManageTestTypes;
using DVLD.Sub_Forms.Drivers;
using DVLD.Sub_Forms.Users_Forms;
using DVLD_BussinessLogic.Users_Classes.User_Setting;
using System;
using System.Windows.Forms;

namespace DVLD
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }
        // Load Manage People Form
        private void MS__People_Click(object sender, EventArgs e)
        {

            Frm_People people_Form = new Frm_People();

            people_Form.ShowDialog();


        }
        // Load Manage Users Form
        private void MS__Users_Click(object sender, EventArgs e)
        {
            Frm_ManageUsers Users_Form = new Frm_ManageUsers();

            Users_Form.ShowDialog();
        }



        private void MS__Drivers_Click(object sender, EventArgs e)
        {
            Frm_ManageDrivers frm_ManageDrivers = new Frm_ManageDrivers();

            frm_ManageDrivers.ShowDialog();


        }





        #region Account Setting
        private void changeUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(CurrentUser.GetUserID());
            Frm_ChangePassword frm_ChangePassword = new Frm_ChangePassword(ID);

            frm_ChangePassword.ShowDialog();

        }

        private void signOut_SM_Click(object sender, EventArgs e)
        {

            this.Close();
            Application.Restart();

        }

        private void currentUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_UserInformation frm_User = new Frm_UserInformation(CurrentUser.GetUserID());


            frm_User.ShowDialog();

        }

        #endregion End

        #region Applications Section

        #region Driving Licenses  Services
        private void DrivingLS_ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void RenewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_RenewLocalDrivingLicenseApp renewLocalDriving = new Frm_RenewLocalDrivingLicenseApp();

            renewLocalDriving.ShowDialog();


        }
        private void ReplacementForLostOrDamagedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ReplacementFor_L_OR_D _ReplacementFor_L_OR_D = new Frm_ReplacementFor_L_OR_D();

            _ReplacementFor_L_OR_D.ShowDialog();

        }
        #region New Driving License
        private void newDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_NewLocalLicense newLocalLicense = new Frm_NewLocalLicense();

            newLocalLicense.ShowDialog();

        }
        private void internationalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_NewInternationalLicenseApplication NILAPP = new Frm_NewInternationalLicenseApplication();

            NILAPP.ShowDialog();


        }
        #endregion End



        #endregion End

        #region Manage Application 
        private void localDrivingLicenseApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_LocalDrivingLicenseApplications frm_Local = new Frm_LocalDrivingLicenseApplications();

            frm_Local.ShowDialog();


        }



        private void internationalLicenseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_ManageInternationalApp _ManageInternationalApp = new Frm_ManageInternationalApp();

            _ManageInternationalApp.ShowDialog();

        }

        private void releaseDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ReleaseDetainLicense _ReleaseDetainLicense = new Frm_ReleaseDetainLicense();

            _ReleaseDetainLicense.ShowDialog();
        }

        private void retakeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_LocalDrivingLicenseApplications frm_Local = new Frm_LocalDrivingLicenseApplications();

            frm_Local.ShowDialog();
        }


        #endregion End



        #region Manage Application Types
        private void manageApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Manage_Application_Types_ Show_MAT = new Frm_Manage_Application_Types_();

            Show_MAT.Show();
        }


        #endregion End

        #region Manage Test Types
        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ManageTestTypes manageTestTypes = new Frm_ManageTestTypes();

            manageTestTypes.ShowDialog();

        }












        #endregion End

        #region Detained License

        private void ManageDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ListDetainedLicense frm_ListDetained = new Frm_ListDetainedLicense();

            frm_ListDetained.ShowDialog();
        }
        private void DetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_DetainLicense DL = new Frm_DetainLicense();

            DL.ShowDialog();

        }
        private void ReleaseDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ReleaseDetainLicense _ReleaseDetainLicense = new Frm_ReleaseDetainLicense();

            _ReleaseDetainLicense.ShowDialog();

        }


        #endregion End

        #endregion End

        private void Main_Form_Load(object sender, EventArgs e)
        {


        }

    

        private void MS__Application_Click(object sender, EventArgs e)
        {

        }




    }
}
