using DVLD.Sub_Forms.Drivers;
using DVLD.Sub_Forms.License;
using DVLD_BusinessLogic;
using DVLD_BussinessLogic.Drivers;
using DVLD_BussinessLogic.License_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Sub_Forms.Application.Manage_Applications
{
    public partial class Frm_ManageInternationalApp : Form
    {
        public Frm_ManageInternationalApp()
        {
            InitializeComponent();
        }

        private void _DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RefreshDGV(int DriverID = -1)
        {

            _DataGridView.DataSource = clsLicense_BL.GetAllPersonInternationalLicense(DriverID);
            Label_Variable_Records.Text = _DataGridView.RowCount.ToString();

        }
        private void Frm_ManageInternationalApp_Load(object sender, EventArgs e)
        {
            RefreshDGV();


        }
       private bool IsDataGridVEmpty()
        {

            return _DataGridView.Rows.Count == 0;

        }
        private void ShowPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IsDataGridVEmpty())
                return;


            int DriverID = (int)_DataGridView.CurrentRow.Cells["DriverID"].Value;

            Frm_Person_Details frm_Person_ = new Frm_Person_Details(clsDriver_BL.GetPersonIDByDriverID(DriverID));

            frm_Person_.ShowDialog();

        }

        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IsDataGridVEmpty())
                return;
            int ApplicationID = (int)_DataGridView.CurrentRow.Cells["ApplicationID"].Value;

            Frm_InternationalDrivingLicenseInfo frm_InternationalDriving = new Frm_InternationalDrivingLicenseInfo(ApplicationID);


            frm_InternationalDriving.ShowDialog();



        }

        private void Pic_NewLocalDrivingLicense_Click(object sender, EventArgs e)
        {
          
            Frm_NewInternationalLicenseApplication NILAPP = new Frm_NewInternationalLicenseApplication();

            NILAPP.ShowDialog();
            RefreshDGV();

        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IsDataGridVEmpty())
                return;
            int ApplicationID = (int)_DataGridView.CurrentRow.Cells["ApplicationID"].Value;

            Frm_ShowPersonLicenseHistory SPLH = new Frm_ShowPersonLicenseHistory(ApplicationID);

            SPLH.ShowDialog();
        }

        private void UC_Filter_Load(object sender, EventArgs e)
        {
            UC_Filter.FillComboBox("DriverID");
            UC_Filter.ShowPicButtonSearch();
        }

        private void UC_Filter_EvClickedSearchButton(string Text)
        {
            if (!string.IsNullOrEmpty(Text))
                RefreshDGV(Convert.ToInt32(Text));
            else
                RefreshDGV();
        }

        private void UC_Filter_Ev_IsInt(int Index)
        {

            UC_Filter.Answer_IsInt(true);


        }

       
    }
}
