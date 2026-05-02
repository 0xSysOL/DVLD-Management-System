using DVLD_DataLayer.Tables.Application_Classes;
using DVLD_DataLayer.Tables.Tests_Appointment;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            return clsTestAppointment_DL.IsPersonTakeTestBefore(LDLAPP_ID,TestTypeID);
        }

        public static bool FindAnyActiveAppointment(int LDLAPP_ID, int TestType)
        {

            return clsTestAppointment_DL.FindAnyActiveAppointment(LDLAPP_ID, TestType);

        }    
        //if (FindAnyActiveAppointment(LDLApplicationID, TestType))
        //    {  
        //        // Update 
        //    }
        //    else
        //    {
        //                     // Insert


        //    }
        public static void GetTestAppointmentDetails(int LDLApplicationID,int TestType,ref string LicenseClassName,ref string FullName,
           ref int Trial,ref DateTime AppointmentDate,ref  decimal TestFees)
        {


            clsTestAppointment_DL.GetTestAppointmentDetails(LDLApplicationID,TestType,ref LicenseClassName,ref FullName,
                ref Trial,  ref AppointmentDate,ref TestFees);

        }
        public static void GetApplicationDetailsForNewAppointment(int LDLApplicationID, 
            ref string LicenseClassName, ref string FullName,
           ref int Trial, ref DateTime AppointmentDate, ref decimal TestFees)
        {

            GetTestAppointmentDetails(LDLApplicationID,-1,
                ref LicenseClassName, ref FullName,
                ref Trial, ref AppointmentDate, ref TestFees);

        }

    }
}
