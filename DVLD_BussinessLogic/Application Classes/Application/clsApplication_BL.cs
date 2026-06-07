using DVLD_BusinessLogic;
using DVLD_BussinessLogic.License_Class;
using DVLD_DataLayer.Application_Classes;
using DVLD_DataLayer.Tables.Application_Classes;
using System;
using System.Data;

namespace DVLD_BussinessLogic.Application_Classes.Application
{
    public abstract class clsApplication_BL
    {

        public enum eMode { Add = 0, Update = 1, None = -1 };
        public enum eModeState { New = 1, Cancel = 2, Completed = 3, None = 0 };
        public enum enApplicationType
        {
            None,
            LocalDrivingLicense = 1,
            RenewDrivingLicense = 2,
            ReplacementLost = 3,
            ReplacementDamaged = 4,
            ReleaseDetained = 5,
            NewInternationalLicense = 6,
            RetakeTest = 7
        }
        public enApplicationType eAppTypeID;
        public eModeState modeState;
        public eMode mode;


        protected int Base_ApplicationID;
        public int Get_BaseAPP_ID()
        {
            return Base_ApplicationID;
        }
        public DateTime ApplicationDate { get; set; }
        public byte ApplicationStatus { get; set; }
        public decimal PaidFees { get; set; }
        public int ApplicationTypeID { get; set; }
        public int UserID { get; set; }
        public int PersonID { get; set; }
        public DateTime LastStateDate { get; set; }

        
        private void  SetStatusAlongTheApplicationType(enApplicationType eAppTypeID)
        {
            switch (eAppTypeID)
            {
                case enApplicationType.None:
                    modeState = eModeState.None;
                    break;

                // Grouping all types that result in "New"
                case enApplicationType.LocalDrivingLicense:
                case enApplicationType.ReplacementLost:
                case enApplicationType.ReplacementDamaged:
                case enApplicationType.ReleaseDetained:
                    modeState = eModeState.New;
                    break;

                // Grouping all types that result in "Completed"
                case enApplicationType.RenewDrivingLicense:
                case enApplicationType.NewInternationalLicense:
                case enApplicationType.RetakeTest:
                    modeState = eModeState.Completed;
                    break;

                default:
                    modeState = eModeState.None;
                    break;
            }
        }
        public clsApplication_BL(enApplicationType eAppTypeID)
        {
            Base_ApplicationID = -1;
            ApplicationStatus = (int)eModeState.New;
            PaidFees = clsManageApplicationTypes_BL.GetFeesByID((int)eAppTypeID);
            UserID = -1;
            PersonID = -1;
            mode = eMode.Add;
            SetStatusAlongTheApplicationType(eAppTypeID);
            this.eAppTypeID = eAppTypeID;
           
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

            clsApplication_DL.GetApplicationByID(ref ApplicationID, ref _ApplicationDate, ref _ApplicationState
                , ref _PaidFees, ref _ApplicationTypeID, ref _UserID, ref _PersonID, ref _LastStateDate);

            Base_ApplicationID = ApplicationID;
            ApplicationDate = _ApplicationDate;
            ApplicationStatus = _ApplicationState;
            PaidFees = _PaidFees;

            this.eAppTypeID = (enApplicationType)_ApplicationTypeID;
            this.mode = eMode.Update;

            UserID = _UserID;
            PersonID = _PersonID;
            LastStateDate = _LastStateDate;

        }

   

        public static DataTable Get_LDL_Applications()
        {

            return clsApplication_DL.Get_LDL_Applications();

        }
        public static DataTable GetAllApplications_WithFilter(object Value, string ColumnName)
        {

            return clsApplication_DL.GetAllApplications_WithFilter(Value, ColumnName);

        }

        public abstract bool IsPassedValidation();
        public abstract bool Save();


        public static eModeState IsPersonHaveNewApp(int PersonID, int ClassID)
        {

            if (clsApplication_DL.IsApplicationNew(PersonID, ClassID))
                return eModeState.New;



            return eModeState.None;


        }
        public static eModeState IsPersonHaveCompletedApp(int PersonID, int ClassID)
        {

            if (clsApplication_DL.IsApplicationCompleted(PersonID, ClassID))
                return eModeState.Completed;



            return eModeState.None;


        }


        /* FIXED : We Are Create Object To just Know Status
         Fix  we will replace that ,Just Give LDLA_APP_ID
        And Return One Column Instead Create Object  Save All Data 
        that not be use
        1-CancelApplicationState - DONE
        2-DeleteApplication - DONE
         */


        public static int GetApplicationID_ByLDLAPPID(int LDLA_AppID)
        {
            return clsApplication_DL.GetApplicationIDBy_LDLA_APPID(LDLA_AppID);
        }
        public static eModeState GetStatusBy_LDLAPP_ID(int LDLA_AppID)
        {
            int ApplicationID = clsApplication_DL.GetApplicationIDBy_LDLA_APPID(LDLA_AppID);

            return (eModeState)clsApplication_DL.GetStatusByID(ApplicationID);

        }
        public static bool CancelApplicationState(int LDLA_AppID)
        {

            eModeState modeStatus = GetStatusBy_LDLAPP_ID(LDLA_AppID);

            if (modeStatus == eModeState.Completed
                ||
                (modeStatus == eModeState.Cancel))
                return false;


            if (clsApplication_DL.IsPersonHaveAnyTestsActive(LDLA_AppID))
                return false;


            int ApplicationID = clsApplication_DL.GetApplicationIDBy_LDLA_APPID(LDLA_AppID);


            return clsApplication_DL.CancelApplicationState(ApplicationID);

        }
        public static bool DeleteApplication(int LDLA_AppID)
        {

            if (clsApplication_DL.IsPersonHaveAnyTests(LDLA_AppID))
                return false;


            eModeState modeStatus = GetStatusBy_LDLAPP_ID(LDLA_AppID);

            if (modeStatus == eModeState.Completed
                ||
                (modeStatus == eModeState.Cancel))
                return false;


            return clsApplication_DL.DeleteApplication(LDLA_AppID);


        }


        public static void GetApplicationBasicInfo(int LDLAPP_ID, ref string ApplicationStatus, ref int ApplicationID, ref decimal ApplicationFees,
            ref string ApplicationTypeTitle, ref string FullName,
            ref DateTime ApplicationDate, ref DateTime ApplicationDateStatus,
            ref string Username)
        {

            clsApplication_DL.GetApplicationBasicInfo(LDLAPP_ID, ref ApplicationStatus, ref ApplicationID, ref ApplicationFees,
               ref ApplicationTypeTitle, ref FullName, ref ApplicationDate, ref ApplicationDateStatus, ref Username);

             
        }


        public static void GetApplicationBasicInfoByApplicationID(int ApplicationID, ref string ApplicationStatus, ref decimal ApplicationFees,
         ref string ApplicationTypeTitle, ref string FullName,
         ref DateTime ApplicationDate, ref DateTime ApplicationDateStatus,
         ref string Username)
        {

            clsApplication_DL.GetApplicationBasicInfoByApplicationID(ApplicationID, ref ApplicationStatus, ref ApplicationFees,
               ref ApplicationTypeTitle, ref FullName, ref ApplicationDate, ref ApplicationDateStatus, ref Username);



        }

        public static int GetPersonID(int ApplicationID)
        {

            return clsApplication_DL.GetPersonID(ApplicationID);

        }


        public static bool IsPersonPassedTest(int LDLAPP_ID, int TestType)
        {

            return clsApplication_DL.IsPersonPassedTest(LDLAPP_ID, TestType);

        }







    }







}
