using DVLD.Sub_Forms;
using DVLD.Sub_Forms.Application;
using DVLD.Sub_Forms.Application.ManageTestTypes;
using DVLD.Sub_Forms.Users_Forms;
using DVLD_BussinessLogic.Users_Classes;
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

namespace DVLD
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }
        // Load People Form
        private void MS__People_Click(object sender, EventArgs e)
        {

            Frm_People people_Form = new Frm_People();

            people_Form.ShowDialog();


        }


        // Load User Form
        private void MS__Users_Click(object sender, EventArgs e)
        {
            Frm_ManageUsers Users_Form = new Frm_ManageUsers();

            Users_Form.ShowDialog();
        }

        private void changeUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(CurrentUser.GetUserID());
            Frm_ChangePassword frm_ChangePassword = new Frm_ChangePassword(ID);

            frm_ChangePassword.ShowDialog();

        }

        private void signOut_SM_Click(object sender, EventArgs e)
        {
           
            this.Close();
            Application.Restart();

        }

        private void currentUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_UserInformation frm_User = new Frm_UserInformation(CurrentUser.GetUserID());


            frm_User.ShowDialog();

        }

        
        private void Main_Form_Load(object sender, EventArgs e)
        {

        }

        private void manageApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Manage_Application_Types_ Show_MAT = new Frm_Manage_Application_Types_();

            Show_MAT.Show();
        }

        private void DrivingLS_ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void manageApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void detainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ManageTestTypes manageTestTypes = new Frm_ManageTestTypes();

            manageTestTypes.ShowDialog();

        }
    }
}
