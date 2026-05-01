using DVLD.Properties;
using DVLD.Sub_Forms.Application.Tests_Appointment.Schedule_Tests;
using DVLD_BussinessLogic.Application_Classes;
using DVLD_BussinessLogic.Application_Classes.Application;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DVLD.Sub_Forms.Application.Schedule_Tests
{
    public partial class Frm_Schedule_TestsAppointments : Form
    {
        int LDLAPP_ID;
        Utilities.Methods.eTestTypes eTestTypes;

        private void InitializeTitlesForm()
        {
            switch (eTestTypes)
            {

                case Utilities.Methods.eTestTypes.VisionTest:
                    Pic_FormPicture.Image = Resources.eye_scan__1_;
                    this.Text = "Vision Test Appointment";
                    Label_Variable_FormTitle.Text = "Vision Test Appointment";

                    break;

                case Utilities.Methods.eTestTypes.WrittenTest:
                    Pic_FormPicture.Image = Resources.writing;
                    this.Text = "Written Test Appointment";
                    Label_Variable_FormTitle.Text = "Written Test Appointment";

                    break;

                case Utilities.Methods.eTestTypes.StreetTest:
                    Pic_FormPicture.Image = Resources.test;
                    this.Text = "Street Test Appointment";
                    Label_Variable_FormTitle.Text = "Street Test Appointment";
                    break;


            }


            //Image image = null;
            //string TitleForm = "";
            //string LabelTitleForm = "";

            //Utilities.Methods.InitializeTitlesForm
            //    (ref TitleForm, ref LabelTitleForm, eTestTypes, ref image);

            //Pic_FormPicture.Image = image;
            //this.Text = TitleForm;
            //Label_Variable_FormTitle.Text = LabelTitleForm;

        }
        public Frm_Schedule_TestsAppointments()
        {
            InitializeComponent();
            LDLAPP_ID = -1;
            eTestTypes = Utilities.Methods.eTestTypes.None;
        }
        public Frm_Schedule_TestsAppointments(int LDLAPP_ID, int TestTypeID) : this()
        {
            this.LDLAPP_ID = LDLAPP_ID;
            eTestTypes = (Utilities.Methods.eTestTypes)TestTypeID;
            InitializeTitlesForm();

        }



        private void Frm_Schedule_TestsAppointments_Load(object sender, EventArgs e)
        {
            _DataGridView.DataSource = clsTestAppointment_BL.GetAppointmentInfoBy_LDLAPP_ID(LDLAPP_ID, (int)eTestTypes);
            Label_Variable_Records.Text = _DataGridView.Rows.Count.ToString();
        }

        private void UC_DrivingLicenseApplication_Info_Load(object sender, EventArgs e)
        {
            Utilities.Methods.UC_FillDrivingLicenseApplicationInfo(LDLAPP_ID, UC_DrivingLicenseApplication_Info, eTestTypes);

        }

        private void UC_ApplicationBasic_Info_Load(object sender, EventArgs e)
        {
            Utilities.Methods.UC_FillApplicationBasic_Info(LDLAPP_ID, UC_ApplicationBasic_Info, eTestTypes);

        }

        private void Pic_AddNewAppointment_Click(object sender, EventArgs e)
        {

            if (clsApplication_BL.FindAnyActiveAppointment(LDLAPP_ID, (int)eTestTypes))
            {
                MessageBox.Show(
                    "Person Already Have An Active Appointment!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }


            if (clsApplication_BL.IsPersonPassedTest(LDLAPP_ID, (int)eTestTypes))
            {
                MessageBox.Show(
           "Person Passed the Test He Can't Retake test Again!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            Frm_ScheduleTests scheduleTests = new Frm_ScheduleTests(LDLAPP_ID, (int)eTestTypes);

            scheduleTests.ShowDialog();
                
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
