using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Sub_Forms.Drivers
{
    public partial class Frm_InternationalDrivingLicenseInfo : Form
    {

        private void Initialize_UC(int ApplicationID)
        {

            Utilities.Methods.Fill_UC_IntDrivingLicenseInfo(int_LicenseInfo, ApplicationID);
        }
        public Frm_InternationalDrivingLicenseInfo(int ApplicationID)
        {
            InitializeComponent();
            Initialize_UC(ApplicationID);

        }

        private void Frm_InternationalDrivingLicenseInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
