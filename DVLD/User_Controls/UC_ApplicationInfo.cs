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
    public partial class UC_ApplicationInfo : UserControl
    {
        public UC_ApplicationInfo()
        {
            InitializeComponent();
            SetLabelIssueDate(DateTime.Now);
            SetLabelExpireDate(DateTime.Now.AddYears(1));
            SetLabelAppDate(DateTime.Now);

        }
        public void SetLabelAppDate(DateTime value)
        {
            Label_Variable_AppDate.Text = value.ToShortDateString();
        }

        public void SetLabelCreateBy(string value)
        {
            Label_Variable_CreateBy.Text = value;
        }

        public void SetLabelExpireDate(DateTime value)
        {
            Label_Variable_ExpireDate.Text = value.ToShortDateString();
        }

        public void SetLabelFees(decimal value)
        {
            Label_Variable_Fees.Text = value.ToString("C"); // Formats as currency (e.g., $150.00)
        }

        public void SetLabelLLAPPID(int value)
        {
            Label_Variable_LLAPPID.Text = value.ToString();
        }

        public void SetLabelLL_LicenseID(int value)
        {
            Label_Variable_LL_LicenseID.Text = value.ToString();
        }

        public void SetLabelLocalLicenseID(int value)
        {
            if (value <= 0)
                Label_Variable_LocalLicenseID.Text = "........................";
            else
                Label_Variable_LocalLicenseID.Text = value.ToString();
        }

        public void SetLabelIssueDate(DateTime value)
        {
            Label_Variable_IssueDate.Text = value.ToShortDateString();
        }
        private void UC_ApplicationInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
