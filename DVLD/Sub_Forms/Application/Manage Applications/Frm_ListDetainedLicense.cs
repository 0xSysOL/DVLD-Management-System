using DVLD.Sub_Forms.Application.Detained_License;
using DVLD.Sub_Forms.Drivers;
using DVLD.Sub_Forms.License;
using DVLD_BussinessLogic.Detained;
using DVLD_BussinessLogic.License_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Sub_Forms.Application.Manage_Applications
{
    public partial class Frm_ListDetainedLicense : Form
    {
        public Frm_ListDetainedLicense()
        {
            InitializeComponent();
        }

        private void SaveColumnNamesInList()
        {
            /*DetainID, DetainDate
             IsReleased,FineFees
            ReleaseDate,NationalNo,[Full Name],ReleaseApplicationID*/
            UC_Filter.FillComboBox("Detain ID");
            UC_Filter.FillComboBox("Is Released");
            UC_Filter.FillComboBox("National No");
            UC_Filter.FillComboBox("Full Name");
            UC_Filter.FillComboBox("Release Application ID");

        }
        private void RefreshDataGrid(object Value = null,string ColumnName = null)
        {

            _DataGridView.DataSource = clsDetained_BL.GetDetainedList(Value,ColumnName);
            Label_Variable_Records.Text = _DataGridView.Rows.Count.ToString();
           

        }
        private void _DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void UC_Filter_Load(object sender, EventArgs e)
        {
            UC_Filter.FillComboBox(_DataGridView);
            SaveColumnNamesInList();
        }

        private void Frm_ListDetainedLicense_Load(object sender, EventArgs e)
        {
            RefreshDataGrid();
        }

        private void Pic_NewLocalDrivingLicense_Click(object sender, EventArgs e)
        {
            Frm_DetainLicense _DetainLicense = new Frm_DetainLicense();


            _DetainLicense.ShowDialog();
            RefreshDataGrid();

        }
        private void OpenReleaseScreen()
        {

   Frm_ReleaseDetainLicense frm_ReleaseDetain = new Frm_ReleaseDetainLicense();

            frm_ReleaseDetain.ShowDialog();
            RefreshDataGrid();
        }
        private void Pic_Release_Click(object sender, EventArgs e)
        {
            OpenReleaseScreen();
        }
        private void SearchForResult(string ColumnName, object Value)
        {

            /*
     UC_Filter.FillComboBox("Detain ID");
     UC_Filter.FillComboBox("Is Released");
     UC_Filter.FillComboBox("National No");
     UC_Filter.FillComboBox("Full Name");
     UC_Filter.FillComboBox("Release Application ID");
*/
            if (string.IsNullOrEmpty(ColumnName))
                return;

            if (string.IsNullOrEmpty(Value.ToString()))
            {
                RefreshDataGrid();
                return;
            }
            int i = 0;
            while (true)
            {

                if (ColumnName[i] == ' ')
                    ColumnName= ColumnName.Remove(i,1);


                if (i == ColumnName.Length - 1)
                    break;

                i++;

            }



            RefreshDataGrid(Value, ColumnName);

        }
        private void UC_Filter_Ev_IsInt(int Index)
        {
            /*
            UC_Filter.FillComboBox("Detain ID");
            UC_Filter.FillComboBox("Is Released");
            UC_Filter.FillComboBox("National No");
            UC_Filter.FillComboBox("Full Name");
            UC_Filter.FillComboBox("Release Application ID");
*/
            switch (Index)
            {
                case 1:
                case 5:
                    UC_Filter.Answer_IsInt(true);
                    UC_Filter.HideComboBox_YesNo();
                    UC_Filter.ShowTextBox();
                    break;

                case 2:
                    UC_Filter.ShowComboBox_YesNo();
                 
                    break;
                default:
                                        UC_Filter.Answer_IsInt(false);
                    UC_Filter.HideComboBox_YesNo();
                    UC_Filter.ShowTextBox();
                    break;


            }



        }

        private void UC_Filter_EvFilter(string ColumnName, object Value)
        {

            SearchForResult(ColumnName, Value);

        }

        private void showApplicationDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ApplicationID = (int)_DataGridView.CurrentRow.Cells[_DataGridView.ColumnCount -1].Value;
            Frm_ApplicationDetails APPD = new Frm_ApplicationDetails(ApplicationID, true);

            APPD.ShowDialog();
        }
        private int GetLicenseID()
        {

            return(int)_DataGridView.CurrentRow.Cells["L.ID"].Value;

        }
        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_DrivingLicenseInfo DLI = new Frm_DrivingLicenseInfo(GetLicenseID(), "LicenseID");

            DLI.ShowDialog();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Frm_ShowPersonLicenseHistory SPLH = new Frm_ShowPersonLicenseHistory(clsLicense_BL.GetPersonIDByLicenseID(GetLicenseID()), "By Person");


            SPLH.ShowDialog();
        }

        private void releaseDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ReleaseDetainLicense frm_ReleaseDetain = new Frm_ReleaseDetainLicense(GetLicenseID());

            frm_ReleaseDetain.ShowDialog();
            RefreshDataGrid();
        }

        private void _ContextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            if (!clsDetained_BL.IsLicenseDetain(GetLicenseID()))
                releaseDetainedLicenseToolStripMenuItem.Enabled = false;
            else
                releaseDetainedLicenseToolStripMenuItem.Enabled = true;



        }
    }
}
