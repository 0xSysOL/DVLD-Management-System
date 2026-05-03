using DVLD.Properties;
using DVLD_BussinessLogic.Application_Classes;
using DVLD_BussinessLogic.Application_Classes.Application;
using DVLD_BussinessLogic.License_Class;
using DVLD_BussinessLogic.Users_Classes.User_Setting;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace DVLD.Sub_Forms.Application.Tests_Appointment.Schedule_Tests
{
    public partial class Frm_ScheduleTests : Form
    {
        int LDLAPP_ID;
        int APP_ID;
        bool Bool_IsPersonTakeTestBefore = true;
        Utilities.Methods.eTestTypes eTestTypes;
        string LicenseClassName;
        string FullName;
        int Trial;
        DateTime AppointmentDate;
        decimal TestFees;

        private void InitializeTitlesForm()
        {
            switch (eTestTypes)
            {

                case Utilities.Methods.eTestTypes.VisionTest:
                    Pic_FormPicture.Image = Resources.eye_scan__1_;
                    this.Text = "Vision Test Appointment";
                    Label_Variable_FormTitle.Text = "Vision Test Appointment";
                    GroubBox_ST.Text = "Vision Test";
                    break;

                case Utilities.Methods.eTestTypes.WrittenTest:
                    Pic_FormPicture.Image = Resources.writing;
                    this.Text = "Written Test Appointment";
                    Label_Variable_FormTitle.Text = "Written Test Appointment";
                    GroubBox_ST.Text = "Written Test";
                    break;

                case Utilities.Methods.eTestTypes.StreetTest:
                    Pic_FormPicture.Image = Resources.test;
                    this.Text = "Street Test Appointment";
                    Label_Variable_FormTitle.Text = "Street Test Appointment";
                    GroubBox_ST.Text = "Street Test";
                    break;


            }




        }
       

        private void InitializeDatePicker()
        {
            _DateTimePicker.MinDate = DateTime.Now.AddDays(1);
            _DateTimePicker.MaxDate = DateTime.Now.AddDays(30);
            _DateTimePicker.CustomFormat = "dd/MM/yyyy";
        }

        private void InitializeLabels()
        {
            string LicenseClassName = "";
            string FullName = "";
            int Trial = 0;
            DateTime AppointmentDate = DateTime.Now;
            decimal TestFees = 0;



            if (Bool_IsPersonTakeTestBefore = clsTestAppointment_BL.IsPersonTakeTestBefore(LDLAPP_ID, (int)eTestTypes))
            {
                clsTestAppointment_BL.GetTestAppointmentDetails(LDLAPP_ID, (int)eTestTypes, ref LicenseClassName,
                             ref FullName, ref Trial, ref AppointmentDate, ref TestFees);
                _DateTimePicker.Value = AppointmentDate;
                Label_Variable_FormTitle.Text = "Schedule Retake Test";

            }
            {
                clsTestAppointment_BL.GetApplicationDetailsForNewAppointment(LDLAPP_ID, (int)eTestTypes,
                    ref LicenseClassName, ref FullName, ref Trial, ref AppointmentDate, ref TestFees);
                UC_RetakeTestInfo.Enabled = false;  
                Label_Variable_FormTitle.Text = "        Schedule Test";


            }

            Label_Variable_L_D_App_ID.Text = LDLAPP_ID.ToString();
            Label_Variable_Name.Text = FullName;
            Label_Variable_Trial.Text = Trial.ToString();
            Label_Variable_Fees.Text = TestFees.ToString();
            Label_Variable_D_Class.Text = LicenseClassName;
          

        }
        public Frm_ScheduleTests()
        {
            InitializeComponent();
            LDLAPP_ID = -1;
            APP_ID = -1;
            eTestTypes = Utilities.Methods.eTestTypes.None;
            LicenseClassName = "";
            FullName = "";
            Trial = 0;
            AppointmentDate = DateTime.Now;
            TestFees = 0;

        }

        public Frm_ScheduleTests(int LDLAPP_ID, int TestType,int APP_ID) : this()
        {
            this.LDLAPP_ID = LDLAPP_ID;
            this.APP_ID = APP_ID;
            eTestTypes = (Utilities.Methods.eTestTypes)TestType;
            InitializeTitlesForm();
            InitializeDatePicker();
            InitializeLabels();
        }


        private void Frm_ScheduleTests_Load(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (Bool_IsPersonTakeTestBefore)
            {
                clsRetakeTestApplication_BL clsRetakeTest = new clsRetakeTestApplication_BL();
                clsLicenseClass_BL LicenseClass = new clsLicenseClass_BL();

                clsRetakeTest.ApplicationDate = DateTime.Now;
                clsRetakeTest.ApplicationState = (int)clsApplication_BL.eModeState.New;
                clsRetakeTest.PaidFees = -1;


                //clsRetakeTest.


                //clsTestAppointment_BL.Save(LDLAPP_ID,(int)eTestTypes,_DateTimePicker.Value,
                //    PaidFees,CurrentUser.GetUserID,);

            }

        }


    }
}
