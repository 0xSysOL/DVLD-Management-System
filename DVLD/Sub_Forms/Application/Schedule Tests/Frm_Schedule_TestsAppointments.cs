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
                    Label_Variable_FormTitle.Text = "Vision Test Appointment";

                    break;

                case Utilities.Methods.eTestTypes.WrittenTest:
                    Pic_FormPicture.Image = Resources.writing;
                    Label_Variable_FormTitle.Text = "Written Test Appointment";

                    break;

                case Utilities.Methods.eTestTypes.StreetTest:
                    Pic_FormPicture.Image = Resources.test;
                    Label_Variable_FormTitle.Text = "Street Test Appointment";
                    break;


            }
        }
        public Frm_Schedule_TestsAppointments()
        {
            InitializeComponent();
            LDLAPP_ID = -1;
            eTestTypes = Utilities.Methods.eTestTypes.None;
        }
        public Frm_Schedule_TestsAppointments(int LDLAPP_ID,int TestTypeID) : this()
        {
            this.LDLAPP_ID = LDLAPP_ID;
            eTestTypes = (Utilities.Methods.eTestTypes)TestTypeID;
            InitializeTitlesForm();

        }



        private void Frm_Schedule_TestsAppointments_Load(object sender, EventArgs e)
        {
            _DataGridView.DataSource = clsTestAppointment_BL.GetAppointmentInfoBy_LDLAPP_ID(LDLAPP_ID, (int)eTestTypes);

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

        }


    }
}
