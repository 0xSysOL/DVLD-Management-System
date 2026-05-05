using DVLD_DataLayer.Tables.Tests_Appointment;
using System;

namespace DVLD_BussinessLogic.Application_Classes.Tests_Appointments
{
    public class clsTests_BL
    {


        public static bool TakeTest(bool TestResult, object Note, int UserID, ref int TestAppointmentID)
        {

            /* HACK: Title(TakeTest): 
             * Check If TestAppointment Exists  
             if(clsTestAppointment_BL.IsTestAppointmentID_Exists(ValueID))
             */

            /* HACK: Title(TakeTest):
             Check If TestAppointment Not Locked
             1- Call clsTestAppointment_BL
             2- Create Function That can Check If Not Locked
            optional 3- Create Enum Error in clsTests_BL and return Error Type
             */

            /* HACK: Title(TakeTest):
             * 
             *Check If UserID Exists */




            if (Note == null || string.IsNullOrWhiteSpace(Note.ToString()))
                Note = DBNull.Value;


            bool IsTakeSuccess = clsTests_DL.TakeTest(TestResult, Note, UserID, TestAppointmentID);
            if (IsTakeSuccess)
                TestAppointmentID = -1;



            return IsTakeSuccess;

        }


    }
}
