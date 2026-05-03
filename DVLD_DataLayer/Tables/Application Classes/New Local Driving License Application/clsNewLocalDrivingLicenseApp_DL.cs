using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_DataLayer.Tables.Application_Classes.New_Local_Driving_License_Application
{
    public class clsNewLocalDrivingLicenseApp_DL
    { 



        public static int AddNew_LDLA(ref int ID, int ApplicationID, int LicenseClassID)
        {
            SqlConnection connection = new SqlConnection(clsSetting_DL.ConnectionString);
            SqlCommand command = new SqlCommand(clsQLocalDrivingLicenseApp.AddNew_LDLA,connection);
            object Result = null;
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);


            try
            {
                connection.Open();

                Result = command.ExecuteScalar();
              
            }
            catch(Exception e) { }
            finally
            {
                connection.Close();
            }

            ID = (Result == null) ? -1 : Convert.ToInt32(Result);

            return ID;


        }

        public static bool Update_LDLA(int ID,int LicenseClassID)
        {

            SqlConnection connection = new SqlConnection(clsSetting_DL.ConnectionString);
            SqlCommand command = new SqlCommand(clsQLocalDrivingLicenseApp.Update_LDLA, connection);
            int Result  = -1;

            command.Parameters.AddWithValue("@LC_ID", LicenseClassID);
            command.Parameters.AddWithValue("@ID", ID);


            try
            {
                connection.Open();

                 Result = command.ExecuteNonQuery();
            }
            catch (Exception e) { }
            finally
            {
                connection.Close();
            }

            


            return Result != -1 ? true : false;

        }

        public static void Get_LDLA_ByApplicationID(int ApplicationID, int LDLA_ID, 
            int Base_ApplicationID, int LicenseClassID)
        {
            SqlConnection connection = new SqlConnection(clsSetting_DL.ConnectionString);
            SqlCommand command = new SqlCommand(clsQLocalDrivingLicenseApp.Get_LDLA, connection);
            command.Parameters.AddWithValue("@Value", ApplicationID);

            try
            {
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                   
                    if (reader.Read())
                    {
                        LDLA_ID = (int)reader[0];
                        Base_ApplicationID = (int)reader["ApplicationID"];
                        LicenseClassID = (int)reader["LicenseClassID"];
                    }
                }

                

            }
            catch(Exception e) { } finally { connection.Close(); }


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



    }
}
