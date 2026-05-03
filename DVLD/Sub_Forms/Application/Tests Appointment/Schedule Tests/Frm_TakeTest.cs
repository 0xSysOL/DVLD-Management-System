using DVLD.User_Controls.Sechdule_Tests;
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
        public Frm_TakeTest(int AppointmentID,int LDLAPP_ID,int TestTypeID) : this()
        {
            this.AppointmentID = AppointmentID;
            this.LDLAPP_ID = LDLAPP_ID;
            eTestTypes = (eTestTypes)TestTypeID;
            InitializeLabels();
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
    }
}
