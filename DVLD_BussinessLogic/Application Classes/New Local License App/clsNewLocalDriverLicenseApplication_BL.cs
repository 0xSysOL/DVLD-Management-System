using DVLD_DataLayer.Tables.Application_Classes.New_Local_Driving_License_Application;
using DVLD_DataLayer.Tables.Tests_Appointment.Vision_Test_Appointment;

namespace DVLD_BussinessLogic.Application_Classes.New_Local_License_App
{
    public class clsNewLocalDriverLicenseApplication_BL
    {

        int ID;
        private int ApplicationID;
        private int LicenseClassID;
        public int GetLDLA()
        {
            return ID;
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
        enum eMode { Add = 0, Update = 1 };
        eMode mode;

        public clsNewLocalDriverLicenseApplication_BL()
        {
            ID = -1;
            ApplicationID = -1;
            LicenseClassID = -1;

        }

        public clsNewLocalDriverLicenseApplication_BL(int ApplicationID) : this()
        {

            clsNewLocalDrivingLicenseApp_DL.Get_LDLA_ByApplicationID(ApplicationID, ID, this.ApplicationID, LicenseClassID);

        }


        public bool Save()
        {


            switch (mode)
            {

                case eMode.Add:
                    ID = clsNewLocalDrivingLicenseApp_DL.AddNew_LDLA(ref ID, ApplicationID, LicenseClassID);
                    mode = eMode.Update;
                    return true;


                case eMode.Update:
                    return clsNewLocalDrivingLicenseApp_DL.Update_LDLA(ID,LicenseClassID);
                    




            }


            return false;
        }

        public static void GetDrivingLicenseInfo(int LDLAPP_ID, ref string LicenseName, ref short PassedTests)
        {

            clsNewLocalDrivingLicenseApp_DL.GetDrivingLicenseInfo(LDLAPP_ID, ref LicenseName, ref PassedTests);

        }


    }
}
