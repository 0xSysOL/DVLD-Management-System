using DVLD.Sub_Forms.Users_Forms;
using DVLD.User_Controls;
using DVLD_BusinessLogic;
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

namespace DVLD.Sub_Forms
{
    public partial class Frm_ManageUsers : Form
    {

        public Frm_ManageUsers()
        {
            InitializeComponent();
        }
        private void _RefreshTable()
        {
            Fill_DataGridView();
        }
        private void Fill_DataGridView(string FilterType = "", object Filter = null) 
        {
            _DataGridView.DataSource = clsUsers_BL.GetAllUsers(FilterType, Filter);
            Label_Variable_Records.Text = _DataGridView.RowCount.ToString();

        }



        private void Frm_ManageUsers_Load(object sender, EventArgs e)
        {
            Fill_DataGridView();
            Fill_ComboBOX();
            

        }
        
        private void Fill_ComboBOX() 
        {
            UC_Filter.FillComboBox(_DataGridView);

        }
     
        private void Filter_EvFilter(string FilterType, object Value )
        {
            Fill_DataGridView(FilterType,Value);
        }

    
        private void _DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        #region Tool Strip Menue Item

        // Task
        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int ID = Convert.ToInt32(_DataGridView.CurrentRow.Cells[0].Value);
            Frm_UserInformation frm_User = new Frm_UserInformation(ID);


            frm_User.ShowDialog();

        }

        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PicButton_AddNewPerson_Click(sender, e);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int UserID = Convert.ToInt32(_DataGridView.CurrentRow.Cells[0].Value);
            

            Utilities.Methods.Show_AddEdit_NewUser(UserID); 
            _RefreshTable();

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You sure want to delete this user?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;

            int UserID = Convert.ToInt32(_DataGridView.CurrentRow.Cells[0].Value);
            if (clsUsers_BL.DeleteUser(UserID))
                MessageBox.Show("User Deleted Successfully","Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Can't Delete This User Because Has Reference", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            _RefreshTable();
        }

        // Task
        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(_DataGridView.CurrentRow.Cells[0].Value);
            Frm_ChangePassword frm_ChangePassword = new Frm_ChangePassword(ID);
            
            frm_ChangePassword.ShowDialog();


        }
        

        // soon
        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        // soon
        private void phoneCallToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }




        #endregion End


        enum enColumnType {UserID=1,PersonID=2,Username=3,IsActive=4 }
        private void UC_Filter_EvGetAnswer(int Column )
        {
            UC_Filter.HideComboBox_YesNo();

            switch ((enColumnType)Column - 1)
            {

                case enColumnType.UserID:
                case enColumnType.PersonID:
                    UC_Filter.Answer_IsInt(true);
                    break;
                case enColumnType.Username:
                    UC_Filter.Answer_IsInt(false);
                    break;
                case enColumnType.IsActive:
                    UC_Filter.Answer_IsInt(false);
                    UC_Filter.ShowComboBox_YesNo();
                    break;
                    

            }


        }
      



        private void PicButton_AddNewPerson_Click(object sender, EventArgs e)
        {


            Utilities.Methods.Show_AddEdit_NewUser(-1);
            _RefreshTable();

        }

        private void UC_Filter_Load(object sender, EventArgs e)
        {

        }
    }
}
