using DVLD_BussinessLogic.Application_Classes.New_Local_License_App;
using DVLD_BussinessLogic.Drivers;
using DVLD_BussinessLogic.License_Class;
using DVLD_BussinessLogic.Workflows;
using System;
using System.Windows.Forms;

namespace DVLD.Sub_Forms.Application
{
    public partial class Frm_IssueDriverLicenseForFirstTime : Form
    {
        clsNewLocalDriverLicenseApplication_BL OB_LDLAPP;
        bool _IsPersonHasDriverLicense;

        public Frm_IssueDriverLicenseForFirstTime(int ApplicationID)
        {

            InitializeComponent();
            InitializeOB(ApplicationID);
        }
        private void InitializeOB(int ApplicationID)
        {

            OB_LDLAPP = new clsNewLocalDriverLicenseApplication_BL(ApplicationID);
            Label_Variable_LicensePrice.Text = clsLicenseClass_BL.GetLicensePrice
                (OB_LDLAPP.GetLicenseClassID()).ToString();
            IsPersonHasDriverLicense();

        }
        private void IsPersonHasDriverLicense()
        {

            if (_IsPersonHasDriverLicense = clsDriver_BL.IsPersonDriver(OB_LDLAPP.PersonID))
            {
                Label_Variable_FormTitle.Text = "Issue new Driving Category License";

            }


        }
        private void Frm_IssueDriverLicenseForFirstTime_Load(object sender, EventArgs e)
        {

        }

        private void uC_DrivingLicenseApplication_Info1_Load(object sender, EventArgs e)
        {

            Utilities.Methods.UC_FillDrivingLicenseApplicationInfo(OB_LDLAPP.GetLDLA(),
                UC_DrivingLicenseApplication_Info);

        }

        private void UC_ApplicationBasic_Info_Load(object sender, EventArgs e)
        {
            Utilities.Methods.UC_FillApplicationBasic_Info(OB_LDLAPP.GetLDLA(), UC_ApplicationBasic_Info);

        }
        private void IssueFirstTime()
        {
            clsWF_IssueFirstTimeLicense_BL IFTL
                           = new clsWF_IssueFirstTimeLicense_BL(OB_LDLAPP.Get_BaseAPP_ID());


            IFTL.SetNote(TB_Note.Text);

            if (IFTL.Save())
            {
                MessageBox.Show("Driver And License Added Successfully",
                    "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Btn_Issue.Enabled = false;
                this.Close();

            }
            else
            {
                MessageBox.Show("Some Thing Wrong Please Try Again",
                 "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void IssueJustLicense()
        {

            clsWF_IssueNewCategoryLicense_BL IL
                = new clsWF_IssueNewCategoryLicense_BL
                (OB_LDLAPP.Get_BaseAPP_ID(), clsDriver_BL.GetDriverIDByPersonID(OB_LDLAPP.PersonID));


            IL.SetNote(TB_Note.Text);

            if (IL.Save())
            {
                MessageBox.Show("License Added Successfully",
                    "Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Btn_Issue.Enabled = false;
                this.Close();
            }
            else
            {
                MessageBox.Show("Some Thing Wrong Please Try Again",
                 "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void Btn_Issue_Click(object sender, EventArgs e)
        {

            if (!_IsPersonHasDriverLicense)
                IssueFirstTime();
            else
                IssueJustLicense();


        }

        private void Label_Const_LicensePrice_Click(object sender, EventArgs e)
        {




        }

        private void UC_ApplicationBasic_Info_SendEventToOpenPersonInfo()
        {

        }
    }
}
