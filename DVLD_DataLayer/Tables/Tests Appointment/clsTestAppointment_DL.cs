using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataLayer.Tables.Tests_Appointment
{
    public class clsTestAppointment_DL
    {


        public static bool IsVisionTestPassed(int LDLA_ID)
        {
            SqlConnection connection = new SqlConnection(clsSetting_DL.ConnectionString);
            SqlCommand command = new SqlCommand(clsQTestAppointment.IsVisionTestPassed, connection);
            object Result = -1;
            command.Parameters.AddWithValue("@Value", LDLA_ID);

            try
            {
                connection.Open();

                Result = command.ExecuteScalar();

            }
            catch (Exception e)
            {

            }
            finally { connection.Close(); }

            return Convert.ToInt32(Result) == 1 ? true : false;



        }





        public static bool IsWrittenTestPassed(int LDLA_ID)
        {

            SqlConnection connection = new SqlConnection(clsSetting_DL.ConnectionString);
            SqlCommand command = new SqlCommand(clsQTestAppointment.IsWrittenTestPassed, connection);
            object Result = -1;
            command.Parameters.AddWithValue("@Value", LDLA_ID);

            try
            {
                connection.Open();

                Result = command.ExecuteScalar();

            }
            catch (Exception e)
            {

            }
            finally { connection.Close(); }

            return Convert.ToInt32(Result) == 1 ? true : false;



        }

        // Yeat
        public static bool IsStreetTestPassed(int LDLA_ID)
        {


            SqlConnection connection = new SqlConnection(clsSetting_DL.ConnectionString);
            SqlCommand command = new SqlCommand(clsQTestAppointment.IsStreetTestPassed, connection);
            object Result = -1;
            command.Parameters.AddWithValue("@Value", LDLA_ID);

            try
            {
                connection.Open();

                Result = command.ExecuteScalar();

            }
            catch (Exception e)
            {

            }
            finally { connection.Close(); }

            return Convert.ToInt32(Result) == 1 ? true : false;





        }


        public static DataTable GetAppointmentInfoBy_LDLAPP_ID(int LDLAPP_ID, int TestType)
        {
            SqlConnection connection = new SqlConnection(clsSetting_DL.ConnectionString);
            SqlCommand command = new SqlCommand(clsQTestAppointment.GetAppointmentsBy_LDLAPP_ID, connection);
            DataTable data = new DataTable();

            command.Parameters.AddWithValue("@LDLAPP_ID", LDLAPP_ID);
            command.Parameters.AddWithValue("@TestType", TestType);
            try
            {
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                        data.Load(reader);



                }

            }
            catch (Exception e)
            {

            }
            finally { connection.Close(); }

            return data;


        }


        public static bool IsPersonTakeTestBefore(int LDLAPP_ID, int TestTypeID)
        {
            SqlConnection connection = new SqlConnection(clsSetting_DL.ConnectionString);
            SqlCommand command = new SqlCommand(clsQTestAppointment.IsPersonTakeTestBefore, connection);

            command.Parameters.AddWithValue("@LDLAPP_ID", LDLAPP_ID);
            command.Parameters.AddWithValue("@TestType", TestTypeID);

            object Result = null;
            try
            {
                connection.Open();

                Result = command.ExecuteScalar();

            }
            catch (Exception e)
            {

            }
            finally { connection.Close(); }



            return Result != null ? true : false;
        }

        public static bool FindAnyActiveAppointment(int LDLAPP_ID, int TestType)
        {
            SqlConnection connection = new SqlConnection(clsSetting_DL.ConnectionString);
            SqlCommand command = new SqlCommand(clsQTestAppointment.FindAnyActiveAppointment, connection);

            command.Parameters.AddWithValue("@LDLAPP_ID", LDLAPP_ID);
            command.Parameters.AddWithValue("@TestType", TestType);
            bool IsPersonHaveAnyActiveApp = true;

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                    IsPersonHaveAnyActiveApp = true;
                else
                    IsPersonHaveAnyActiveApp = false;

                reader.Close();


            }
            catch (Exception e) { }
            finally { connection.Close(); }

            return IsPersonHaveAnyActiveApp;

        }


        public static void GetTestAppointmentDetails(int LDLApplicationID, int TestType,
            ref string LicenseClassName, ref string FullName,
        ref int Trial, ref DateTime AppointmentDate, ref decimal TestFees)
        {

            SqlConnection connection = new SqlConnection(clsSetting_DL.ConnectionString);
            SqlCommand command;

            if (TestType != -1)
            {
                command = new SqlCommand(clsQTestAppointment.GetTestAppointmentDetails, connection);
                command.Parameters.AddWithValue("@TestType", TestType);
                command.Parameters.AddWithValue("@LDLAPP_ID", LDLApplicationID);

            }
            else
            {
                command = new SqlCommand(clsQTestAppointment.GetApplicationDetailsForNewAppointment, connection);
                command.Parameters.AddWithValue("@LDLAPP_ID", LDLApplicationID);
            }


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    LicenseClassName = (string)reader["ClassName"];
                    FullName = (string)reader["FullName"];
                    Trial = (int)reader["Trial"];
                    TestFees = (decimal)reader["Fees"];

                    if(TestType != -1)
                    AppointmentDate = (DateTime)reader["AppointmentDate"];
              
                }
                reader.Close();


            }
            catch (Exception e)
            {

            }
            finally { connection.Close(); }



        }

       

    }


}
