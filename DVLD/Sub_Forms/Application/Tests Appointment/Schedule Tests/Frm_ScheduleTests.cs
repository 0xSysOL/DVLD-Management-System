using DVLD.Properties;
using DVLD_BussinessLogic.Application_Classes;
using DVLD_BussinessLogic.Application_Classes.Application;
using DVLD_BussinessLogic.License_Class;
using DVLD_BussinessLogic.Users_Classes.User_Setting;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using static DVLD_BussinessLogic.Application_Classes.Application.clsApplication_BL;

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
        clsTestAppointment_BL clsTestAppointment;
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
        

            if (Bool_IsPersonTakeTestBefore = clsTestAppointment_BL.IsPersonTakeTestBefore(LDLAPP_ID, (int)eTestTypes))
            {
                clsTestAppointment_BL.GetTestAppointmentDetails(LDLAPP_ID, (int)eTestTypes, ref LicenseClassName,
                             ref FullName, ref Trial, ref AppointmentDate, ref TestFees);

                Label_Variable_FormTitle.Text = "Schedule Retake Test";

            }
            else
            {
                clsTestAppointment_BL.GetApplicationDetailsForNewAppointment(LDLAPP_ID, (int)eTestTypes,
                    ref LicenseClassName, ref FullName, ref Trial, ref AppointmentDate, ref TestFees);
                UC_RetakeTestInfo.Enabled = clsTestAppointment.mode == clsTestAppointment_BL.eMode.Update;  
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
            clsTestAppointment = new clsTestAppointment_BL();
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

        public Frm_ScheduleTests(int AppointmentID, int LDLAPP_ID, int TestType, int APP_ID) : this()
        {
            clsTestAppointment = new clsTestAppointment_BL(AppointmentID);
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

        private void AddUpdate_Appointment(object RetakeTest = null)
        {
            clsTestAppointment.SetLDLApplicationID(LDLAPP_ID);
            clsTestAppointment.SetTestTypeID((int)eTestTypes);
            clsTestAppointment.SetAppointmentDate(_DateTimePicker.Value);
            clsTestAppointment.SetCreateByUserID(CurrentUser.GetUserID());
            clsTestAppointment.SetRetakeTeApp(RetakeTest);
            clsTestAppointment.SetPaidFees(Convert.ToDecimal(Label_Variable_Fees.Text));

            if (clsTestAppointment.mode != clsTestAppointment_BL.eMode.Add)
            {
                if (clsTestAppointment.Save())
                {
                    MessageBox.Show("Appointment Updated Successfully", "info", MessageBoxButtons.OK
                  , MessageBoxIcon.Information);
                }
                return;
            }


            if (clsTestAppointment.Save())
            {
                MessageBox.Show("Appointment Added Successfully", "info", MessageBoxButtons.OK
              , MessageBoxIcon.Information);
            }

        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {


            if(clsTestAppointment.mode == clsTestAppointment_BL.eMode.Update)
            {
                AddUpdate_Appointment();
                return;
            }

            if (Bool_IsPersonTakeTestBefore)
            {

                clsRetakeTestApplication_BL clsRetakeTest = new clsRetakeTestApplication_BL(APP_ID);

                // FIXME: TransAction
                if (clsRetakeTest.Save())
                {
                    AddUpdate_Appointment(clsRetakeTest.Get_BaseAPP_ID());
                    UC_RetakeTestInfo.SetRTestAppID(clsRetakeTest.Get_BaseAPP_ID());
                }
                else
                    MessageBox.Show("Something Wrong Please Try Agian", "Error", MessageBoxButtons.OK
                        , MessageBoxIcon.Error);
                

                return;
            }

            // Appointment For First Time
            AddUpdate_Appointment();


        }

        private void GroubBox_ST_Enter(object sender, EventArgs e)
        {

        }

        private void UC_RetakeTestInfo_Load(object sender, EventArgs e)
        {
            clsManageApplicationTypes_BL APPType = new clsManageApplicationTypes_BL
                            ((int)enApplicationType.RetakeTest);

            UC_RetakeTestInfo.SetRAppFees(APPType.GetFees());

            UC_RetakeTestInfo.SetTotalFees(TestFees + APPType.GetFees());
            

        }
    }


    
}
