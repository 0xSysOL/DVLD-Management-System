using DVLD.Sub_Forms.Application.ManageAppTypes;
using DVLD_BussinessLogic.Application_Classes;
using System;
using System.Windows.Forms;

namespace DVLD.Sub_Forms.Application
{
    public partial class Frm_Manage_Application_Types_ : Form
    {
        clsManageApplicationTypes_BL applicationTypes_BL;
        public Frm_Manage_Application_Types_()
        {
            InitializeComponent();
            applicationTypes_BL = new clsManageApplicationTypes_BL();

        }

        private void LoadData()
        {
            _DataGridView.DataSource = applicationTypes_BL.GetManageApplicationType();
            Label_Variable_Record.Text = _DataGridView.RowCount.ToString();
        }
        private void Frm_Manage_Application_Types__Load(object sender, EventArgs e)
        {        
            LoadData();

        }

        private void _DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(_DataGridView.CurrentCell.Value);

            Frm_EditAppTypes MPT = new Frm_EditAppTypes(ID);

            MPT.ShowDialog();

            LoadData();
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
