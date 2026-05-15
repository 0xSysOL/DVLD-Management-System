using DVLD.Properties;
using DVLD.Sub_Forms.Users_Forms;
using DVLD.User_Controls;
using DVLD.User_Controls.LicenseInfo;
using DVLD.User_Controls.Sechdule_Tests.Vision_Test_Appointment;
using DVLD_BusinessLogic;
using DVLD_BussinessLogic.Application_Classes;
using DVLD_BussinessLogic.Application_Classes.Application;
using DVLD_BussinessLogic.Application_Classes.New_Local_License_App;
using DVLD_BussinessLogic.License_Classes;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DVLD.Utilities
{
    internal class Methods
    {
        public enum eTestTypes { VisionTest = 1, WrittenTest = 2, StreetTest = 3, None = 4 }

        public static void Fill_UC_LicenseInfo(UC_LicenseInfo LI, int ApplicationID)
        {
            // 1. Declare variables to hold the returned data
            string ClassName = "";
            string FullName = "";
            int LicenseID = -1;
            string NationalNo = "";
            string Gender = "";
            string Notes = "";
            string IsActive = "";
            DateTime IssueDate = DateTime.Now;
            DateTime ExpireDate = DateTime.Now;
            DateTime DateOfBirth = DateTime.Now;
            string IssueReason = "";
            int DriverID = -1;
            string IsDetained = "";
            // 2. Call the BL method using the 'ref' keyword for each variable
            clsLicense_BL.GetLicenseInfoByApplicationID(
                ApplicationID,
                ref ClassName,
                ref FullName,
                ref LicenseID,
                ref NationalNo,
                ref Gender,
                ref Notes,
                ref IsActive,
                ref IssueDate,
                ref ExpireDate,
                ref DateOfBirth,
                ref IssueReason,
                ref DriverID,
                ref IsDetained
            );


            // 3. Call the UI Setters to display the data
            LI.SetLabelClass(ClassName);
            LI.SetLabelName(FullName);
            LI.SetLabelLicenseID(LicenseID);
            LI.SetLabelGender(Gender);
            LI.SetLabelIssueDate(IssueDate);
            LI.SetLabelIssueReason(IssueReason);
            LI.SetLabelNote(Notes);
            LI.SetLabelDateOfBirth(DateOfBirth);
            LI.SetLabelDriverID(DriverID);
            LI.SetLabelExpireDate(ExpireDate);
            LI.SetLabelIsDetained(IsDetained);
            LI.SetLabelIsActive(IsActive);
            LI.SetLabelNationalNo(NationalNo);

            string ImageKey = clsPeople_BL.GetImagePath(clsApplication_BL.GetPersonID(ApplicationID));
            if (!string.IsNullOrEmpty(ImageKey))
            {
                string ImagePath = clsPeople_BL.FindImagePath(ImageKey);
                Image image = Image.FromFile(ImagePath);
                LI.SetImage(image);
            }



        }

        public static bool IsDataTableEmpty(DataTable Data)
        {
            if (Data.Rows.Count == 0)
            {

                return true;
            }
            return false;
        }


        public static bool sPersonInfoEmpty(string firstName, string secondName, string thirdName, string lastName, string nationalNo, string phone,
string address)
        {

            return (string.IsNullOrWhiteSpace(firstName) ||
                    string.IsNullOrWhiteSpace(secondName) ||
                    string.IsNullOrWhiteSpace(thirdName) ||
                    string.IsNullOrWhiteSpace(lastName) ||
                    string.IsNullOrWhiteSpace(address) ||
                    string.IsNullOrWhiteSpace(nationalNo) ||
                    string.IsNullOrWhiteSpace(phone));


        }
        public static bool IsDateInCurrentRange(DateTime Max, DateTimePicker Value)
        {

            if (Value == null)
                return false;


            return (Value.Value <= Max);
        }

        public static bool Fill_UC_Person_Controls(UC_ShowPersonInfo UC_Fill, clsPeople_BL PersonData)
        {
            // If Object Null We will stop Processing
            if (PersonData == null || PersonData.PersonID == -1)
                return false;


            // Collecting the Names
            string FullName = PersonData.FirstName + " " + PersonData.SecondName + " " + PersonData.ThirdName + " " + PersonData.LastName;

            // Fill Controls And Will be Showing On Display.
            UC_Fill.FillControls(
                PersonData.PersonID.ToString(), FullName, PersonData.NationalNo,
                (PersonData.Gendor == 0) ? "Male" : "Female", PersonData.Address,
                PersonData.DateOfBirth.ToShortDateString(),
                PersonData.Phone, PersonData.CountryName, PersonData.Email, PersonData.ImageKey);


            return true;
        }
        public static bool Fill_UC_Controls(UC_ShowPersonInfo UC_Fill, DataTable PersonData)
        {


            if (IsDataTableEmpty(PersonData))
            {
                UC_Fill.ResetControls();
                return false;
            }
            string PersonID = PersonData.Rows[0]["PersonID"].ToString();
            string FullName =
                 PersonData.Rows[0]["FirstName"].ToString() + " " +
                PersonData.Rows[0]["SecondName"].ToString() + " " +
                PersonData.Rows[0]["ThirdName"].ToString() + " " +
                PersonData.Rows[0]["LastName"].ToString();

            string Email = PersonData.Rows[0]["Email"].ToString() != null ?
                PersonData.Rows[0]["Email"].ToString() : null;
            DateTime DateOfBirth = Convert.ToDateTime(PersonData.Rows[0]["DateOfBirth"].ToString());

            UC_Fill.FillControls(PersonID,
            FullName,
            PersonData.Rows[0]["NationalNo"].ToString(),
             PersonData.Rows[0]["Gendor"].ToString(),
              PersonData.Rows[0]["Address"].ToString(),
               DateOfBirth.ToShortDateString(),
                PersonData.Rows[0]["Phone"].ToString(),
                 PersonData.Rows[0]["Nationality"].ToString(),
                  Email,
                  PersonData.Rows[0]["ImagePath"].ToString()
                );


            return true;
        }


        public static void FillComboBOX(DataTable dataTable, ComboBox ComboBOX, int Index = 0)
        {

            if (dataTable == null) return;

            foreach (DataRow data in dataTable.Rows)
            {
                ComboBOX.Items.Add(data[Index]);
            }
            if (ComboBOX != null)
                ComboBOX.SelectedIndex = 0;


        }


        public static string OpenFileSystem()
        {

            OpenFileDialog openFile = new OpenFileDialog();
            openFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            openFile.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            openFile.DefaultExt = "png";

            if (openFile.ShowDialog() == DialogResult.OK)
                return openFile.FileName;



            return null;

        }
        public static void Ut_ShowMessageBox(string Mode)
        {

            MessageBox.Show("User " + ((Mode == "Update") ? "Updated" : "Added") + " Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
        public static void Show_AddEdit_NewUser(int ID = -1)
        {

            Frm_AddNewUser frm_AddNew = new Frm_AddNewUser(ID);
            frm_AddNew.ShowDialog();


        }


        public static void SetImage(UC_ShowPersonInfo User_Control, bool Request, string ImageKey)
        {

            if (Request != false)
                User_Control.SetImage(clsPeople_BL.FindImagePath(ImageKey));


        }


        public static bool IsDecimal(TextBox TB)
        {

            if (TB.Text.All(c => char.IsDigit(c) || c == '.'))
                return true;
            else
                return false;



        }

        public static void Fill_ApplicationType(int ApplicationID, ref clsManageApplicationTypes_BL APPT)
        {

            APPT = new clsManageApplicationTypes_BL(ApplicationID);

        }
        public static bool IsAgeValid(short AllowedAge, DateTime DateOfBirth)
        {
            DateTime date = DateTime.Now;

            if (DateOfBirth.Year <= date.AddYears(-Convert.ToInt32(AllowedAge)).Year)
                return true;

            return false;

        }


        public static void UC_FillDrivingLicenseApplicationInfo
            (int LDLAPP_ID, UC_DrivingLicenseApplication_Info DLAPPI)
        {
            string LicenseName = "";
            int PassedTests = 0;
            clsNewLocalDriverLicenseApplication_BL.GetDrivingLicenseInfo(LDLAPP_ID, ref LicenseName, ref PassedTests);
            DLAPPI.SetLabel_DLAPP_ID(LDLAPP_ID);
            DLAPPI.SetLabel_PassedTests(PassedTests);
            DLAPPI.SetLabel_AppliedForLicense(LicenseName);


        }


        public static int UC_FillApplicationBasic_Info(int LDLAPP_ID, UC_ApplicationBasic_Info APPBI)
        {
            string ApplicationStatus = "";
            int ApplicationID = -1;
            decimal ApplicationFees = -1;
            string ApplicationTypeTitle = "";
            string FullName = "";
            DateTime ApplicationDate = new DateTime();
            DateTime ApplicationDateStatus = new DateTime();
            string Username = "";


            clsApplication_BL.GetApplicationBasicInfo(LDLAPP_ID, ref ApplicationStatus, ref ApplicationID,
                ref ApplicationFees,
               ref ApplicationTypeTitle, ref FullName, ref ApplicationDate, ref ApplicationDateStatus, ref Username);

            APPBI.SetLabel_AppID(ApplicationID);
            APPBI.SetLabel_Applicant(FullName);
            APPBI.SetLabel_Fees(ApplicationFees);
            APPBI.SetLabel_Date(ApplicationDate);
            APPBI.SetLabel_DateStatus(ApplicationDateStatus);
            APPBI.SetLabel_CreatedByUser(Username);
            APPBI.SetLabel_Type(ApplicationTypeTitle);
            APPBI.SetLabel_Status(ApplicationStatus);

            return ApplicationID;

        }



        public static void InitializeTitlesForm(ref string TitleForm, ref string LabelTitleForm, eTestTypes eTestTypes, ref Image image)
        {

            switch (eTestTypes)
            {

                case eTestTypes.VisionTest:
                    image = Resources.eye_scan__1_;
                    TitleForm = "Vision Test Appointment";
                    LabelTitleForm = "Vision Test Appointment";

                    break;

                case eTestTypes.WrittenTest:
                    image = Resources.writing;
                    TitleForm = "Written Test Appointment";
                    LabelTitleForm = "Written Test Appointment";

                    break;

                case eTestTypes.StreetTest:
                    image = Resources.test;
                    TitleForm = "Street Test Appointment";
                    LabelTitleForm = "Street Test Appointment";
                    break;


            }

        }









    }



}
