using DVLD_BussinessLogic.Application_Classes.New_Local_License_App;
using DVLD_BussinessLogic.License_Class;
using DVLD_BussinessLogic.Workflows;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DVLD.Utilities.Methods;

namespace DVLD.Sub_Forms.Application
{
    public partial class Frm_IssueDriverLicenseForFirstTime : Form
    {
        clsNewLocalDriverLicenseApplication_BL OB_LDLAPP;


        public Frm_IssueDriverLicenseForFirstTime(int ApplicationID)
        {
        
            InitializeComponent();
            OB_LDLAPP = new clsNewLocalDriverLicenseApplication_BL(ApplicationID);
            Label_Variable_LicensePrice.Text = clsLicenseClass_BL.GetLicensePrice
                (OB_LDLAPP.GetLicenseClassID()).ToString();
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

        private void Btn_Issue_Click(object sender, EventArgs e)
        {
      clsWF_IssueFirstTimeLicense_BL IFTL
                = new clsWF_IssueFirstTimeLicense_BL(OB_LDLAPP.Get_BaseAPP_ID());


            IFTL.SetNote(TB_Note.Text);

            if (IFTL.Save())
            {

            }


        }

        private void Label_Const_LicensePrice_Click(object sender, EventArgs e)
        {
      



        }

    }
}
