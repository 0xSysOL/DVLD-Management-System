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
    public partial class UC_ApplicationBasic_Info : UserControl
    {
        public UC_ApplicationBasic_Info()
        {
            InitializeComponent();

            return;
            Label_Variable_Applicant.Text = "";
            Label_Variable_APP_ID.Text = "";
            Label_Variable_Fees.Text = "";
            Label_Variable_Status.Text = "";
            Label_Variable_Type.Text = "";
            
            Label_Variable_CreateByUser.Text = "";
            Label_Variable_Date.Text = "";
            Label_Variable_DateStatus.Text = "";

         
          
        }
        public void SetLabel_Applicant(string FullName) => Label_Variable_Applicant.Text = FullName;

        public void SetLabel_AppID(int ApplicationID) => Label_Variable_APP_ID.Text = ApplicationID.ToString();

        public void SetLabel_Fees(decimal Fees) => Label_Variable_Fees.Text = Fees.ToString("F2");

        public void SetLabel_Status(string Status) => Label_Variable_Status.Text = Status;

        public void SetLabel_Type(string TypeTitle) => Label_Variable_Type.Text = TypeTitle;

        public void SetLabel_CreatedByUser(string Username) => Label_Variable_CreateByUser.Text = Username;

        public void SetLabel_Date(DateTime AppDate) => Label_Variable_Date.Text = AppDate.ToShortDateString();

        public void SetLabel_DateStatus(DateTime StatusDate) => Label_Variable_DateStatus.Text = StatusDate.ToShortDateString();
        public virtual event Action SendEventToOpenPersonInfo;


        protected void SendEventPersonInfo()
        {
            SendEventToOpenPersonInfo.Invoke();
        }


        private void UC_ApplcationBasic_Info_Load(object sender, EventArgs e)
        {

        }

        private void LinkLabel_Const_ViewPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SendEventPersonInfo();
        }
    }
}
