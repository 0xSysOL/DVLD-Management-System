using DVLD.Sub_Forms.People_Forms;
using DVLD.User_Controls;
using DVLD.User_Controls.Users_User_Control;
using DVLD_BusinessLogic;
using DVLD_BussinessLogic.Users_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Sub_Forms.Users_Forms
{
    public partial class Frm_ChangePassword : Form
    {

        clsUsers_BL clsUser;
        clsPeople_BL clsPerson;
        private int _InitializeUserDate(int ID)
        {

            if(ID != -1)
            {
                clsUser = new clsUsers_BL(ID);
                _UC_ChangeUserPassword.SetUserID(clsUser.UserID);
                _UC_ChangeUserPassword.SetUsername(clsUser.Username);
                _UC_ChangeUserPassword.SetIsActive(clsUser.IsActive);
               
                return clsUser.PersonID;
            }else
            {
                TB_CurrentPassword.Enabled = false;
                TB_Password.Enabled = false;
                TB_ConfirmPassword.Enabled = false;
                Btn_Save.Enabled = false;
            }


            return -1;
        }
        private void _InitializePersonInfo()
        {

            if (clsUser.PersonID == -1)
                return;


            clsPerson = new clsPeople_BL(clsUser.PersonID);
            Utilities.Methods.Fill_UC_Controls(uC_ShowPersonInfo,clsPerson);


        }
        public Frm_ChangePassword(int UserID)
        {
            InitializeComponent();
          _InitializeUserDate(UserID);
            _InitializePersonInfo();
            Btn_Save.Enabled = false;

        }



        private void Frm_ChangePassword_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (clsUser.Save())
                MessageBox.Show("Password Changed Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Something Wrong!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void uC_ShowPersonInfo_SendRequestToGetImage(bool Request, string ImageKey)
        {
            if(Request != false)
            Utilities.Methods.SetImage(uC_ShowPersonInfo, Request, ImageKey);


        }

        private void EnabledTextBox(bool On_Off)
        {

            if (On_Off)
            {
                TB_Password.Enabled = true;
                TB_ConfirmPassword.Enabled = true;
            }
            else
            {
                TB_Password.Enabled = false;
                TB_ConfirmPassword.Enabled = false;
            }
        }
        private void TB_CurrentPassword_TextChanged(object sender, EventArgs e)
        {
            if(clsUser.Password == TB_CurrentPassword.Text)
            {
                EnabledTextBox(true);
                TB_CurrentPassword.Enabled = false;
                ErrorProfider_1.SetError(TB_CurrentPassword, "Password Is Much");
                
            }
        }

    

        private void TB_ConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            string Text_1 = TB_ConfirmPassword.Text;
            string Text_2 = TB_Password.Text;

            if (string.IsNullOrEmpty(Text_1) && string.IsNullOrEmpty(Text_2))
                return;

            if (Text_1 == Text_2)
            {
                ErrorProfider_1.SetError(TB_Password, "Right Password");
                ErrorProfider_1.SetError(TB_ConfirmPassword, "Right Password");
                Btn_Save.Enabled = true;
                clsUser.Password = Text_1;

            }
            else
            Btn_Save.Enabled = false;

        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SavePerson(clsPeople_BL PersonInfo)
        {
            clsPerson = PersonInfo;
            clsPerson.Save();
            Utilities.Methods.Fill_UC_Controls(uC_ShowPersonInfo, clsPerson);

        }
        private void uC_ShowPersonInfo_SendEditEvent()
        {
            Frm_Add_Edit_People frm_Add_Edit = new Frm_Add_Edit_People(clsUser.PersonID);
            frm_Add_Edit.Retrieve_1 = SavePerson;
            frm_Add_Edit.ShowDialog();

        }
    }
}
