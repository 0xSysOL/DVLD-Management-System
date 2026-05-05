using DVLD.Properties;
using DVLD_BussinessLogic.Application_Classes;
using DVLD_BussinessLogic.Application_Classes.Tests_Appointments;
using DVLD_BussinessLogic.Users_Classes.User_Setting;
using System;
using System.Windows.Forms;
using static DVLD.Utilities.Methods;

namespace DVLD.Sub_Forms.Application.Tests_Appointment.Schedule_Tests
{
    public partial class Frm_TakeTest : Form
    {
        Utilities.Methods.eTestTypes eTestTypes;
        int LDLAPP_ID;
        int AppointmentID;


        private Frm_TakeTest()
        {
            InitializeComponent();
            LDLAPP_ID = -1;
            AppointmentID = -1;
            eTestTypes = Utilities.Methods.eTestTypes.None;

        }

        private void InitializeTitlesForm()
        {
            switch (eTestTypes)
            {

                case Utilities.Methods.eTestTypes.VisionTest:
                    Pic_FormPicture.Image = Resources.eye_scan__1_;
                    this.Text = "Take Vision Test";
                    Label_Variable_FormTitle.Text = "        Vision Test";
                    GroubBox_ST.Text = "Vision Test";
                    break;

                case Utilities.Methods.eTestTypes.WrittenTest:
                    Pic_FormPicture.Image = Resources.writing;
                    this.Text = "Take Written Test";
                    Label_Variable_FormTitle.Text = "        Written Test";
                    GroubBox_ST.Text = "Written Test";
                    break;

                case Utilities.Methods.eTestTypes.StreetTest:
                    Pic_FormPicture.Image = Resources.test;
                    this.Text = "Take Street Test";
                    Label_Variable_FormTitle.Text = "        Street Test";
                    GroubBox_ST.Text = "Street Test";
                    break;


            }
        }
        public Frm_TakeTest(int AppointmentID, int LDLAPP_ID, int TestTypeID) : this()
        {
            this.AppointmentID = AppointmentID;
            this.LDLAPP_ID = LDLAPP_ID;
            eTestTypes = (eTestTypes)TestTypeID;
            InitializeLabels();
            InitializeTitlesForm();

        }
        private void InitializeLabels()
        {

            string LicenseClassName = "";
            string FullName = "";
            int Trial = 0;
            DateTime AppointmentDate = DateTime.Now;
            decimal TestFees = 0;



            clsTestAppointment_BL.GetTestAppointmentDetails(LDLAPP_ID, (int)eTestTypes, ref LicenseClassName,
                            ref FullName, ref Trial, ref AppointmentDate, ref TestFees);



            Label_Variable_L_D_App_ID.Text = LDLAPP_ID.ToString();
            Label_Variable_Name.Text = FullName;
            Label_Variable_Trial.Text = Trial.ToString();
            Label_Variable_Fees.Text = TestFees.ToString();
            Label_Variable_D_Class.Text = LicenseClassName;
            Label_Variable_TestID.Text = AppointmentID.ToString();
            Label_Variable_Date.Text = AppointmentDate.ToShortDateString();




        }

        private void Frm_TakeTest_Load(object sender, EventArgs e)
        {

        }

        private void RadButt_Fail_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Label_Const_Result_Click(object sender, EventArgs e)
        {

        }

        private bool RadButt_IsPersonFailOrPass()
        {
            if (RadButt_Pass.Checked)
                return true;


            return false;
            

        }
        private void Btn_Save_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are sure you want to confirm this process??", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;



            if (clsTests_BL.TakeTest(RadButt_IsPersonFailOrPass(), TB_Note.Text, CurrentUser.GetUserID(),ref AppointmentID))
                MessageBox.Show("Test Added Successfully (:", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("We Couldn't Add Test ):", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);

            this.Close();


        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }










    }
}
