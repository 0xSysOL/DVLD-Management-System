using DVLD_BussinessLogic.License_Class;
using DVLD_BussinessLogic.License_Classes;
using DVLD_BussinessLogic.Users_Classes.User_Setting;
using DVLD_DataLayer.Tables.License_Class;
using DVLD_DataLayer.Tables.Workflow;
using System;

namespace DVLD_BussinessLogic.RenewLocalDrivingLicense
{
    public class clsWF_RenewLocalDrivingLicense_BL
    {


        int _LicenseID;
        DVLD_DataLayer.Structures_DL.Application Application;
        DVLD_DataLayer.Structures_DL.clsLicense License;

        public int GetApplicationID()
        {
            return Application.ApplicationID;
        }
        public int GetNewLicenseID()
        {
            return License.GetLicenseID();
        }

        private void InitializeOb_SAPP(int PersonID)
        {

            Application = new DVLD_DataLayer.Structures_DL.Application
                     (DVLD_DataLayer.Structures_DL.Application.enApplicationType.RenewDrivingLicense,
                     PersonID,
                     CurrentUser.GetUserID(),
                     DVLD_DataLayer.Structures_DL.Application.eModeStatus.Completed);


        }
        private void FillLicense(int LicenseID, string Notes)
        {
            License = new DVLD_DataLayer.Structures_DL.clsLicense();
            clsLicense_DL.GetLicenseInfo(LicenseID, ref License);

            License.SetCreatedByUserID(CurrentUser.GetUserID());//
            License.SetIsActive(true);//
            License.SetIssueDate(DateTime.Now);
            License.SetIssueReasonID((int)Application.eAppTypeID);
            License.SetExpireDate
                (
                DateTime.Now.AddYears(clsLicenseClass_BL.GetDefaultValidityLength(License.GetLicenseClassID())));
            License.SetNotes(Notes);

        }
        public clsWF_RenewLocalDrivingLicense_BL(int LicenseID, string Notes)
        {

            _LicenseID = LicenseID;
            int PersonID = clsLicense_BL.GetPersonIDByLicenseID(LicenseID);
            InitializeOb_SAPP(PersonID);
            FillLicense(LicenseID, Notes);

        }

        public bool IsExpired()
        {

            return clsLicense_BL.GetExpirationDate(_LicenseID) < DateTime.Now;

        }
        public bool IsPassedValidation()
        {

            if (clsLicense_BL.IsLicenseActive(_LicenseID) && IsExpired())
                return true;


            return false;
        }
        public bool Save()
        {
            if (!IsPassedValidation())
                return false;






            return clsWF_RenewLicense_DL.RenewLicense(Application, License, _LicenseID);

        }


    }
}
