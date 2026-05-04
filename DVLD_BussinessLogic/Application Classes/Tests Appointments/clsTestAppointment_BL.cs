using DVLD_DataLayer.Tables.Tests_Appointment;
using System;
using System.Collections.Generic;
using System.Data;

namespace DVLD_BussinessLogic.Application_Classes
{
    public class clsTestAppointment_BL
    {
        enum eMode { Update,Add}
        eMode mode;
        private int AppointmentID;

      public int LDLApplicationID { get; set; }
      public int TestTypeID { get; set; }
      public DateTime AppointmentDate { get; set; }
      public decimal PaidFees { get; set; }
      public int CreateByUserID { get; set; }
      public object RetakeTeApp  { get; set; }

        public  bool Save(int LDLApplicationID, int TestTypeID,
        DateTime AppointmentDate, decimal PaidFees, int CreateByUserID, object RetakeTeApp = null)
        {

            switch (mode)
            {



            }
            if (!FindAnyActiveAppointment(LDLApplicationID, TestTypeID))
            {
                // Insert  
                return clsTestAppointment_DL.Add_TestAppointment(LDLApplicationID, TestTypeID, AppointmentDate, PaidFees,
                      CreateByUserID, RetakeTeApp);

            }
            else
            {
                return clsTestAppointment_DL.Update_TestAppointment(AppointmentDate);
                // Update



            }


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
