using DVLD_BusinessLogic;
using DVLD_BussinessLogic.Application_Classes.Application;
using DVLD_BussinessLogic.License_Class;
using DVLD_BussinessLogic.Users_Classes.User_Setting;
using DVLD_DataLayer.Tables.Application_Classes.New_Local_Driving_License_Application;
using System;

namespace DVLD_BussinessLogic.Application_Classes.New_Local_License_App
{
    public class clsNewLocalDriverLicenseApplication_BL : clsApplication_BL
    {

        int LDLAPPID;
        private int LicenseClassID;
        public int GetLDLA()
        {
            return LDLAPPID;
        }
       
        public void SetLicenseClassID(int LicenseClassID)
        {
            this.LicenseClassID = LicenseClassID;
        }
      
        public int GetLicenseClassID()
        {
            return LicenseClassID;
        }

        public clsNewLocalDriverLicenseApplication_BL
            (int LicenseClassID, int PersonID) : base(enApplicationType.LocalDrivingLicense)
        {
            LDLAPPID = -1;
            Base_ApplicationID = -1;
            this.PersonID = PersonID;
            this.LicenseClassID = LicenseClassID;

            mode = eMode.Add;

        }
         
        public clsNewLocalDriverLicenseApplication_BL(int ApplicationID) : base(ApplicationID)
        {
            LDLAPPID = -1;
            LicenseClassID = -1;
            mode = eMode.Update;


            if (!clsNewLocalDrivingLicenseApp_DL.Get_LDLA_ByApplicationID(ApplicationID, ref LDLAPPID, ref LicenseClassID))
                mode = eMode.None;


            Base_ApplicationID = ApplicationID;

        }

        public override bool IsPassedValidation()
        {


            if (!Methods_BL.IsAgeValid(Convert.ToInt16(clsLicenseClass_BL.GetMinimumAllowedAge(LicenseClassID)),
                clsPeople_BL.GetPersonDateOfBirth(PersonID)))
                return false;

            if
                ((IsPersonHaveNewApp(PersonID, LicenseClassID)) == eModeState.New)
                return false;

            if (IsPersonHaveCompletedApp(PersonID, LicenseClassID) == eModeState.Completed)
                return false;

            return true;
        }

        public override bool Save()
        {


            if (!IsPassedValidation())
                return false;


            switch (mode)
            {

                case eMode.Add:
                    LDLAPPID = clsNewLocalDrivingLicenseApp_DL.Add_Application_And_LDLAPP(ref base.Base_ApplicationID, LicenseClassID,
                        ApplicationStatus, (int)eAppTypeID, PaidFees,
                        CurrentUser.GetUserID(), PersonID, ApplicationDate = DateTime.Now, LastStateDate = DateTime.Now);
                    if (LDLAPPID != -1)
                    {
                        mode = eMode.Update;
                        modeState = eModeState.New;
                        return true;
                    }

                    break;
                case eMode.Update:
                    LastStateDate = DateTime.Now;
                    return clsNewLocalDrivingLicenseApp_DL.Update_Application_LDLA(LDLAPPID, LicenseClassID,
                    base.Base_ApplicationID, LastStateDate);





            }


            return false;
        }

        public static void GetDrivingLicenseInfo(int LDLAPP_ID, ref string LicenseName, ref int PassedTests)
        {

            clsNewLocalDrivingLicenseApp_DL.GetDrivingLicenseInfo(LDLAPP_ID, ref LicenseName, ref PassedTests);

        }

        public void GetLocalDrivingLicense(int LDLAPP_ID)
        {
            int L_PersonID = -1;
            clsNewLocalDrivingLicenseApp_DL.GetLocalDrivingLicense(LDLAPP_ID, ref LicenseClassID, ref L_PersonID);
            PersonID = L_PersonID;

        }


    }


}
