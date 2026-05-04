using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataLayer.Tables.Tests_Appointment
{
    public class clsTests_DL
    {


        public static bool TakeTest(bool TestResult, object Note, int UserID, int TestAppointmentID)
        {
            int MultiResult = -1;

            using (SqlConnection connection = new SqlConnection(clsSetting_DL.ConnectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                SqlCommand command = connection.CreateCommand();
                command.Transaction = transaction;

                try
                {
                    command.CommandText = clsQTests.TakeTest;
                    command.Parameters.AddWithValue("@TestResult",TestResult);
                    command.Parameters.AddWithValue("@Note", Note);
                    command.Parameters.AddWithValue("@UserID", UserID);
                    command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
                    MultiResult = command.ExecuteNonQuery();



                    command.CommandText = clsQTestAppointment.Update_LockAppointment;
                    command.Parameters.AddWithValue("@AppointmentID", TestAppointmentID);
                    MultiResult += command.ExecuteNonQuery();

                    transaction.Commit();


                }
                catch (Exception e)
                {
                    transaction.Rollback();
                }
              


            }


            return MultiResult == 2 ? true : false;




        }


    }


}
