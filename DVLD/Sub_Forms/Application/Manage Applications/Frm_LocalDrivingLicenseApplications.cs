using DVLD.Sub_Forms.Application.Drving_Licenses_Services.New_Driving_License;
using DVLD.Sub_Forms.Application.Schedule_Tests;

//using DVLD.Sub_Forms.Application.Sechdule_Tests.Vision_Test_Appointment;
using DVLD_BussinessLogic.Application_Classes;
using DVLD_BussinessLogic.Application_Classes.Application;
using System;
using System.Windows.Forms;

namespace DVLD.Sub_Forms.Application.Manage_Applications
{
    public partial class Frm_LocalDrivingLicenseApplications : Form
    {
        public Frm_LocalDrivingLicenseApplications()
        {
            InitializeComponent();
        }

        enum eIndexComboBox { LDLAppID = 1, NationalNo = 2, FullName = 3, Status = 4 }

        private void InitializeComboBox()
        {


            UC_Filter.FillComboBox(_DataGridView.Columns[0].Name);
            UC_Filter.FillComboBox(_DataGridView.Columns[2].Name);
            UC_Filter.FillComboBox(_DataGridView.Columns[3].Name);
            UC_Filter.FillComboBox(_DataGridView.Columns[_DataGridView.ColumnCount - 1].Name);

            UC_Filter.ShowPicButtonSearch();
        }
        private void RefreshDataGridView()
        {
            _DataGridView.DataSource = clsApplication_BL.Get_LDL_Applications();
            Label_Variable_Records.Text = _DataGridView.RowCount.ToString();

            IsLoaded = true;
            CheckFromRecord();
        }
        private void Frm_LocalDrivingLicenseApplications_Load(object sender, EventArgs e)
        {
            RefreshDataGridView();
            InitializeComboBox();
        }


        private void UC_Filter_Ev_IsInt(int Index)
        {
            switch ((eIndexComboBox)Index)
            {
                case eIndexComboBox.NationalNo:
                case eIndexComboBox.FullName:
                case eIndexComboBox.Status:
                    UC_Filter.Answer_IsInt(false);
                    break;

                case eIndexComboBox.LDLAppID:
                    UC_Filter.Answer_IsInt(true);
                    break;

            }

        }



        private void UC_Filter_EvClickedSearchButton(string Value)
        {


        }

        private void UC_Filter_EvFilter(string ColumnName, object Value)
        {

            _DataGridView.DataSource = clsApplication_BL.GetAllApplications_WithFilter(Value, ColumnName);
            Label_Variable_Records.Text = _DataGridView.RowCount.ToString();



        }

        private void Pic_ApplicationForm_Click(object sender, EventArgs e)
        {
            Frm_NewLocalLicense newLocalLicense = new Frm_NewLocalLicense();

            newLocalLicense.ShowDialog();

            RefreshDataGridView();

        }


        #region Context Menu Strip
        private void showApplicationDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deleteApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LDL_AppID = Convert.ToInt32(_DataGridView.CurrentRow.Cells[0].Value);

            if (clsApplication_BL.DeleteApplication(LDL_AppID))
            {
                MessageBox.Show("Application Deleted", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshDataGridView();
            }
            else
                MessageBox.Show("Error Something Wrong Please Try Again", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void cancelApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int LDL_AppID = Convert.ToInt32(_DataGridView.CurrentRow.Cells[0].Value);

            if (clsApplication_BL.CancelApplicationState(LDL_AppID))
            {
                MessageBox.Show("Canceled SuccessFully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshDataGridView();
            }
            else
                MessageBox.Show("Something Wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);



        }

        private void sechduleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void issueDateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        #region Sechdule Tests


        private void sechduleVisionTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LDL_AppID = Convert.ToInt32(_DataGridView.CurrentRow.Cells[0].Value);
            Frm_Schedule_TestsAppointments STAPP = new Frm_Schedule_TestsAppointments
                (LDL_AppID, (int)Utilities.Methods.eTestTypes.VisionTest);

            STAPP.ShowDialog();

        }

        #endregion End



        #endregion End 

        private void EnabledTestsMenuItem(bool VisionT, bool WrittenT, bool StreetT)
        {

            sechduleVisionTestToolStripMenuItem.Enabled = VisionT;
            sechduleWrittenTestToolStripMenuItem.Enabled = WrittenT;
            sechduleStreetTestToolStripMenuItem.Enabled = StreetT;
        }
        private void EnabledFinalItemAfterCompleted_3_Schedules(bool IssDSMI, bool SLTMI)
        {
            issueDateToolStripMenuItem.Enabled = IssDSMI;
            showLicenseToolStripMenuItem.Enabled = SLTMI;
        }
        private void EnabledMenuItems(bool Edit, bool Delete, bool Sechdule, bool Issue)
        {
            editApplicationToolStripMenuItem.Enabled = false;
            deleteApplicationToolStripMenuItem.Enabled = false;
            sechduleToolStripMenuItem.Enabled = false;
            issueDateToolStripMenuItem.Enabled = false;

        }


        private void _DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void _DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }
        bool IsLoaded = false;

        private void CheckFromRecord()
        {
            if (IsLoaded == false)
                return;

            if (_DataGridView == null || _DataGridView.Rows.Count == 0)
                return;


            int LDLA_ID = Convert.ToInt32(_DataGridView.CurrentRow.Cells[0].Value);



            if (!clsTestAppointment_BL.IsVisionTestPassed(LDLA_ID))
            {
                EnabledTestsMenuItem(true, false, false);
                EnabledFinalItemAfterCompleted_3_Schedules(false, false);
                return;
            }
            else
            {
                EnabledTestsMenuItem(false, true, false);
                EnabledFinalItemAfterCompleted_3_Schedules(false, false);

            }

            if (!clsTestAppointment_BL.IsWrittenTestPassed(LDLA_ID))
            {
                EnabledTestsMenuItem(true, true, false);
                EnabledFinalItemAfterCompleted_3_Schedules(false, false);
                return;
            }
            else
            {
                EnabledTestsMenuItem(false, false, true);
                EnabledFinalItemAfterCompleted_3_Schedules(false, false);
            }

            if (!clsTestAppointment_BL.IsStreetTestPassed(LDLA_ID))
            {
                EnabledTestsMenuItem(true, true, true);
                EnabledFinalItemAfterCompleted_3_Schedules(false, false);
                return;
            }
            else
            {
                EnabledTestsMenuItem(false, false, false);
                EnabledFinalItemAfterCompleted_3_Schedules(true, true);
                EnabledMenuItems(false, false, false, false);
            }



        }
        private void _DataGridView_SelectionChanged(object sender, EventArgs e)
        {

            CheckFromRecord();


        }

        private void UC_Filter_Load(object sender, EventArgs e)
        {

        }
    }
}
