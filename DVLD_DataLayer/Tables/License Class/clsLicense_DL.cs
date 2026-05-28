using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataLayer.Tables.License_Class
{
    public class clsLicense_DL
    {










        public static void GetLicenseInfo(int Value, ref string ClassName, ref string FullName,
          ref int LicenseID, ref string NationalNo, ref string Gender, ref string Notes,
          ref string IsActive, ref DateTime IssueDate,
          ref DateTime ExpireDate, ref DateTime DateOfBirth,
          ref string IssueReason, ref int DriverID, ref string IsDetained,
          string ParameterName)

        {
            SqlConnection connection = new SqlConnection(clsSetting_DL.ConnectionString);

            SqlCommand command = new SqlCommand(clsQ_License.GetLicenseInfo, connection);

            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@Value", Value);
            command.Parameters.AddWithValue("@ParameterName", ParameterName);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    // Keeping the [] indexer format and converting to string/types
                    ClassName = reader["ClassName"].ToString();
                    FullName = reader["FullName"].ToString();
                    LicenseID = (int)reader["LicenseID"];
                    NationalNo = reader["NationalNo"].ToString();
                    Gender = reader["Gender"].ToString();

                    // Handling potential NULLs for Notes
                    Notes = reader["Notes"] != DBNull.Value ? reader["Notes"].ToString() : "";

                    IsActive = reader["IsActive"].ToString(); // Usually "True"/"False" or "1"/"0"
                    IssueDate = (DateTime)reader["IssueDate"];
                    ExpireDate = (DateTime)reader["ExpireDate"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    IssueReason = reader["IssueReason"].ToString();
                    DriverID = (int)reader["DriverID"];
                    IsDetained = reader["IsDetained"].ToString();


                }
                else
                    Value = -1;

                reader.Close();
            }
            catch (Exception e)
            {

            }
            finally
            {
                connection.Close();
            }




        }

        public static DataTable GetAllPersonLocalLicense(int DriverID)
        {
            SqlConnection connection = new SqlConnection(clsSetting_DL.ConnectionString);
            SqlCommand command = new SqlCommand(clsQ_License.GetAllPersonLocalLicenseByDriverID, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@DriverID", DriverID);
            DataTable data = new DataTable();
            try
            {
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    data.Load(reader);
                }



            }
            catch (Exception e)
            {

            }
            finally
            {
                connection.Close();
            }





            return data;


        }
        public static DataTable GetAllPersonInternationalLicense(int DriverID = -1)
        {
            SqlConnection connection = new SqlConnection(clsSetting_DL.ConnectionString);
            SqlCommand command = new SqlCommand(clsQ_License.GetAllPersonInternationalLicenseByDriver, connection);
            command.CommandType = CommandType.StoredProcedure;

            if (DriverID != -1)
                command.Parameters.AddWithValue("@DriverID", DriverID);


            DataTable data = new DataTable();
            try
            {
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    data.Load(reader);
                }



            }
            catch (Exception e)
            {

            }
            finally
            {
                connection.Close();
            }





            return data;

        }
        public static bool IsLicenseActive(int LicenseID)
        {

            SqlConnection connection = new SqlConnection(clsSetting_DL.ConnectionString);
            SqlCommand command = new SqlCommand(clsQ_License.IsLicenseActive, connection);
            command.Parameters.AddWithValue("@Value", LicenseID);
            object IsActive = null;
            try
            {
                connection.Open();

                IsActive = command.ExecuteScalar();

            }
            catch (Exception e)
            {

            }
            finally
            {
                connection.Close();
            }




            return IsActive == null ? false : (bool)IsActive;
        }
        public static DateTime GetLicenseExpireDate(int LicenseID)
        {
            SqlConnection connection = new SqlConnection(clsSetting_DL.ConnectionString);
            SqlCommand command = new SqlCommand(clsQ_License.GetExpireDate, connection);
            command.Parameters.AddWithValue("@Value", LicenseID);
            object ExpireDate = null;
            try
            {
                connection.Open();

                ExpireDate = command.ExecuteScalar();

            }
            catch (Exception e)
            {

            }
            finally
            {
                connection.Close();
            }





            return (DateTime)ExpireDate;
        }



        public static void GetInternationalLicenseByApplication(int ApplicationID,
            ref string FullName,
            ref int InternationalLicenseID,
            ref int LicenseID,
            ref string NationalNo,
            ref string Gendor,
            ref DateTime IssueDate,
            ref string IsActive,
            ref DateTime DateOfBirth,
            ref int DriverID,
            ref DateTime ExpirationDate,
            ref string ImagePath)
        {
            SqlConnection connection = new SqlConnection(clsSetting_DL.ConnectionString);
            SqlCommand command = new SqlCommand(clsQ_InternationalLicense.GetIntLicenseInfo, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    // Keeping the [] indexer format and converting to string/types
                    FullName = reader["FullName"].ToString();
                    InternationalLicenseID = (int)reader["InternationalLicenseID"];
                    LicenseID = (int)reader["LicenseID"];
                    NationalNo = reader["NationalNo"].ToString();
                    Gendor = reader["Gendor"].ToString();

                    IsActive = reader["IsActive"].ToString(); // Usually "True"/"False" or "1"/"0"
                    IssueDate = (DateTime)reader["IssueDate"];
                    ExpirationDate = (DateTime)reader["ExpirationDate"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    DriverID = (int)reader["DriverID"];
                    ImagePath = (string)reader["ImagePath"];

                }
               
                reader.Close();
            }
            catch (Exception e)
            {

            }
            finally
            {
                connection.Close();
            }




        }

    }
}
