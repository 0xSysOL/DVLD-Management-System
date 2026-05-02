using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.User_Controls.Sechdule_Tests
{
    public partial class UC_RetakeTestInfo : UserControl
    {
        public UC_RetakeTestInfo()
        {
            InitializeComponent();
            

        }

        public void SetRAppFees(decimal DAPP_Fees)
        {

        }
        public void SetRTestAppID(int RTestID)
        {

        }
        public void SetTotalFees(decimal TotalFees)
        {

        }
        public decimal GetRAppFees()
        {
            return Convert.ToDecimal(Label_Variable_RAppFees.Text);
        }
        public int GetRTestAppID(int RTestID)
        {
            return Convert.ToInt32(Label_Variable_RTestAppID.Text);

        }
        public decimal GetTotalFees()
        {
            return Convert.ToDecimal(Label_Variable_TotalFees.Text);

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UC_RetakeTestInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
