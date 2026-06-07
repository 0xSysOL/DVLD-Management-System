using System;
using System.Windows.Forms;

namespace DVLD.User_Controls.Detain
{
    public partial class UC_ShowDetainInfo : UserControl
    {
        public UC_ShowDetainInfo()
        {
            InitializeComponent();


        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Label_Const_LicenseID_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox_DeIn_Enter(object sender, EventArgs e)
        {

        }
        public void SetDetainID(int Value)
        {
            Label_Variable_D_ID.Text = Value.ToString();

        }
        private void Label_Variable_D_ID_Click(object sender, EventArgs e)
        {

        }

        public void SetApplicationFees(decimal Value)
        {
            Label_Variable_ApplicationFees.Text = Value.ToString();

        }
        private void Label_Variable_ApplicationFees_Click(object sender, EventArgs e)
        {

        }
        public void SetFineFees(decimal Value)
        {
            Label_Variable_FineFees.Text = Value.ToString();
        }
        private void Label_Variable_FineFees_Click(object sender, EventArgs e)
        {
        }

        public void SetDetainDate(DateTime Value)
        {

            Label_Variable_D_Date.Text = Value.ToShortDateString();

        }
        public void SetUserName(string  Value)
        {

            Label_Variable_CreateBy.Text = Value.ToString();

        }

        public void SetTotalFees(decimal Value)
        {
            Label_Variable_TotalFees.Text = Value.ToString();
        }
        private void Label_Variable_TotalFees_Click(object sender, EventArgs e)
        {

        }

        public void SetApplicationID(int Value)
        {
            Label_Variable_ApplicationID.Text = Value.ToString();
        }
        private void Label_Variable_ApplicationID_Click(object sender, EventArgs e)
        {

        }
        public void SetLicenseID(int Value)
        {
            Label_Variable_L_ID.Text = Value.ToString();
        }
        private void Label_Variable_L_ID_Click(object sender, EventArgs e)
        {

        }



    }
}
