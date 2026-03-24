using DVLD.Sub_Forms.People_Forms;
using DVLD.User_Controls;
using DVLD_BusinessLogic;
using DVLD_BussinessLogic.Users_Classes;
using System;
using System.Windows.Forms;

namespace DVLD.Sub_Forms.Users_Forms
{
    public partial class Frm_AddNewUser : Form
    {
        clsUsers_BL clsUser;
        clsPeople_BL clsPeople;
        bool IsPersonLinked = true;
        private void FillUserInfoControl()
        {
            if (clsUser.UserID != -1)
            {
                Label_Variable_UserID.Text = clsUser.UserID.ToString();
                TB_Username.Text = clsUser.Username;
                TB_Password.Text = clsUser.Password;
                TB_ConfirmPassword.Text = clsUser.Password;
            }

        }

        private void Initialization_UserData(int UserID = -1)
        {
            if (UserID != -1)
            {
                clsUser = new clsUsers_BL(UserID);
                TB_Username.Text = clsUser.Username;
                TB_ConfirmPassword.Text = TB_ConfirmPassword.Text;
                TB_Password.Text = clsUser.Password;
                CheckBox_Active.Checked = clsUser.IsActive;
                Label_FormTitle.Text = "Update User";
                UC_Filter.Enabled = false;
                Initialization_PersonData(clsUser.PersonID);
                FillUserInfoControl();
            }
            else
            {
                clsUser = new clsUsers_BL();
                clsPeople = new clsPeople_BL();
                EnabledUserTextBox(false);
            }
        }
        private void Initialization_PersonData(int PersonID = -1)
        {
            if (PersonID != -1)
            {

                Utilities.Methods.Fill_UC_Controls
                (UC_ShowPersonInfo, clsPeople_BL.GetPersonByID(PersonID));
                EnableControl_Save(true);

            }


        }
        public Frm_AddNewUser(int UserID = -1)
        {
            InitializeComponent();
            Initialization_UserData(UserID);

        }






        private void Frm_AddNewUser_Load(object sender, EventArgs e)
        {
            UC_Filter.ShowPicButtonSearch();
            UC_Filter.FillComboBox("NationalNo");
        }
        private void EnableControl_Save(bool On_Off)
        {

            if (On_Off)
                Btn_Save.Enabled = true;
            else
                Btn_Save.Enabled = false;




        }

        private void ShowErrorType()
        {



            switch (clsUser.GetError().ToString())
            {


                case "Empty":

                    MessageBox.Show("Value is empty\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    break;

                case "Exists":

                    MessageBox.Show("Username Already exists\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

                case "UserLinked":
                    MessageBox.Show("Person Linked With Another User Please Chose Another!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

                default:
                    MessageBox.Show("Unknown error\n");
                    break;
            }

        }
        private void EnabledUserTextBox(bool On_Off)
        {
            if (On_Off)
            {
                TB_Username.Enabled = true;
                TB_Password.Enabled = true;
                TB_ConfirmPassword.Enabled = true;
                CheckBox_Active.Enabled = true;
            }
            else
            {
                TB_Username.Enabled = false;
                TB_Password.Enabled = false;
                TB_ConfirmPassword.Enabled = false;
                CheckBox_Active.Enabled = false;

            }

        }
        private void UC_Filter_EvClickedSearchButton(string Value)
        {

            EnabledUserTextBox(false);
            clsPeople = new clsPeople_BL();
            clsPeople.FillPersonObject(Value);
            if (clsPeople.PersonID == -1)
            {
                MessageBox.Show("Person Not Found");
                return;
            }
            IsPersonLinked = clsUsers_BL.IsThePersonLinkedTableUsers(clsPeople.PersonID);



            Utilities.Methods.Fill_UC_Controls(UC_ShowPersonInfo, clsPeople);

         

        }
        private void Btn_Next_Click(object sender, EventArgs e)
        {

            if (_PersonID == -1) return;
            if (IsPersonLinked)
            {
                MessageBox.Show("Person Linked With Another User Please Chose Another!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {

               
                TabControl.SelectedIndex = 1;
                EnableControl_Save(true);
                EnabledUserTextBox(true);
            }



        }


        enum enColumnType { NationalNo = 1 };
        private void UC_Filter_Ev_IsInt(int Index)
        {
            switch ((enColumnType)Index)
            {
                case enColumnType.NationalNo:
                    UC_Filter.Answer_IsInt(false);
                    break;

            }
        }

        private void TB_ConfirmPassword_Validated(object sender, EventArgs e)
        {
            if (TB_Password.Text != TB_ConfirmPassword.Text)
                ErrorProvider_Fail.SetError(TB_ConfirmPassword, "Please Confirm Password");
            else
                ErrorProvider_Fail.SetError(TB_ConfirmPassword, "");





        }

        int _PersonID = -1;
        private void ChangeFormMode()
        {

            Label_Variable_UserID.Text = clsUser.UserID.ToString();
            Label_FormTitle.Text = "Update User";
            UC_Filter.Enabled = false;
        }
        private void Btn_Save_Click(object sender, EventArgs e)
        {

            clsUser.PersonID = _PersonID;
            clsUser.Password = TB_Password.Text;
            clsUser.IsActive = CheckBox_Active.Checked;
            clsUser.Username = TB_Username.Text;

            if (clsUser.Save())
            {
                Utilities.Methods.Ut_ShowMessageBox(clsUser.GetModeType());
                ChangeFormMode();
                
            }
            else
                ShowErrorType();

            

        }

        private void TB_Username_Validated(object sender, EventArgs e)
        {
            if (clsUser.IsUsernameExists(TB_Username.Text))
                ErrorProvider_Fail.SetError(TB_Username, "Username is in use please chose another one");
            else
                ErrorProvider_Fail.SetError(TB_Username, "");

        }

        private void UC_ShowPersonInfo_SendPersonID(int PersonID)
        {

            _PersonID = PersonID;

        }


        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Fill_UC_PersonInformation(clsPeople_BL clsPersonInfo)
        {


            if (Utilities.Methods.Fill_UC_Controls(UC_ShowPersonInfo, clsPersonInfo))
            {
                MessageBox.Show("Person Add", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Btn_Save.Enabled = true;
                IsPersonLinked = false;
            }


        }

        private void Pic_AddEditPerson_Click(object sender, EventArgs e)
        {
            Frm_Add_Edit_People frm_Add_ = new Frm_Add_Edit_People();

            frm_Add_.Retrieve_1 = Fill_UC_PersonInformation;
            frm_Add_.ShowDialog();


        }


        private void UC_ShowPersonInfo_SendRequestToGetImage(bool Request, string ImageKey)
        {
            if (Request != false)
                UC_ShowPersonInfo.SetImage(clsPeople_BL.FindImagePath(ImageKey));


        }

      



    }






}
