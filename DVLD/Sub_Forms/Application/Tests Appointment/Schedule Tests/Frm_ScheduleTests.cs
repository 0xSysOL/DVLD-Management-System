using DVLD.Properties;
using DVLD_BussinessLogic.Application_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Sub_Forms.Application.Tests_Appointment.Schedule_Tests
{
    public partial class Frm_ScheduleTests : Form
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
        private void IsPersonTakeTestBefore()
        {

            if (!clsTestAppointment_BL.IsPersonTakeTestBefore(LDLAPP_ID, (int)eTestTypes))
            {
                UC_RetakeTestInfo.Enabled = false;
            }

        }

        private void InitializeDatePicker()
        {
            _DateTimePicker.MinDate = DateTime.Now.AddDays(1);
            _DateTimePicker.MaxDate = DateTime.Now.AddDays(30);
            _DateTimePicker.CustomFormat = "dd/MM/yyyy";
        }

        public Frm_ScheduleTests()
        {
            InitializeComponent();
            LDLAPP_ID = -1;
            eTestTypes = Utilities.Methods.eTestTypes.None;
                
        }

        public Frm_ScheduleTests(int LDLAPP_ID,int TestType) : this()
        {
             this.LDLAPP_ID = LDLAPP_ID;
            eTestTypes = (Utilities.Methods.eTestTypes)TestType;
            InitializeTitlesForm();
            IsPersonTakeTestBefore();
            InitializeDatePicker();
        }


        private void Frm_ScheduleTests_Load(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {

        }






    }
}
