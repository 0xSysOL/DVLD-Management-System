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
        clsApplication_BL NewApplication;
        clsManageApplicationTypes_BL ApplicationType;
        clsLicenseClass_BL License_Class;
        clsNewLocalDriverLicenseApplication_BL NewDriverLicense;
        public Frm_NewLocalLicense()
        {
            InitializeComponent();
            InitializeApplicationClass();
            InitializeNewDriverLicense();
            Utilities.Methods.Fill_ApplicationType(1, ref ApplicationType);
        }


        private void InitializeApplicationClass()
        {
            NewApplication = new clsApplication_BL();
        }

        private void InitializeNewDriverLicense()
        {
            NewDriverLicense = new clsNewLocalDriverLicenseApplication_BL();
        }
        // see more please
        private void InitializeApplicationFees()
        {
            // this will be change 
            // we will retrive data from database
            Label_Variable_ApplicationFees.Text = "15";

        }
        private void Frm_NewLocalLicense_Load(object sender, EventArgs e)
        {
            InitializeComboBox();
            InitializeComboBoxLicenseClass();
            UC_Filter_ShowPicButtonSearch();
            InitializeAppInfoControls();
        }

        private void Label_Variable_UserID_Click(object sender, EventArgs e)
        {

        }


        private void InitializeAppInfoControls()
        {
            Label_Variable_ApplicationDate.Text = DateTime.Now.ToShortDateString();
            InitializeApplicationFees();
            Label_Variable_CreateBy.Text = CurrentUser.GetUserName();

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

            if (!Utilities.Methods.Fill_UC_Controls(UC_ShowPersonInfo, clsPeople))
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

        private void Label_Variable_CreateBy_Click(object sender, EventArgs e)
        {

        }



        private void Btn_Save_Click(object sender, EventArgs e)
        {

            License_Class = new clsLicenseClass_BL(ComboBox_LicenseClass.Text);
            short GetMinimumAllowedAge = License_Class.GetMinimumAllowedAge();

            if (NewApplication.mode == clsApplication_BL.eMode.Add)
            {
                #region Validation 

                if (!Utilities.Methods.IsAgeValid(GetMinimumAllowedAge, clsPeople.DateOfBirth))
                {

                    MessageBox.Show(
                   "Person Age not Allowed For This License Class" +
                    "\nPerson Age:" + (DateTime.Now.Year - clsPeople.DateOfBirth.Year).ToString() +
                    "\nMinimum Allowed Age For License: " + License_Class.GetMinimumAllowedAge().ToString(),
                   "Error",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                if((NewApplication.IsPersonHaveNewApp(clsPeople.PersonID, License_Class.GetID()))
                      ==
                 clsApplication_BL.eModeState.New)
                {
                    MessageBox.Show("The Person Already Have New Application", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (NewApplication.IsPersonHaveCompletedApp(clsPeople.PersonID, License_Class.GetID())
                       == clsApplication_BL.eModeState.Completed)
                {
                    MessageBox.Show("The Person Already Have License He con't Getting New License From Same Type ", "Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                #endregion End
            }



            // Start Processing
            if (NewApplication.mode != clsApplication_BL.eMode.Update)
            {
                NewApplication.PersonID = clsPeople.PersonID;
                NewApplication.ApplicationDate = DateTime.Now;
                NewApplication.ApplicationTypeID = ApplicationType.GetID();
            }



            NewApplication.LastStateDate = DateTime.Now;
            NewApplication.PaidFees = License_Class.GetClassFees();
            NewApplication.UserID = CurrentUser.GetUserID();

            if (NewApplication.Save(GetMinimumAllowedAge, clsPeople.DateOfBirth, License_Class.GetID()))
            {
                NewDriverLicense.SetApplicationID(NewApplication.GetID());
                NewDriverLicense.SetLicenseClassID(License_Class.GetID());

                if (NewDriverLicense.Save())
                {
                    Pic_AddNewPerson.Enabled = false;
                    UC_Filter.Enabled = false;
                    UC_ShowPersonInfo.Enabled = false;
                    Label_Variable_DL_AppID.Text = NewApplication.GetID().ToString();
                    Label_Const_FormTitle.Text = "Update Local Driving License";

                    MessageBox.Show("Application " + NewApplication.mode.ToString() + " ", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    // delete Application And Show Error
                }


            }



        }
    }
}
