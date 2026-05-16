using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Sub_Forms.Application
{
    public partial class Frm_ApplicationDetails : Form
    {

        public void Initialize_UC_DLAPPI(int LDLAPPID)
        {

            Utilities.Methods.UC_FillDrivingLicenseApplicationInfo(LDLAPPID, UC_DrivingLicenseApplication_Info);
            
        }
        public void Initialize_UC_APPBI(int LDLAPPID)
        {
            Utilities.Methods.UC_FillApplicationBasic_Info(LDLAPPID, UC_ApplicationBasic_Info);

        }
        public Frm_ApplicationDetails(int LDLAPPID)
        {
            InitializeComponent();
            Initialize_UC_APPBI(LDLAPPID);
            Initialize_UC_DLAPPI(LDLAPPID);
        }

        private void uC_ApplicationBasic_Info1_SendEventToOpenPersonInfo()
        {

        }

        private void Frm_ApplicationDetails_Load(object sender, EventArgs e)
        {

        }




    }
}
