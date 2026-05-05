using DVLD_DataLayer.Tables.Tests_Appointment;
using System;
using System.Collections.Generic;
using System.Data;

namespace DVLD_BussinessLogic.Application_Classes
{
    public class clsTestAppointment_BL
    {
       public enum eMode { Update,Add}
      public  eMode mode;
     
        private int _AppointmentID;
        private int _LDLApplicationID;
        private int _TestTypeID;
        private DateTime _AppointmentDate;
        private decimal _PaidFees;
        private int _CreateByUserID;
        private object _RetakeTeApp;
        public int GetAppointmentID()
        {
            return _AppointmentID;
        }

        public int GetLDLApplicationID()
        {
            return _LDLApplicationID;
        }
        public void SetLDLApplicationID(int value)
        {
            _LDLApplicationID = value;
        }

        public int GetTestTypeID()
        {
            return _TestTypeID;
        }
        public void SetTestTypeID(int value)
        {
            _TestTypeID = value;
        }

        public DateTime GetAppointmentDate()
        {
            return _AppointmentDate;
        }
        public void SetAppointmentDate(DateTime value)
        {
            _AppointmentDate = value;
        }

        public decimal GetPaidFees()
        {
            return _PaidFees;
        }
        public void SetPaidFees(decimal value)
        {
            _PaidFees = value;
        }

        public int GetCreateByUserID()
        {
            return _CreateByUserID;
        }
        public void SetCreateByUserID(int value)
        {
            _CreateByUserID = value;
        }

        public object GetRetakeTeApp()
        {
            return _RetakeTeApp;
        }
        public void SetRetakeTeApp(object value)
        {
            _RetakeTeApp = value;
        }
        public clsTestAppointment_BL()
        {
            _AppointmentID = -1;
            _LDLApplicationID = -1;
            _TestTypeID = -1;
            _AppointmentDate = new DateTime();
            _PaidFees = -1;
            _CreateByUserID = -1;
            _RetakeTeApp = null;
            this.mode = eMode.Add;


        }
        public clsTestAppointment_BL(int AppointmentID) : this()
        {
          
           clsTestAppointment_DL.FillClass(AppointmentID, ref _LDLApplicationID,ref _TestTypeID, 
               ref _AppointmentDate,ref  _PaidFees,
              ref  _CreateByUserID, ref _RetakeTeApp);
            _AppointmentID = AppointmentID;
            this.mode = eMode.Update;

        }

        public bool Save()
        {
            if (_RetakeTeApp == null)
                _RetakeTeApp = DBNull.Value;


            switch (mode)
            {


                case eMode.Add:

                    _AppointmentID = clsTestAppointment_DL.Add_TestAppointment(_LDLApplicationID, _TestTypeID, _AppointmentDate, _PaidFees,
                              _CreateByUserID, _RetakeTeApp);
                    this.mode = eMode.Update;
                    return true;
                case eMode.Update:
                    return clsTestAppointment_DL.Update_TestAppointment(_AppointmentID, ref _AppointmentDate);


                 

                    
            }
            return false;

        }


        public static bool IsVisionTestPassed(int LDLA_ID)
        {

            return clsTestAppointment_DL.IsVisionTestPassed(LDLA_ID);



        }
        public static bool IsWrittenTestPassed(int LDLA_ID)
        {

            return clsTestAppointment_DL.IsWrittenTestPassed(LDLA_ID);



        }

        public static bool IsStreetTestPassed(int LDLA_ID)
        {

            return clsTestAppointment_DL.IsStreetTestPassed(LDLA_ID);



        }


        public static DataTable GetAppointmentInfoBy_LDLAPP_ID(int LDLAPP_ID, int TestType)
        {


            return clsTestAppointment_DL.GetAppointmentInfoBy_LDLAPP_ID(LDLAPP_ID, TestType);


        }

        public static bool IsPersonTakeTestBefore(int LDLAPP_ID, int TestTypeID)
        {

            return clsTestAppointment_DL.IsPersonTakeTestBefore(LDLAPP_ID, TestTypeID);
        }

        public static bool FindAnyActiveAppointment(int LDLAPP_ID, int TestType)
        {

            return clsTestAppointment_DL.FindAnyActiveAppointment(LDLAPP_ID, TestType);

        }

        public static void GetTestAppointmentDetails(int LDLApplicationID, int TestType, ref string LicenseClassName, ref string FullName,
           ref int Trial, ref DateTime AppointmentDate, ref decimal TestFees)
        {


            clsTestAppointment_DL.GetTestAppointmentDetails(LDLApplicationID, TestType, ref LicenseClassName, ref FullName,
                ref Trial, ref AppointmentDate, ref TestFees);

        }
        public static void GetApplicationDetailsForNewAppointment(int LDLApplicationID, int TestType,
            ref string LicenseClassName, ref string FullName,
           ref int Trial, ref DateTime AppointmentDate, ref decimal TestFees)
        {

            clsTestAppointment_DL.GetApplicationDetailsForNewAppointment(LDLApplicationID, TestType, ref LicenseClassName, ref FullName,
                 ref Trial, ref AppointmentDate, ref TestFees);

        }



    
    
    
    
    }
}
