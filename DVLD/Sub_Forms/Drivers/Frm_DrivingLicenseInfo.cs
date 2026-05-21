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
    public partial class Frm_DrivingLicenseInfo : Form
    {
        public Frm_DrivingLicenseInfo(int ApplicationID)
        {
            InitializeComponent();
            InitializeUC_LicenseInfo(ApplicationID);

        }

        private void InitializeUC_LicenseInfo(int ApplicationID)
        {

            Utilities.Methods.Fill_UC_LicenseInfo(UC_LicenseInfo, ApplicationID, "ApplicationID");

        }

        private void Frm_DrivingLicenseInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
