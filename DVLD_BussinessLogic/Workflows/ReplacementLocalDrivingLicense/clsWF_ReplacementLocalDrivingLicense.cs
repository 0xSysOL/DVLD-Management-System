using DVLD_BussinessLogic.Application_Classes.Application;
using DVLD_BussinessLogic.License_Class;
using DVLD_BussinessLogic.License_Classes;
using DVLD_BussinessLogic.RenewLocalDrivingLicense;
using DVLD_BussinessLogic.Users_Classes.User_Setting;
using DVLD_DataLayer.Structures_DL;
using DVLD_DataLayer.Tables.License_Class;
using DVLD_DataLayer.Tables.Workflow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BussinessLogic.Workflows.ReplacementLocalDrivingLicense
{
    public class clsWF_ReplacementLocalDrivingLicense 
    {
        DVLD_DataLayer.Structures_DL.Application Application;
        DVLD_DataLayer.Structures_DL.clsLicense License;

        public int GetNewLicenseID()
        {

            return License.GetLicenseID();
        }
        public int GetApplicationID()
        {

            return Application.ApplicationID;
        }


        private void InitializeOb_SAPP(int PersonID, int ApplicationTypeID)
        {

            Application.enApplicationType eAppType =
                (Application.enApplicationType)ApplicationTypeID;

            Application = new Application
                     (eAppType,
                     PersonID,
                     CurrentUser.GetUserID(),
                    Application.eModeStatus.Completed);


        }
        private void FillLicense(int LicenseID,int IssueReasonID)
        {
            License = new DVLD_DataLayer.Structures_DL.clsLicense();
            clsLicense_DL.GetLicenseInfo(LicenseID, ref License);
            License.SetApplicationID(-1);
            License.SetPaidFees(0);
            License.SetIssueReasonID(IssueReasonID);


            License.SetCreatedByUserID(CurrentUser.GetUserID());//
            License.SetIsActive(true);//
            License.SetIssueDate(DateTime.Now);
            License.SetIssueReasonID((int)Application.eAppTypeID);
            License.SetExpireDate
       (DateTime.Now.AddYears(clsLicenseClass_BL.GetDefaultValidityLength(License.GetLicenseClassID())));

        }
        public clsWF_ReplacementLocalDrivingLicense(int LicenseID,int AppTypeID)
        {
            InitializeOb_SAPP(clsLicense_BL.GetPersonIDByLicenseID(LicenseID), AppTypeID);
            FillLicense(LicenseID, AppTypeID);


        }
        public bool IsPassedValidation()
        {

            if (clsLicense_BL.IsLicenseActive(License.GetLicenseID()))
                return true;


            return false;
        }
        public bool Save()
        {
            if (!IsPassedValidation())
                return false;






            return clsWF_RenewLicense_DL.IssueLicenseForLostOrRenewOrDamage(Application, License, License.GetLicenseID());

        }

    }


}
