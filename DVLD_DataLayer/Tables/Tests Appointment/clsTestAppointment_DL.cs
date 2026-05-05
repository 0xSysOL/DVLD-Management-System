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

            command = new SqlCommand(clsQTestAppointment.GetTestAppointmentDetails, connection);


            command.Parameters.AddWithValue("@TestType", TestType);
            command.Parameters.AddWithValue("@LDLAPP_ID", LDLApplicationID);


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

              

                }
                reader.Close();


            }
            catch (Exception e)
            {

            }
            finally { connection.Close(); }



        }

        public static void GetApplicationDetailsForNewAppointment(int LDLApplicationID, int TestType,
          ref string LicenseClassName, ref string FullName,
         ref int Trial, ref DateTime AppointmentDate, ref decimal TestFees)
        {

            SqlConnection connection = new SqlConnection(clsSetting_DL.ConnectionString);
            SqlCommand command;


            command = new SqlCommand(clsQTestAppointment.GetApplicationDetailsForNewAppointment, connection);


            command.Parameters.AddWithValue("@TestType", TestType);
            command.Parameters.AddWithValue("@LDLAPP_ID", LDLApplicationID);


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
                    
                }
                reader.Close();


            }
            catch (Exception e)
            {

            }
            finally { connection.Close(); }


        }




        public static int Add_TestAppointment(int LDLApplicationID, int TestTypeID,
            DateTime AppointmentDate, decimal PaidFees, int CreateByUserID, object RetakeTeApp = null)
        {

            SqlConnection connection = new SqlConnection(clsSetting_DL.ConnectionString);
            SqlCommand command = new SqlCommand(clsQTestAppointment.Add_Appointment, connection);
            command.CommandType = CommandType.StoredProcedure;
            object Result = null;
            /*(@AppointmentDate,0,@PaidFees,@CreateByUserID,@TestTypeID,
@LDLAPP_ID,@RetakeTAPP_ID)*/

            command.Parameters.AddWithValue("@LDLAPP_ID", LDLApplicationID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@CreateByUserID", CreateByUserID);

            command.Parameters.AddWithValue("@RetakeTAPP_ID", (RetakeTeApp == null) ? DBNull.Value : RetakeTeApp);


            try
            {
                connection.Open();

                Result = command.ExecuteScalar();

            }
            catch (Exception e)
            {

            }
            finally { connection.Close(); }



            return Convert.ToInt32(Result);

        }

        public static bool Update_TestAppointment(int AppointmentID,ref DateTime AppointmentDate)
        {

            SqlConnection connection = new SqlConnection(clsSetting_DL.ConnectionString);
            SqlCommand command = new SqlCommand(clsQTestAppointment.Update_Appointment, connection);

            command.Parameters.AddWithValue("@AppointmentID", AppointmentID);
            command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            
            int EvRow = -1;

            try
            {
                connection.Open();
                EvRow = command.ExecuteNonQuery();


            }
            catch (Exception e)
            {

            }
            finally { connection.Close(); }



            return EvRow > 0?true:false;
        }



        public static void FillClass(int AppointmentID, ref int LDLApplicationID, ref int testTypeID, ref DateTime appointmentDate,
           ref decimal paidFees, ref int createByUserID, ref object retakeTeApp)
        {

            SqlConnection connection = new SqlConnection(clsSetting_DL.ConnectionString);
            SqlCommand command = new SqlCommand(clsQTestAppointment.GetAppointmentByID, connection);

            command.Parameters.AddWithValue("@AppointmentID", AppointmentID);
            
            try
            {
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {

                        AppointmentID = (int)reader["AppointmentID"];

                        LDLApplicationID = (int)reader["LocalDrivingLicenseApplicationID"];
                        testTypeID = (int)reader["TestTypeID"];
                        appointmentDate = (DateTime)reader["AppointmentDate"];
                        paidFees = (decimal)reader["PaidFees"];
                        createByUserID = (int)reader["CreateByUserID"];

                        if (reader["RetakeTestApplicationID"] != DBNull.Value)
                        {
                            retakeTeApp = reader["RetakeTestApplicationID"];
                        }
                        else
                        {
                            retakeTeApp = null;
                        }


                    }
                      


                }

            }
            catch (Exception e)
            {

            }
            finally { connection.Close(); }


        }









    }


}
