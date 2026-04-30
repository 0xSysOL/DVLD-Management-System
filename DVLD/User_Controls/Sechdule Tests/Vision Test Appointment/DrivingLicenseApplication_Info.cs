using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.User_Controls.Sechdule_Tests.Vision_Test_Appointment
{
    public partial class UC_DrivingLicenseApplication_Info : UserControl
    {
        public UC_DrivingLicenseApplication_Info()
        {
            InitializeComponent();
        }

        public virtual event Action SendRequestToOpenLicenseInfo;
        
        protected void SendEvent()
        {
            SendRequestToOpenLicenseInfo.Invoke();
        }

        public void SetLabel_AppliedForLicense(string LicenseName)
        {

            Label_Variable_Applied_FL.Text = LicenseName;

        }
        public void SetLabel_DLAPP_ID(int DLAPP_ID)
        {

            Label_Variable_DLAPP_ID.Text = DLAPP_ID.ToString();


        }
        public void SetLabel_PassedTests(short PassedTests)
        {
            Label_Variable_PassesTests.Text = PassedTests.ToString() + "/3";
        }
        
        private void Label_Variable_DLAPP_ID_Click(object sender, EventArgs e)
        {

        }

        private void groupBox_DLAI_Enter(object sender, EventArgs e)
        {

        }

        private void linkLabel_Const_SLI_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            SendEvent();


        }
    }
}
