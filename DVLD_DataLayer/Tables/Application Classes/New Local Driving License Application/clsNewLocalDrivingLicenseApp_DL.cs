using System;
using System.Data.SqlClient;

namespace DVLD_DataLayer.Tables.Application_Classes.New_Local_Driving_License_Application
{
    public class clsNewLocalDrivingLicenseApp_DL
    {



        public static int Add_Application_And_LDLAPP(ref int ApplicationID, int LicenseClassID,
            byte ApplicationState, int ApplicationTypeID, decimal PaidFees,
                        int UserID, int PersonID, DateTime ApplicationDate, DateTime LastStateDate)
        {
            object Result = null;
            int LocalApplicationID = -1;
            using (SqlConnection connection = new SqlConnection(clsSetting_DL.ConnectionString))
            {
                connection.Open();

                SqlTransaction transaction = connection.BeginTransaction();


                try
                {

                    LocalApplicationID = clsApplication_DL.CreateApplicationUnderProce(ApplicationDate,
                                     ApplicationState, PaidFees, ApplicationTypeID, UserID, PersonID,
                                     LastStateDate, connection, ref transaction);

                    if (LocalApplicationID == -1)
                        return -1;

                    //command.Transaction = transaction;

                    //command.CommandText = clsQApplication.AddApplication;
                    ////new SqlCommand(clsQApplication.AddApplication, connection)
                    //command.Parameters.AddWithValue("@Date", ApplicationDate);
                    //command.Parameters.AddWithValue("@State", ApplicationState);
                    //command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
                    //command.Parameters.AddWithValue("@PaidFees", PaidFees);
                    //command.Parameters.AddWithValue("@PersonID", PersonID);
                    //command.Parameters.AddWithValue("@UserID", UserID);
                    //command.Parameters.AddWithValue("@LastStateDate", LastStateDate);

                    //LocalApplicationID = Convert.ToInt32(command.ExecuteScalar());
                    SqlCommand command = new SqlCommand(clsQLocalDrivingLicenseApp.AddNew_LDLA, connection, transaction);


                    command.Parameters.AddWithValue("@ApplicationID", LocalApplicationID);
                    command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

                    Result = command.ExecuteScalar();


                    transaction.Commit();
                    ApplicationID = (LocalApplicationID != -1) ? LocalApplicationID : -1;

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

            // this Will return Local Driving License ID
            return (Result != null) ? Convert.ToInt32(Result) : -1;

        }

        public static bool Update_Application_LDLA(int ID, int LicenseClassID, int ApplicationID, DateTime LastDateUpdate)
        {


            int Result = -1;
            SqlTransaction transaction = null;
            SqlCommand command = new SqlCommand();
            using (SqlConnection connection = new SqlConnection(clsSetting_DL.ConnectionString))
            {

                try
                {
                    connection.Open();
                    transaction = connection.BeginTransaction();

                    command = connection.CreateCommand();

                    command.Transaction = transaction;

                    command.CommandText = clsQLocalDrivingLicenseApp.Update_LDLA;
                    command.Parameters.AddWithValue("@LC_ID", LicenseClassID);
                    command.Parameters.AddWithValue("@ID", ID);

                    Result = command.ExecuteNonQuery();
                    Result = -1;
                    command.Parameters.Clear();

                    command.CommandText = clsQApplication.UpdateApplication;

                    command.Parameters.AddWithValue("@LastDateApplication", LastDateUpdate);
                    command.Parameters.AddWithValue("@ID", ApplicationID);

                    Result = command.ExecuteNonQuery();


                    transaction.Commit();
                }
                catch (Exception e)
                {
                    transaction.Rollback();
                }


            }


            return Result != -1 ? true : false;

        }

        public static bool Get_LDLA_ByApplicationID(int ApplicationID, ref int LDLA_ID,
            ref int LicenseClassID)
        {

            SqlConnection connection = new SqlConnection(clsSetting_DL.ConnectionString);
            SqlCommand command = new SqlCommand(clsQLocalDrivingLicenseApp.Get_LDLA, connection);
            command.Parameters.AddWithValue("@Value", ApplicationID);
            bool IsSuccess = false;
            try
            {
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {

                    if (reader.Read())
                    {
                        LDLA_ID = (int)reader[0];
                        LicenseClassID = (int)reader["LicenseClassID"];
                        IsSuccess = true;
                    }
                }



            }
            catch (Exception e) { }
            finally { connection.Close(); }

            return IsSuccess;
        }

        public static void GetDrivingLicenseInfo(int LDLAPP_ID, ref string LicenseName, ref int PassedTests)
        {
            SqlConnection connection = new SqlConnection(clsSetting_DL.ConnectionString);
            SqlCommand command = new SqlCommand(clsQLocalDrivingLicenseApp.GetDrivingLicenseApplication, connection);

            command.Parameters.AddWithValue("LDLAPP_ID", LDLAPP_ID);

            try
            {
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        LicenseName = (string)reader["ClassName"];
                        object Ob_PassedTest = (object)reader["PassedTest"];
                        PassedTests = Ob_PassedTest != DBNull.Value ? Convert.ToInt32(Ob_PassedTest) : Convert.ToInt32(0);

                    }

                }

            }
            catch (Exception e) { }
            finally
            {
                connection.Close();
            }

        }

        public static void GetLocalDrivingLicense(int LDLAPP_ID, ref int LicenseID, ref int PersonID)
        {


        }



    }
}
