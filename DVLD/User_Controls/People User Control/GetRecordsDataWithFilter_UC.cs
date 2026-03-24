using DVLD.Sub_Forms;
using DVLD_BusinessLogic;
using DVLD_BussinessLogic.Users_Classes;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DVLD.User_Controls
{
    public partial class UserControl_GetPersonDataWithFilter : UserControl
    {

        #region DataMember
        enum eMode { None, People, Users };
        eMode mode;
        Timer LimitTimeToCallDataBase = new Timer();
        #endregion End
        #region Constructor
        public UserControl_GetPersonDataWithFilter()
        {
            mode = eMode.None;
            InitializeComponent();
            _InitializeTimer();
        }

        #endregion End
        #region Initialization Methods

        private void _UserControl_GetRecordsDataWithFilter_Load(object sender, EventArgs e)
        {

        }
        private void _Initialization_CMS()
        {
            if (mode == eMode.People)
                _DataGridView.ContextMenuStrip = _ContextMenuStrip_People;
            
        }

        // refresh Data Grid View 
        private void _Refresh()
        {

            if (mode == eMode.People)
                _DataGridView.DataSource = clsPeople_BL.GetAllPeople("", "");
            else
                //   _DataGridView.DataSource = clsPeople_BL.GetAllUsers("", "");


                Label_CountRows.Text = "# Record: " + _DataGridView.RowCount.ToString();

        }

        private void _InitializeEnumMode(string mode)
        {
            if (Enum.TryParse(mode, out eMode result))
            {
                this.mode = result;
            }

        }

        // commit in method (:
        private void _InitializeTimer()
        {
            /*Limit timer in MS to get Data from DataBase if time less than 250,
             * the program will be denied to call function  GetAllRecords */
            LimitTimeToCallDataBase.Interval = 250;
            LimitTimeToCallDataBase.Enabled = false;
            LimitTimeToCallDataBase.Tick += According_To_TheFilter;

        }




        // Show All Records on Display with info for each Records, and this method work when form will opening
        private void ChangeLabelCount()
        {
            Label_CountRows.Text += " " + _DataGridView.RowCount.ToString();
        }
        private void GetAllRecords(string FilterType = "", object Filter = null)
        {
            switch (mode)
            {
                case eMode.People:
                    _DataGridView.DataSource = clsPeople_BL.GetAllPeople(FilterType, Filter);
                    FillComboBox();
                    ChangeLabelCount();
                    break;
                case eMode.Users:
                    _DataGridView.DataSource = clsUsers_BL.GetAllUsers(FilterType, Filter);
                    FillComboBox();
                    ChangeLabelCount();
                    break;
            }

        }


        public void LoadSetting(string mode)
        {
            _InitializeEnumMode(mode);
            _Initialization_CMS();
            GetAllRecords();


        }


        #endregion End


        // Fill ComboBox With UC_Filter types
        private void FillComboBox()
        {
            ComboBOX.Items.Clear();
            ComboBOX.Items.Add("None");

            foreach (DataGridViewColumn column in _DataGridView.Columns)
                ComboBOX.Items.Add(column.Name);



            if (ComboBOX.Items.Count != 0)
            {
                ComboBOX.SelectedIndex = 0;
                TB_Search.Visible = false;
            }


        }

        // refresh Data Grid view and show data according to the filter

        public bool CheckFromSelectionComboBox()
        {
            LimitTimeToCallDataBase.Stop();
            if (ComboBOX.SelectedIndex != 0)
                return true;

            return false;

        }


        public void According_To_TheFilter(object sender, EventArgs e)
        {
            if (!CheckFromSelectionComboBox())
                return;

            switch (mode)
            {
                case eMode.People:

                    _DataGridView.DataSource = clsPeople_BL.GetAllPeople(ComboBOX.SelectedItem.ToString(), TB_Search.Text);
                    break;

                case eMode.Users:
                    _DataGridView.DataSource = clsUsers_BL.GetAllUsers(ComboBOX.SelectedItem.ToString(), TB_Search.Text);
                    break;


            }

        }




        /*!!!!!!!!!!!!!!!!!!!!!!!!We Need Add more validation for User search don't forget!!!!!!!!!!!!!!!!!!!!!!*/
        // this method check if the selection in comboBox the number type
        private bool IsSelectionTheNumberType()
        {
            // if Selection index == 1, then return true because selected on PersonID , so can't write Characters 
            return ComboBOX.SelectedIndex == 1;

        }

        // Limit Time that can pass role and call database 
        private void TB_Search_TextChanged(object sender, EventArgs e)
        {


            LimitTimeToCallDataBase.Stop();
            LimitTimeToCallDataBase.Start();

        }


        /*!!!!!!!!!!!!!!!!!!!!!!!!We Need Add more validation for User search don't forget!!!!!!!!!!!!!!!!!!!!!!*/
        // Show Text Box If ComboBox != None
        private bool ShutDownIfSelectionNone()
        {
            if (ComboBOX.SelectedIndex == 0)
            {
                TB_Search.Visible = false;
                ComboBox_IsActive.Visible = false;
                return true;
            }
            else
                TB_Search.Visible = true;

            return false;
        }
        private void ComboBOX_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ShutDownIfSelectionNone()) return;

            switch (mode)
            {

                case eMode.Users:
                    if (ComboBOX.Text == "IsActive")
                    {
                        TB_Search.Visible = false;
                        ComboBox_IsActive.Visible = true;
                    }
                    else
                    {
                        TB_Search.Visible = true;
                        ComboBox_IsActive.Visible = false;
                    }


                    break;



            }




        }
        private void ComboBox_IsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBox_IsActive.SelectedIndex == 0) 
            {

                _DataGridView.DataSource =
                    clsUsers_BL.GetAllUsers("", "");
                return;
            }


           
            _DataGridView.DataSource = 
                clsUsers_BL.GetAllUsers(ComboBOX.SelectedItem.ToString(), ComboBox_IsActive.SelectedIndex);


        }
        // UC_Filter Text Box
        private void TB_Search_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (IsSelectionTheNumberType())
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);




        }

        // when Mouse In the picture  add_new_person the background color return to  color Gainsboro
        private void PicButton_AddNewPerson_MouseEnter(object sender, EventArgs e)
        {
            PicButton_AddNewPerson.BackColor = Color.Gainsboro;
        }

        // When Mouse Leaving the Picture add_new_person the background color return to normal Transparent
        private void PicButton_AddNewPerson_MouseLeave(object sender, EventArgs e)
        {
            PicButton_AddNewPerson.BackColor = Color.Transparent;
        }



        /*!!!!!!!!!!!!!!!!!!!!!!!!We Need Add more validation for User search don't forget!!!!!!!!!!!!!!!!!!!!!!*/
        // Method Add New Person to system
        private void Load_Frm_AddNewPerson()
        {
            Frm_AddEditPerson_ frm_AddEditPerson_ = new Frm_AddEditPerson_();

            frm_AddEditPerson_.ShowDialog();

            _Refresh();
        }

        private void Load_Frm_AddNewUser()
        {
            MessageBox.Show("Add new user form will be here soon");

        }

        // Add New Person to system - Control Two (Picture Button )
        private void PicButton_AddNewPerson_Click(object sender, EventArgs e)
        {
            if (mode == eMode.People)
                Load_Frm_AddNewPerson();
            else
                Load_Frm_AddNewUser();
        }


        #region  Tool Strip Menu Item People

        // Show Person Details

        private void showDetailsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Frm_Person_Details frm_Person_Details = new Frm_Person_Details(Convert.ToInt32(_DataGridView.CurrentRow.Cells[0].Value));
            frm_Person_Details.ShowDialog();
        }


        // Add New Person to system - Control one (Context Menu Strip)
        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Load_Frm_AddNewPerson();
        }



        // Edit Person
        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ID = (int)_DataGridView.CurrentRow.Cells[0].Value;
            Frm_AddEditPerson_ frm_AddEditPerson_ = new Frm_AddEditPerson_(ID);

            frm_AddEditPerson_.ShowDialog();

            _Refresh();
        }


        // Delete Person
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ID = (int)_DataGridView.CurrentRow.Cells[0].Value;


            if (clsPeople_BL.DeletePerson(ID))
            {
                MessageBox.Show("Person Was Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _Refresh();
            }
            else
                MessageBox.Show("Person Was Not Deleted Because it has data linked to it", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);



        }


        #endregion End


        
    }
}
