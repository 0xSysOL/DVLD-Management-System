using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.User_Controls
{
    public partial class UC_LicenseFilter : UserControl
    {
        public UC_LicenseFilter()
        {
            InitializeComponent();
        }
        public event Action<int> evSendResult;

        protected virtual void SendResult(int LicenseID)
        {

            Action <int> action = evSendResult;
            if (action != null)
                action(LicenseID);

        }
        private void TB_Search_TextChanged(object sender, EventArgs e)
        {

        }

        private void TB_Search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)&& !Char.IsDigit(e.KeyChar))
                e.Handled = true;



        }

        private void UC_LicenseFilter_Load(object sender, EventArgs e)
        {

        }

        private void Pic_SearchForPerson_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TB_Search.Text))
                return;

            SendResult(Convert.ToInt32(TB_Search.Text));
        }
    }
}
