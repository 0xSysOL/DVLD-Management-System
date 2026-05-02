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


    }
}
