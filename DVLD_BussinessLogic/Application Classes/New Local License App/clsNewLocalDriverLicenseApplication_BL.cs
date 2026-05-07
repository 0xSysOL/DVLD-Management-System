using DVLD_BusinessLogic;
using DVLD_BussinessLogic.Application_Classes.Application;
using DVLD_BussinessLogic.License_Class;
using DVLD_DataLayer.Tables.Application_Classes.New_Local_Driving_License_Application;
using System;

namespace DVLD_BussinessLogic.Application_Classes.New_Local_License_App
{
    public class clsNewLocalDriverLicenseApplication_BL : clsApplication_BL
    {

        int LDLAPPID;
        private int ApplicationID;
        private int LicenseClassID;
        clsLicenseClass_BL clsLicenseClass;
        public int GetLDLA()
        {
            return LDLAPPID;
        }
        public void SetApplicationID(int ApplicationID)
        {
            this.ApplicationID = ApplicationID;
        }
        public void SetLicenseClassID(int LicenseClassID)
        {
            this.LicenseClassID = LicenseClassID;
        }
        public int GetApplicationID()
        {
            return ApplicationID;
        }
        public int GetLicenseClassID()
        {
            return LicenseClassID;
        }

        public clsNewLocalDriverLicenseApplication_BL
            (int LicenseClassID, int PersonID) : base(enApplicationType.LocalDrivingLicense)
        {
            LDLAPPID = -1;
            ApplicationID = -1;
            this.PersonID = PersonID;
            this.LicenseClassID = LicenseClassID;
            mode = eMode.Add;

        }

        public clsNewLocalDriverLicenseApplication_BL(int ApplicationID) : base(ApplicationID)
        {
            LDLAPPID = -1;
            LicenseClassID = -1;
            mode = eMode.Update;

            if (
       !clsNewLocalDrivingLicenseApp_DL.Get_LDLA_ByApplicationID
       (ApplicationID, ref LDLAPPID, ref LicenseClassID))
                mode = eMode.None;

        }

        public override bool IsPassedValidation()
        {


            if (mode == eMode.Add)
            {

                if (!Methods_BL.IsAgeValid(Convert.ToInt16(clsLicenseClass_BL.GetMinimumAllowedAge(LicenseClassID)),
                    clsPeople_BL.GetPersonDateOfBirth(PersonID)))
                    return false;
            }
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
                    LDLAPPID = clsNewLocalDrivingLicenseApp_DL.Add_Application_And_LDLAPP(ref base.ID, LicenseClassID,
                        ApplicationStatus, (int)eAppTypeID, PaidFees,
                        UserID, PersonID, ApplicationDate, LastStateDate);
                    mode = eMode.Update;
                    return LDLAPPID != -1;


                case eMode.Update:
                    return clsNewLocalDrivingLicenseApp_DL.Update_LDLA(LDLAPPID, LicenseClassID);





            }


            return false;
        }

        public static void GetDrivingLicenseInfo(int LDLAPP_ID, ref string LicenseName, ref int PassedTests)
        {

            clsNewLocalDrivingLicenseApp_DL.GetDrivingLicenseInfo(LDLAPP_ID, ref LicenseName, ref PassedTests);

        }

        public  void GetLocalDrivingLicense(int LDLAPP_ID)
        {
            int L_PersonID = -1;
            clsNewLocalDrivingLicenseApp_DL.GetLocalDrivingLicense(LDLAPP_ID,ref LicenseClassID, ref L_PersonID);
            PersonID = L_PersonID;

        }


    }


}
