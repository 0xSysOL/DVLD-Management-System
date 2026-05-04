using DVLD_DataLayer.Tables.Tests_Appointment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BussinessLogic.Application_Classes.Tests_Appointments
{
    public class clsTests_BL
    {


        public static bool TakeTest(bool TestResult,object Note,int UserID,int TestAppointmentID)
        {
            if (Note.ToString() == "")
                Note = DBNull.Value;



            return clsTests_DL.TakeTest(TestResult, Note, UserID, TestAppointmentID);

        }


    }
}
