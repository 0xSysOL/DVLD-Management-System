using DVLD_DataLayer.Tables.Tests_Appointment;
using System;
using System.Data;

namespace DVLD_BussinessLogic.Application_Classes
{
    public class clsTestAppointment_BL
    {



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
           ref int Trial, ref DateTime AppointmentDate, ref decimal TestFees, bool IsNew = false)
        {


            clsTestAppointment_DL.GetTestAppointmentDetails(LDLApplicationID, TestType, ref LicenseClassName, ref FullName,
                ref Trial, ref AppointmentDate, ref TestFees, IsNew);

        }
        public static void GetApplicationDetailsForNewAppointment(int LDLApplicationID, int TestType,
            ref string LicenseClassName, ref string FullName,
           ref int Trial, ref DateTime AppointmentDate, ref decimal TestFees)
        {

            GetTestAppointmentDetails(LDLApplicationID, TestType,
                ref LicenseClassName, ref FullName,
                ref Trial, ref AppointmentDate, ref TestFees, true);

        }


        public static bool Save(int LDLApplicationID, int TestTypeID,
            DateTime AppointmentDate, decimal PaidFees, int CreateByUserID, object RetakeTeApp = null)
        {

            if (!FindAnyActiveAppointment(LDLApplicationID, TestTypeID))
            {
                // Insert  
                clsTestAppointment_DL.Add_TestAppointment(LDLApplicationID, TestTypeID, AppointmentDate, PaidFees,
                    CreateByUserID, RetakeTeApp);
                return true;
            }
            else
            {
                clsTestAppointment_DL.Update_TestAppointment(LDLApplicationID, TestTypeID, AppointmentDate, PaidFees,
                    CreateByUserID, RetakeTeApp);
                // Update
                return true;


            }


        }
    
    
    
    }
}
