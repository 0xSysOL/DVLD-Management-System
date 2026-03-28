using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.User_Controls.Users_User_Control
{
    public partial class UC_LoginInfo : UserControl
    {
        public UC_LoginInfo()
        {
            InitializeComponent();
        }

        public void SetUserID(int UserID) 
        {

            Label_Variable_UserID.Text = UserID.ToString();

        }
        public void SetUsername(string Username)
        {

            Label_Variable_Username.Text = Username;
        }
        public void SetIsActive(bool Value)
        {

            Label_Variable_IsActive.Text = (Value == true) ? " Yse" : "No";

        }
      
    }
}
