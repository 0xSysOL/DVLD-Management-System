using DVLD_BussinessLogic.Application_Classes;
using System;
using System.Windows.Forms;

namespace DVLD.Sub_Forms.Application.ManageTestTypes
{
    public partial class Frm_ManageTestTypes : Form
    {
        clsManageTestTypes_BL clsManageTest;
        public Frm_ManageTestTypes()
        {
            InitializeComponent();
        }
        private void RefreshData()
        {
            clsManageTest = new clsManageTestTypes_BL();
            _DataGridView.DataSource = clsManageTest.GetManageApplicationType();
            Label_Variable_Record.Text = _DataGridView.RowCount.ToString();
            clsManageTest = null;

        }
        private void Frm_ManageTestTypes_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(_DataGridView.CurrentCell.Value);
            Frm_EditTestTypes frm_EditTest = new Frm_EditTestTypes(ID);

            frm_EditTest.ShowDialog();

            RefreshData();
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
