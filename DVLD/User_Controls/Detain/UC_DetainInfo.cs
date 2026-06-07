using DVLD_BussinessLogic.Users_Classes.User_Setting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.User_Controls.Detain
{
    public partial class UC_DetainInfo : UserControl
    {
        public UC_DetainInfo()
        {
            InitializeComponent();
            Label_Variable_D_Date.Text = DateTime.Now.ToShortDateString();
            Label_Variable_CreateBy.Text = CurrentUser.GetUserName();

        }

        public void SetDetainID(int DetainID) 
        {
            Label_Variable_D_ID.Text = DetainID.ToString();
        }
        public void SetLicenseID(int LicenseID)
        {
            if (LicenseID != -1)
                Label_Variable_L_ID.Text = LicenseID.ToString();
            else
                Label_Variable_L_ID.Text = "No Value";
        }
        



        public decimal GetDineFees()
        {
            decimal FineFees = 0;
            if (!string.IsNullOrEmpty(TB_FineFees.Text))
                 FineFees = Convert.ToDecimal(TB_FineFees.Text);
            else
                return 0;

            return FineFees;
        }

        private void UC_DetainInfo_Load(object sender, EventArgs e)
        {

        }

        private void GroupBox_DeIn_Enter(object sender, EventArgs e)
        {

        }

        private void TB_FineFees_TextChanged(object sender, EventArgs e)
        {
        }

        private void TB_FineFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
               e.Handled = true;
           
            
        }
    }
}
