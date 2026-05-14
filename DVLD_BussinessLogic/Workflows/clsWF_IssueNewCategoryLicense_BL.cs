using DVLD_BussinessLogic.Users_Classes.User_Setting;
using DVLD_DataLayer.Tables.Workflow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BussinessLogic.Workflows
{
    public class clsWF_IssueNewCategoryLicense_BL : clsWF_IssueFirstTimeLicense_BL
    {

        public clsWF_IssueNewCategoryLicense_BL(int Application,int DriverID) : base(Application)
        {

            InitializeDriverOB(DriverID);

        }

        public override bool Save()
        {

       
            int LicenseID = -1; // Ref


            return clsWF_IssueNewCategoryLicense_DL.
                Save_NewLicenseAndUpAPP(Ob_Driver.DriverID,
                Ob_Driver.GetPersonID(),
                CurrentUser.GetUserID(),
                Ob_Driver.GetCreateDate(),
                ref LicenseID,
                NewLicense.GetLicenseClassID(),
                NewLicense.GetApplicationID(),
                NewLicense.GetIssueDate(),
                NewLicense.GetExpireDate(),
                NewLicense.GetNotes(),
                NewLicense.GetPaidFees(),
                NewLicense.GetIsActive(),
                NewLicense.GetIssueReasonID());

        }

    }
}
