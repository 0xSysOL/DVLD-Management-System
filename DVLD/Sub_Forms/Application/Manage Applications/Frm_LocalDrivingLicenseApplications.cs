using DVLD.Sub_Forms.Application.Drving_Licenses_Services.New_Driving_License;
using DVLD.Sub_Forms.Application.Schedule_Tests;
using DVLD.Sub_Forms.Drivers;
using DVLD.Sub_Forms.License;



//using DVLD.Sub_Forms.Application.Sechdule_Tests.Vision_Test_Appointment;
using DVLD_BussinessLogic.Application_Classes;
using DVLD_BussinessLogic.Application_Classes.Application;
using System;
using System.Windows.Forms;
using static DVLD_BussinessLogic.Application_Classes.Application.clsApplication_BL;

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
            // FIXED: Add Application Details 

            Frm_ApplicationDetails APPD = new Frm_ApplicationDetails(GetLDLAPP_ID_FromDataGridV());

            APPD.ShowDialog();


        }
        private int GetLDLAPP_ID_FromDataGridV()
        {

            int LDL_AppID = Convert.ToInt32(_DataGridView.CurrentRow.Cells[0].Value);
            return LDL_AppID;
        }
        private int GetApplicationID_FromDataGridV()
        {
            int LDL_AppID = Convert.ToInt32(_DataGridView.CurrentRow.Cells[0].Value);
            int ApplicationID = clsApplication_BL.GetApplicationID_ByLDLAPPID(LDL_AppID);
            return ApplicationID;
        }
        private void editApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int LDL_AppID = Convert.ToInt32(_DataGridView.CurrentRow.Cells[0].Value);

            eModeState status = clsApplication_BL.GetStatusBy_LDLAPP_ID(LDL_AppID);

            if (status != eModeState.Cancel)
            {

                int ApplicationID = clsApplication_BL.GetApplicationID_ByLDLAPPID(LDL_AppID);

                Frm_NewLocalLicense newLocalLicense = new Frm_NewLocalLicense(ApplicationID);

                newLocalLicense.ShowDialog();

                RefreshDataGridView();
            }else
                MessageBox.Show("Error Can't do this process", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
        private int GetApplicationID()
        {

            return GetApplicationID_ByLDLAPPID(GetLDLAPP_ID_FromDataGridV());

        }
        private void issueDateToolStripMenuItem_Click(object sender, EventArgs e)
        {


            Frm_IssueDriverLicenseForFirstTime IDLFFT
                = new Frm_IssueDriverLicenseForFirstTime(GetApplicationID_FromDataGridV());

            IDLFFT.ShowDialog();

            RefreshDataGridView();

        }

        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_DrivingLicenseInfo DLI = new Frm_DrivingLicenseInfo(GetApplicationID());

            DLI.ShowDialog();

        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ShowPersonLicenseHistory SPLH = new Frm_ShowPersonLicenseHistory(GetApplicationID());


            SPLH.ShowDialog();


        }


        #region Sechdule Tests


        private void sechduleVisionTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LDL_AppID = Convert.ToInt32(_DataGridView.CurrentRow.Cells[0].Value);
            Frm_Schedule_TestsAppointments STAPP = new Frm_Schedule_TestsAppointments
                (LDL_AppID, (int)Utilities.Methods.eTestTypes.VisionTest);

            STAPP.ShowDialog();
            RefreshDataGridView();
            CheckFromRecord();
        }
        private void sechduleWrittenTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LDL_AppID = Convert.ToInt32(_DataGridView.CurrentRow.Cells[0].Value);
            Frm_Schedule_TestsAppointments STAPP = new Frm_Schedule_TestsAppointments
                (LDL_AppID, (int)Utilities.Methods.eTestTypes.WrittenTest);

            STAPP.ShowDialog();
            RefreshDataGridView();

            CheckFromRecord();
        }

        private void sechduleStreetTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LDL_AppID = Convert.ToInt32(_DataGridView.CurrentRow.Cells[0].Value);
            Frm_Schedule_TestsAppointments STAPP = new Frm_Schedule_TestsAppointments
                (LDL_AppID, (int)Utilities.Methods.eTestTypes.StreetTest);

            STAPP.ShowDialog();
            RefreshDataGridView();

            CheckFromRecord();
        }
        #endregion End



        #endregion End 

        private void EnabledTestsMenuItem(bool VisionT, bool WrittenT, bool StreetT)
        {

            sechduleVisionTestToolStripMenuItem.Enabled = VisionT;
            sechduleWrittenTestToolStripMenuItem.Enabled = WrittenT;
            sechduleStreetTestToolStripMenuItem.Enabled = StreetT;
        }
        private void EnabledFinalItemAfterCompleted_3_Schedules(bool IssDSMI, bool SLTMI, bool SAPP)
        {
            issueDLFT_ToolStripMenuItem.Enabled = IssDSMI;
            showLicenseToolStripMenuItem.Enabled = SLTMI;
            showApplicationDetailsToolStripMenuItem.Enabled = SAPP;
        }
        private void EnabledMenuItems(bool Edit, bool Delete, bool Sechdule, bool Cancel)
        {
            editApplicationToolStripMenuItem.Enabled = Edit;
            deleteApplicationToolStripMenuItem.Enabled = Delete;
            sechduleToolStripMenuItem.Enabled = Sechdule;
            cancelApplicationToolStripMenuItem.Enabled = Cancel;
        }


        private void _DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void _DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void CheckFromRecord()
        {

            if (_DataGridView == null || _DataGridView.Rows.Count == 0)
            {
                EnabledTestsMenuItem(false, false, false);
                EnabledFinalItemAfterCompleted_3_Schedules(false, false, false);
                EnabledMenuItems(false, false, false, false);
            }
            else
            {
                EnabledTestsMenuItem(true, true, true);
                EnabledFinalItemAfterCompleted_3_Schedules(true, true, true);
                EnabledMenuItems(true, true, true, true);

            }


            int LDLA_ID = Convert.ToInt32(_DataGridView.CurrentRow.Cells[0].Value);
            eModeState status = clsApplication_BL.GetStatusBy_LDLAPP_ID(LDLA_ID);
            if (status == eModeState.Cancel)
            {
                EnabledTestsMenuItem(false, false, false);
                EnabledFinalItemAfterCompleted_3_Schedules(false, false, false);
                EnabledMenuItems(false, false, false, false);
            }
            if (status == eModeState.Completed)
            {

                EnabledTestsMenuItem(false, false, false);
                EnabledFinalItemAfterCompleted_3_Schedules(false, true, true);
                EnabledMenuItems(false, false, false, false);
                return;

            }


            if (!clsTestAppointment_BL.IsVisionTestPassed(LDLA_ID))
            {
                EnabledTestsMenuItem(true, false, false);
                EnabledFinalItemAfterCompleted_3_Schedules(false, false, false);
                EnabledMenuItems(true, true, true, true);
                return;
            }
            else
            {
                EnabledTestsMenuItem(false, true, false);
                EnabledFinalItemAfterCompleted_3_Schedules(false, false, false);

            }

            if (!clsTestAppointment_BL.IsWrittenTestPassed(LDLA_ID))
            {
                EnabledTestsMenuItem(false, true, false);
                EnabledFinalItemAfterCompleted_3_Schedules(false, false, false);
                return;
            }
            else
            {
                EnabledTestsMenuItem(false, false, true);
                EnabledFinalItemAfterCompleted_3_Schedules(false, false, false);
            }

            if (!clsTestAppointment_BL.IsStreetTestPassed(LDLA_ID))
            {
                EnabledTestsMenuItem(false, false, true);
                EnabledFinalItemAfterCompleted_3_Schedules(false, false, false);

                return;
            }
            else if (status == eModeState.Completed)
            {
                EnabledTestsMenuItem(false, false, false);
                EnabledFinalItemAfterCompleted_3_Schedules(false, true, true);
                EnabledMenuItems(false, false, false, false);
            }
            else
            {
                EnabledTestsMenuItem(false, false, false);
                EnabledFinalItemAfterCompleted_3_Schedules(true, true, true);
                EnabledMenuItems(false, false, false, false);
            }



        }

        private void _DataGridView_SelectionChanged(object sender, EventArgs e)
        {



        }

        private void UC_Filter_Load(object sender, EventArgs e)
        {

        }

        private void _ContextMenuStrip_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            CheckFromRecord();

        }


    }
}
