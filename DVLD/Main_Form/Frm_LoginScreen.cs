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
    public partial class Frm_LoginScreen : Form
    {

        bool dragging = false;
        Point dragCursorPoint;
        Point dragFormPoint;


        private void Check_CheckBox() 
        {
            CheckBox_RememberMe.Checked = true;
        }
        private void LoadRememberedUser()
        {
            string Username = TB_UserName.Text;
            clsUsers_BL.GetRememberMeUser(ref Username);
            TB_UserName.Text = Username;

            if (!CheckIfTextValid(Username))
                Check_CheckBox();

        }
        public Frm_LoginScreen()
        {
            InitializeComponent();

            // Use Double Buffering: render the UI in memory first,
            // then display it in one step to prevent flickering.
            this.DoubleBuffered = true;
            
            // Add to Text box if User Checked to computer remember him
            LoadRememberedUser();
        }

        private void Frm_LoginScreen_Load(object sender, EventArgs e)
        {
        }
        private void Frm_LoginScreen_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void Frm_LoginScreen_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void Frm_LoginScreen_MouseCaptureChanged(object sender, EventArgs e)
        {

        
            dragging = false; 
        }

        private void Pic_CloseForm_Click(object sender, EventArgs e)
        {
            this.Close();

        }


        #region Validation

        private bool CheckIfTextValid(string Text) 
        {

            return string.IsNullOrEmpty(Text);
        }

        private void TB_UserName_Validated(object sender, EventArgs e)
        {      if (!CheckIfTextValid(TB_UserName.Text))
                ErrorProvider_Input.SetError(TB_UserName, null);
          
        }

        private void TB_UserName_Validating(object sender, CancelEventArgs e)
        {

            if (CheckIfTextValid(TB_Password.Text))
                ErrorProvider_Input.SetError(TB_UserName, "Please Enter Username");
        }


        private void TB_Password_Validated(object sender, EventArgs e)
        {
            if (CheckIfTextValid(TB_Password.Text))
                ErrorProvider_Input.SetError(TB_Password, "Please Enter Password");
            //else if (TB_UserName.Text.Length < 8)
            //    ErrorProvider_Input.SetError(TB_Password, "Enter Password with character greater than 8");


        }


        private void TB_Password_Validating(object sender, CancelEventArgs e)
        {
            if (!CheckIfTextValid(TB_Password.Text))
                ErrorProvider_Input.SetError(TB_Password, "");

        }




        private void Btn_Login_MouseEnter(object sender, EventArgs e)
        {
            Btn_Login.BackColor = Color.RoyalBlue;
        }


        private void Btn_Login_MouseLeave(object sender, EventArgs e)
        {
            Btn_Login.BackColor = Color.Transparent;

        }


        #endregion End

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            if (CheckIfTextValid(TB_UserName.Text) || CheckIfTextValid(TB_Password.Text))
                return;

            string State = null;
            if ((State = clsUsers_BL.GetUserByUserName(TB_UserName.Text, TB_Password.Text)) == "Success")
            {

                if (CheckBox_RememberMe.Checked)
                    clsUsers_BL.RememberUser();
                else
                    clsUsers_BL.Delete_Remembered_User();


                this.Close();

            
            }
            else if (State == "Not Active")
                MessageBox.Show("Account Inactive please talk with admin", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Username or password are wrong please try again", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);

            

        }




    }
}
