using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataLayer.Tables.Application_Classes
{
    public class clsApplication_DL
    {




        public static int AddNewApplication(byte ApplicationState, int ApplicationTypeID, decimal PaidFees,
                        int UserID, int PersonID, DateTime ApplicationDate, DateTime LastStateDate)
        {
            SqlConnection connection = new SqlConnection(clsSetting_DL.ConnectionString);
            SqlCommand command = new SqlCommand(clsQApplication.AddApplication, connection);
            object Result = null;

            command.Parameters.AddWithValue("@Date", ApplicationDate);
            command.Parameters.AddWithValue("@State", ApplicationState);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@LastStateDate", LastStateDate);


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

        public static bool UpdateApplication(int ID, DateTime LastStateDate, decimal PaidFees, int UserID)
        {
            SqlConnection connection = new SqlConnection(clsSetting_DL.ConnectionString);
            SqlCommand command = new SqlCommand(clsQApplication.UpdateApplication, connection);

            command.Parameters.AddWithValue("@LastDateApplication", LastStateDate);
            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@ID", ID);
            int Result = -1;

            try
            {
                connection.Open();

                Result = command.ExecuteNonQuery();


            }
            catch (Exception e)
            {

            }
            finally
            {
                connection.Close();
            }

            return Result > 0 ? true : false;
        }


        public static bool IsApplicationNew(int PersonID, int LicenseClassID)
        {
            SqlConnection connection = new SqlConnection(clsSetting_DL.ConnectionString);
            SqlCommand command = new SqlCommand(clsQApplication.IsApplicationNew, connection);

            command.Parameters.AddWithValue("PersonID", PersonID);
            command.Parameters.AddWithValue("LC_ID", LicenseClassID);
            object State = null;

            try
            {
                connection.Open();

                State = command.ExecuteScalar();


            }
            catch (Exception e)
            { }
            finally
            {
                connection.Close();
            }

            return (State != null) ? true : false;

        }
        public static bool IsApplicationCompleted(int PersonID, int LicenseClassID)
        {
            SqlConnection connection = new SqlConnection(clsSetting_DL.ConnectionString);
            SqlCommand command = new SqlCommand(clsQApplication.IsApplicationCompleted, connection);

            command.Parameters.AddWithValue("PersonID", PersonID);
            command.Parameters.AddWithValue("LC_ID", LicenseClassID);
            object State = null;

            try
            {
                connection.Open();

                State = command.ExecuteScalar();




            }
            catch (Exception e)
            { }
            finally
            {
                connection.Close();
            }

            return (State != null) ? true : false;

        }



        public static DataTable GetAllApplications()
        {
            SqlConnection connection = new SqlConnection(clsSetting_DL.ConnectionString);
            SqlCommand command = new SqlCommand(clsQApplication.GetAllApplications, connection);
            DataTable data = new DataTable();

            try
            {
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                    data.Load(reader);

            }
            catch (Exception e)
            {

            }
            finally { connection.Close(); }



            return data;
        }
        public static void GetApplicationByID(
            int ApplicationID,
           ref DateTime ApplicationDate,
           ref byte ApplicationState,
           ref decimal PaidFees,
           ref int ApplicationTypeID,
           ref int UserID,
           ref int PersonID,
           ref DateTime LastStateDate
            )
        {
            SqlConnection connection = new SqlConnection(clsSetting_DL.ConnectionString);
            SqlCommand command = new SqlCommand(clsQApplication.GetApplicationByID, connection);
            command.Parameters.AddWithValue("@Value", ApplicationID);


            try
            {
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        ApplicationDate = (DateTime)reader["ApplicationDate"];
                        ApplicationState = (byte)reader["ApplicationState"];
                        PaidFees = (decimal)reader["PaidFees"];
                        ApplicationTypeID = (int)reader["ApplicationTypeID"];
                        UserID = (int)reader["UserID"];
                        PersonID = (int)reader["ApplicationPersonID"];
                        LastStateDate = (DateTime)reader["LastDateApplication"];
                    }
                    else
                        ApplicationID = -1;

                }

            }
            catch (Exception e)
            {
            }
            finally { connection.Close(); }

        }
        public static DataTable GetAllApplications_WithFilter(object Value, string ColumnName)
        {

            string Q_GetAllApplications_WithFilter = clsQApplication.GetAllApplications_WithFilter;
            Q_GetAllApplications_WithFilter = Q_GetAllApplications_WithFilter.Replace("@ColumnName", ColumnName);

            SqlConnection connection = new SqlConnection(clsSetting_DL.ConnectionString);
            SqlCommand command = new SqlCommand(Q_GetAllApplications_WithFilter, connection);
            DataTable data = new DataTable();

            command.Parameters.AddWithValue("@Value", Value);


            try
            {
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                    data.Load(reader);

            }
            catch (Exception e)
            {

            }
            finally { connection.Close(); }



            return data;

        }

        public static bool IsPersonHaveAnyTestsActive(int LDLA_AppID)
        {
            SqlConnection connection = new SqlConnection(clsSetting_DL.ConnectionString);
            SqlCommand command = new SqlCommand(clsQApplication.GetTestAppointmentResult, connection);
            command.Parameters.AddWithValue("@LDLAPPID", LDLA_AppID);

            object Result = null;

            try
            {
                connection.Open();

                Result = command.ExecuteScalar();

            }
            catch (Exception e)
            {

            }
            finally
            {
                connection.Close();
            }


            return (Result != null && Result != DBNull.Value);

        }

        public static bool IsPersonHaveAnyTests(int LDLA_AppID)
        {
            SqlConnection connection = new SqlConnection(clsSetting_DL.ConnectionString);
            SqlCommand command = new SqlCommand(clsQApplication.IsAnyTestsFoundBy_LDLA_ID, connection);
            object Result = null;

            command.Parameters.AddWithValue("@Value", LDLA_AppID);
            try
            {
                connection.Open();

                Result = command.ExecuteScalar();


            }
            catch (Exception e)
            {
            }
            finally
            {
                connection.Close();
            }

            return (Result != null && Result != DBNull.Value);
        }

        public static bool CancelApplicationState(int ApplicationID)
        {
            SqlConnection connection = new SqlConnection(clsSetting_DL.ConnectionString);
            SqlCommand command = new SqlCommand(clsQApplication.CancelApplication, connection);

            command.Parameters.AddWithValue("@Value", ApplicationID);
            int Result = -1;

            try
            {
                connection.Open();

                Result = command.ExecuteNonQuery();

            }
            catch (Exception e)
            {

            }
            finally
            {
                connection.Close();
            }

            return Result != -1 ? true : false;

        }


        public static bool DeleteApplication(int LDLA_AppID)
        {
            object FinalResult = null;
            int ApplicationID = -1;

            using (SqlConnection connection = new SqlConnection(clsSetting_DL.ConnectionString))
            {
                SqlCommand command = new SqlCommand();
                connection.Open();

                command = new SqlCommand(clsQLocalDrivingLicenseApp.GetApplicationID, connection);
                command.Parameters.AddWithValue("@Value", LDLA_AppID);
                ApplicationID = Convert.ToInt32(command.ExecuteScalar());
                SqlTransaction transaction = connection.BeginTransaction();


                try
                {






                    command = new SqlCommand(clsQLocalDrivingLicenseApp.Delete_LDLAPPBy_ID, connection, transaction);
                    command.Parameters.AddWithValue("@Value", LDLA_AppID);
                    int Result = -1;

                    Result = command.ExecuteNonQuery();

                    command = new SqlCommand(clsQApplication.Delete_Application, connection, transaction);
                    command.Parameters.AddWithValue("@Value", ApplicationID);


                    FinalResult = command.ExecuteNonQuery();
                    transaction.Commit();





                }
                catch (Exception e)
                {
                    transaction.Rollback();
                }
                finally
                {
                    connection.Close();
                }


            }

            return (FinalResult != null && FinalResult != DBNull.Value) ? true : false;
        }

        public static int GetApplicationIDBy_LDLA_APPID(int LDLA_AppID)
        {
            SqlConnection connection = new SqlConnection(clsSetting_DL.ConnectionString);
            SqlCommand command = new SqlCommand(clsQApplication.GetApplicationID_By_LDLAID, connection);
            command.Parameters.AddWithValue("@Value", LDLA_AppID);

            int ApplicationID = -1;

            try
            {
                connection.Open();

                ApplicationID = Convert.ToInt32(command.ExecuteScalar());

            }
            catch (Exception e)
            {
            }
            finally { connection.Close(); }
            return ApplicationID;


        }


        public static void GetApplicationBasicInfo(int LDLAPP_ID,ref string ApplicationStatus, ref int ApplicationID, ref decimal ApplicationFees,
         ref string ApplicationTypeTitle, ref string FullName,
         ref DateTime ApplicationDate, ref DateTime ApplicationDateStatus,
         ref string Username)
        {
            SqlConnection connection = new SqlConnection(clsSetting_DL.ConnectionString);
            SqlCommand command = new SqlCommand(clsQApplication.GetApplicationBasicInfo, connection);

            command.Parameters.AddWithValue("@LDLAPP_ID", LDLAPP_ID);

            try
            {
                connection.Open();

                using(SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows && reader.Read())
                    {
                        ApplicationID = (int)reader["ApplicationID"];
                        ApplicationStatus = (string)reader["ApplicationStatusName"];
                        ApplicationFees = (decimal)reader["ApplicationFees"];
                        ApplicationTypeTitle = (string)reader["ApplicationTypeTitle"];
                        FullName = (string)reader["FullName"];
                        ApplicationDate = (DateTime)reader["ApplicationDate"];
                        ApplicationDateStatus = (DateTime)reader["LastDateApplication"];
                        Username = (string)reader["UserName"];
                    }
                }

            }
            catch(Exception e) { }
            finally { connection.Close(); }

        }


        public static bool FindAnyActiveAppointment(int LDLAPP_ID, int TestType)
        {
            SqlConnection connection = new SqlConnection(clsSetting_DL.ConnectionString);
            SqlCommand command = new SqlCommand(clsQApplication.FindAnyActiveAppointment,connection);

            command.Parameters.AddWithValue("@LDLAPP_ID",LDLAPP_ID);
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
            catch(Exception e) { }
            finally { connection.Close(); }

            return IsPersonHaveAnyActiveApp;

        }


        public static bool IsPersonPassedTest(int LDLAPP_ID, int TestType)
        {
            SqlConnection connection = new SqlConnection(clsSetting_DL.ConnectionString);
            SqlCommand command = new SqlCommand(clsQTestAppointment.IsPersonPassedTest, connection);

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






















    }
}
