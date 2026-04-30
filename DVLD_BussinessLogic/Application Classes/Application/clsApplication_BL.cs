using DVLD_BusinessLogic;
using DVLD_DataLayer.Tables.Application_Classes;
using DVLD_DataLayer.Tables.Tests_Appointment;
using System;
using System.Data;

namespace DVLD_BussinessLogic.Application_Classes.Application
{
    public class clsApplication_BL
    {

        public enum eMode { Add = 0, Update = 1 };
        public enum eModeState { New = 1, Cancel = 2, Completed = 3, None = 0 };
        public eModeState modeState = eModeState.None;
        public eMode mode;


        private int ID;
        public int GetID()
        {
            return ID;
        }
        public DateTime ApplicationDate { get; set; }
        public byte ApplicationState { get; set; }
        public decimal PaidFees { get; set; }
        public int ApplicationTypeID { get; set; }
        public int UserID { get; set; }
        public int PersonID { get; set; }
        public DateTime LastStateDate { get; set; }


        public clsApplication_BL()
        {
            ID = -1;
            ApplicationState = 1;
            ApplicationTypeID = -1;
            PaidFees = -1;
            UserID = -1;
            PersonID = -1;
            mode = eMode.Add;
        }

        public clsApplication_BL(int ApplicationID)
        {
            
            DateTime _ApplicationDate = new DateTime();
            byte _ApplicationState = 0;
            decimal _PaidFees = 0;
            int _ApplicationTypeID = -1;
            int _UserID = -1;
            int _PersonID = -1;
            DateTime _LastStateDate = new DateTime();

            clsApplication_DL.GetApplicationByID(ApplicationID, ref _ApplicationDate, ref _ApplicationState
                , ref _PaidFees, ref _ApplicationTypeID, ref _UserID, ref _PersonID, ref _LastStateDate);

            ID = ApplicationID;
            ApplicationDate = _ApplicationDate;
            ApplicationState = _ApplicationState;
            PaidFees = _PaidFees;
            ApplicationTypeID = _ApplicationTypeID;
            UserID = _UserID;
            PersonID = _PersonID;
            LastStateDate = _LastStateDate;

        }
        public static DataTable GetAllApplications()
        {

            return clsApplication_DL.GetAllApplications();

        }
        public static DataTable GetAllApplications_WithFilter(object Value, string ColumnName)
        {

            return clsApplication_DL.GetAllApplications_WithFilter(Value, ColumnName);

        }
        public bool Save(short MinAge, DateTime DateOfBirth, int LicenseClassID)
        {
            #region Validation 

            if (mode == eMode.Add)
            {
                if (!Methods_BL.IsAgeValid(MinAge, DateOfBirth))
                    return false;
                if
                    ((IsPersonHaveNewApp(PersonID, LicenseClassID)) == eModeState.New)
                    return false;
                
                if (IsPersonHaveCompletedApp(PersonID, LicenseClassID) == eModeState.Completed)
                    return false;

            }
            #endregion End



            switch (mode)
            {

                case eMode.Add:
                    ID = clsApplication_DL.AddNewApplication(ApplicationState, ApplicationTypeID, PaidFees,
                        UserID, PersonID, ApplicationDate, LastStateDate);
                    mode = eMode.Update;
                    break;
                case eMode.Update:
                    return clsApplication_DL.UpdateApplication(ID, LastStateDate, PaidFees, UserID);




            }

            return (ID != -1) ? true : false;
        }

        public eModeState IsPersonHaveNewApp(int PersonID, int ClassID)
        {

            if (clsApplication_DL.IsApplicationNew(PersonID, ClassID))
                return eModeState.New;



            return eModeState.None;
           

        }
        public eModeState IsPersonHaveCompletedApp(int PersonID, int ClassID)
        {

            if (clsApplication_DL.IsApplicationCompleted(PersonID, ClassID))
                return eModeState.Completed;



            return eModeState.None;


        }
        public static bool CancelApplicationState(int LDLA_AppID)
        {
            int ApplicationID = clsApplication_DL.GetApplicationIDBy_LDLA_APPID(LDLA_AppID);

            clsApplication_BL clsApplication = new clsApplication_BL(ApplicationID);

            if ((eModeState)clsApplication.ApplicationState == eModeState.Completed
                ||
                (eModeState)clsApplication.ApplicationState == eModeState.Cancel)
                return false;




            if (clsApplication_DL.IsPersonHaveAnyTestsActive(LDLA_AppID))
                return false;




            return clsApplication_DL.CancelApplicationState(ApplicationID);

        }

        public static bool DeleteApplication(int LDLA_AppID)
        {

            if (clsApplication_DL.IsPersonHaveAnyTests(LDLA_AppID))
                return false;



            return clsApplication_DL.DeleteApplication(LDLA_AppID);


        }
        

        public static void GetApplicationBasicInfo(int LDLAPP_ID,ref  string ApplicationStatus,ref int ApplicationID,ref decimal ApplicationFees,
            ref string ApplicationTypeTitle,ref string FullName,
            ref DateTime ApplicationDate,ref DateTime ApplicationDateStatus,
            ref string Username)
        {

            clsApplication_DL.GetApplicationBasicInfo(LDLAPP_ID,ref ApplicationStatus, ref ApplicationID, ref ApplicationFees,
               ref ApplicationTypeTitle, ref FullName, ref ApplicationDate, ref ApplicationDateStatus, ref Username);



        }




        public static bool FindAnyActiveAppointment(int LDLAPP_ID,int TestType)
        {

            return clsApplication_DL.FindAnyActiveAppointment(LDLAPP_ID,TestType);

        }
        public static bool IsPersonPassedTest(int LDLAPP_ID, int TestType)
        {

            return clsApplication_DL.IsPersonPassedTest(LDLAPP_ID, TestType);

        }







    }







}
