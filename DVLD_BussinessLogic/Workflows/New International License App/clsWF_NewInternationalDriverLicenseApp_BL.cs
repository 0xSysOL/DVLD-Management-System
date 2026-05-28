using DVLD_BussinessLogic.Drivers;
using DVLD_BussinessLogic.License_Classes;
using DVLD_BussinessLogic.Users_Classes.User_Setting;
using DVLD_DataLayer.Tables.Workflow;

namespace DVLD_BussinessLogic.Application_Classes.New_International_License_App
{
    public class clsWF_NewInternationalDriverLicenseApp_BL
    {

        DVLD_DataLayer.Structures_DL.Application clsApplication;
        //clsWF_IssueInternationalLicense_DL.cls_APP_And_IL_Variables.Application clsApplication;
        DVLD_DataLayer.Structures_DL.InternationalLicense clsInternational;


        public int GetILicenseID()
        {
           return clsInternational.InternationalLicenseID;
        }
        public int GetApplicationID()
        {
            return clsApplication.ApplicationID;
        }

        private void InitializeOb_SAPP(int DriverID)
        {
            //         clsApplication =
            //new clsWF_IssueInternationalLicense_DL.cls_APP_And_IL_Variables.Application
            //(DVLD_DataLayer.Structures_DL.Application.enApplicationType.,
            //clsDriver_BL.GetPersonIDByDriverID(DriverID),
            //CurrentUser.GetUserID(),
            //clsWF_IssueInternationalLicense_DL.cls_APP_And_IL_Variables.Application.eModeStatus.Completed);
            clsApplication = new DVLD_DataLayer.Structures_DL.Application
                     (DVLD_DataLayer.Structures_DL.Application.enApplicationType.NewInternationalLicense,
                     clsDriver_BL.GetPersonIDByDriverID(DriverID),
                     CurrentUser.GetUserID(),
                     DVLD_DataLayer.Structures_DL.Application.eModeStatus.Completed);


        }
        private void InitializeOb_SIL(int DriverID,int DriverLicenseID)
        {

            //clsInternational =
            //    new clsWF_IssueInternationalLicense_DL.cls_APP_And_IL_Variables.InternationalLicense(
            //        DriverID, CurrentUser.GetUserID(), DriverLicenseID);

            clsInternational = new DVLD_DataLayer.Structures_DL.InternationalLicense
                (DriverID, CurrentUser.GetUserID(), DriverLicenseID);
        }
        public clsWF_NewInternationalDriverLicenseApp_BL(int DriverID, int DriverLicenseID)
        {

            InitializeOb_SAPP(DriverID);
            InitializeOb_SIL(DriverID,DriverLicenseID);


         
                
        }


        public bool IsPassedValidation()
        {

            if (clsInternational.DriverID <= 0 || clsInternational.IssuedUsingLocalLicenseID <= 0)
                return false;
            // soon
            // 0 Is Driver Have International License??? - clsDriver
            if (clsDriver_BL.IsDriverHaveInternationalLicense(clsInternational.DriverID))
                return false;


            // 1 Is License Active                       - clsLicense
            if (!clsLicense_BL.IsLicenseActive(clsInternational.IssuedUsingLocalLicenseID))
                return false;
            // 2 Is License Expired                      - clsLicense

            if (clsLicense_BL.IsLicenseExpired(clsInternational.IssuedUsingLocalLicenseID))
                return false;


            return true;
        }

        public bool Save()
        {
            if (!IsPassedValidation())
                return false;


            return clsWF_IssueInternationalLicense_DL.CreateIssueInternationalLicense
                (clsApplication, clsInternational);



        }

    }














}
