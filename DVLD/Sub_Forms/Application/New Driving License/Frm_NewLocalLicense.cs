using DVLD.User_Controls;
using DVLD.Utilities;
using DVLD_BusinessLogic;
using DVLD_BussinessLogic.Application_Classes;
using DVLD_BussinessLogic.Application_Classes.Application;
using DVLD_BussinessLogic.Application_Classes.New_Local_License_App;
using DVLD_BussinessLogic.License_Class;
using DVLD_BussinessLogic.Users_Classes.User_Setting;
using System;
using System.Windows.Forms;

namespace DVLD.Sub_Forms.Application.Drving_Licenses_Services.New_Driving_License
{
    public partial class Frm_NewLocalLicense : Form
    {

        clsPeople_BL clsPeople;
        clsLicenseClass_BL License_Class;
        clsNewLocalDriverLicenseApplication_BL clsLocalDriverLicense;
        string Mode;
        // TODO: Implement Update Mode Logic
        public Frm_NewLocalLicense()
        {
            InitializeComponent();
            InitializeLabels(DateTime.Now, GetApplicationFees(), CurrentUser.GetUserName());
            Mode = "Add";
        }

        public Frm_NewLocalLicense(int LDLAPP_ID)
        {
            InitializeComponent();
            clsLocalDriverLicense = new clsNewLocalDriverLicenseApplication_BL(LDLAPP_ID);
            InitializeLabels(clsLocalDriverLicense.ApplicationDate, GetApplicationFees(), CurrentUser.GetUserName(), LDLAPP_ID);
            InitializePerson();
            Mode = "Update";

        }
        private void InitializePerson()
        {
            clsPeople = new clsPeople_BL(clsLocalDriverLicense.PersonID);
            if (Methods.Fill_UC_Person_Controls(UC_ShowPersonInfo, clsPeople))
            {
                UC_Filter.Enabled = false;
                Btn_Save.Enabled = true;
            }


        }

        private void InitializeLabels(DateTime ApplicationDate,
            decimal ApplicationFees, string CreateByUser, int LDLAPP_ID = -1)
        {
            if (LDLAPP_ID != -1)
                Label_Variable_DL_AppID.Text = LDLAPP_ID.ToString();

            Label_Variable_CreateBy.Text = CreateByUser;
            Label_Variable_ApplicationFees.Text = ApplicationFees.ToString();
            Label_Variable_ApplicationDate.Text = ApplicationDate.ToString();

        }



        // see more please
        private decimal GetApplicationFees()
        {
            /*FIXED: this will be change we will retrive data from database */
            clsManageApplicationTypes_BL applicationTypes = new clsManageApplicationTypes_BL
                (Convert.ToInt32(clsApplication_BL.enApplicationType.LocalDrivingLicense));
            return applicationTypes.GetFees();
        }

        private void Frm_NewLocalLicense_Load(object sender, EventArgs e)
        {
            InitializeComboBox();
            InitializeComboBoxLicenseClass();
            UC_Filter_ShowPicButtonSearch();
        }


        private void InitializeComboBoxLicenseClass()
        {
            Utilities.Methods.FillComboBOX(clsLicenseClass_BL.GetAllClass(), ComboBox_LicenseClass, 1);

        }
        private void InitializeComboBox()
        {

            UC_Filter.FillComboBox("NationalNo"); // Index = 1
            UC_Filter.FillComboBox("PersonID");// Index = 2

        }
        private void UC_Filter_ShowPicButtonSearch()
        {
            UC_Filter.ShowPicButtonSearch();

        }
        enum eCBMode { NationalNo = 1, PersonID = 2 }
        eCBMode CB_mode;
        private void UC_Filter_Ev_IsInt(int Index)
        {

            switch ((eCBMode)Index)
            {

                case eCBMode.NationalNo:
                    UC_Filter.Answer_IsInt(false);
                    CB_mode = eCBMode.NationalNo;
                    break;
                case eCBMode.PersonID:
                    UC_Filter.Answer_IsInt(true);
                    CB_mode = eCBMode.PersonID;

                    break;


            }

        }

        private void UC_Filter_EvClickedSearchButton(string Value)
        {

            Btn_Save.Enabled = true;
            clsPeople = new clsPeople_BL();
            if (CB_mode == eCBMode.PersonID)
                clsPeople.LoadPersonByID(Convert.ToInt32(Value));
            else
                clsPeople.LoadPersonDataNationalNo(Value);

            if (!Utilities.Methods.Fill_UC_Person_Controls(UC_ShowPersonInfo, clsPeople))
            {
                MessageBox.Show("We Didn't Find Person", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UC_ShowPersonInfo.ResetControls();
                Btn_Save.Enabled = false;
            }


        }

        private void UC_ShowPersonInfo_SendRequestToGetImage(bool Request, string ImageKey)
        {
            Utilities.Methods.SetImage(UC_ShowPersonInfo, Request, ImageKey);
        }

        private void Btn_Next_Click(object sender, EventArgs e)
        {
            TC_PersonalInfo.SelectedIndex = 1;
        }



        private void Btn_Save_Click(object sender, EventArgs e)
        {


            #region Validation 


            if (License_Class.GetID() == -1)
            {

                MessageBox.Show(
               "Please Add Class"
               ,
               "Error",
              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (clsLocalDriverLicense == null || clsLocalDriverLicense.mode == clsApplication_BL.eMode.Add)
                clsLocalDriverLicense = new clsNewLocalDriverLicenseApplication_BL(License_Class.GetID(), clsPeople.PersonID);



            if (clsPeople == null)
            {

                MessageBox.Show(
               "Please Add Person"
               ,
               "Error",
              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            if (!Utilities.Methods.IsAgeValid(License_Class.GetMinimumAllowedAge(), clsPeople.DateOfBirth))
            {

                MessageBox.Show(
               "Person Age not Allowed For This License Class" +
                "\nPerson Age:" + (DateTime.Now.Year - clsPeople.DateOfBirth.Year).ToString() +
                "\nMinimum Allowed Age For License: " + License_Class.GetMinimumAllowedAge().ToString(),
               "Error",
              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if ((clsApplication_BL.IsPersonHaveNewApp(clsPeople.PersonID, License_Class.GetID()))
                  ==
             clsApplication_BL.eModeState.New)
            {
                MessageBox.Show("The Person Already Have New Application", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (clsApplication_BL.IsPersonHaveCompletedApp(clsPeople.PersonID, License_Class.GetID())
                   == clsApplication_BL.eModeState.Completed)
            {
                MessageBox.Show("The Person Already Have License He con't Getting New License From Same Type ", "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            #endregion End



            clsLocalDriverLicense.SetLicenseClassID(License_Class.GetID());
            if (clsLocalDriverLicense.Save())
            {
                Pic_AddNewPerson.Enabled = false;
                UC_Filter.Enabled = false;
                UC_ShowPersonInfo.Enabled = false;
                Label_Const_FormTitle.Text = "Update Local Driving License";
                Label_Variable_DL_AppID.Text = clsLocalDriverLicense.GetLDLA().ToString();
                MessageBox.Show("Application " + Mode + " ", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                Mode = "Update";
            }


        }

        private void ComboBox_LicenseClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            License_Class = new clsLicenseClass_BL(ComboBox_LicenseClass.Text);
        }
        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Pic_AddNewPerson_Click(object sender, EventArgs e)
        {
            // FIXME: Add New Person Window - Click
        }

        private void UC_ShowPersonInfo_SendEditEvent()
        {
            // FIXME: Edit Person Window - Click

        }


    }
}
