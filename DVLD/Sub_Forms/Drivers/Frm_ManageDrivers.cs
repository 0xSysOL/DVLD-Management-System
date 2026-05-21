using DVLD_BussinessLogic.Drivers;
using System;
using System.Windows.Forms;

namespace DVLD.Sub_Forms.Drivers
{
    public partial class Frm_ManageDrivers : Form
    {
        public Frm_ManageDrivers()
        {
            InitializeComponent();
        }
        private void Refresh_DGV(string Value = null, string ColumnName = null)
        {
            if (ColumnName!= "None" && !string.IsNullOrEmpty(Value)&&ColumnName.ToString() !=null  )
            _DataGridView.DataSource = clsDriver_BL.GetAllDrivers(Value, ColumnName);
            else
                _DataGridView.DataSource = clsDriver_BL.GetAllDrivers();

            Label_Variable_Records.Text = _DataGridView.RowCount.ToString();

        }
        private void Frm_ManageDrivers_Load(object sender, EventArgs e)
        {
            Refresh_DGV();
        }

        private void _DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UC_Filter_Load(object sender, EventArgs e)
        {
            UC_Filter.FillComboBox("DriverID");
            UC_Filter.FillComboBox("PersonID");
            UC_Filter.FillComboBox("NationalNo");
            UC_Filter.FillComboBox("FullName");

        }

        private void UC_Filter_EvFilter(string FilterType, object Value)
        {
            Refresh_DGV((Value != null)? Value.ToString():null, FilterType);
        }


    }
}
