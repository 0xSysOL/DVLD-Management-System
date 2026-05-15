using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataLayer.Tables.License_Class
{
    public class clsLicense_DL
    {










        public static void GetLicenseInfoByApplicationID(int ApplicationID, ref string ClassName, ref string FullName,
          ref int LicenseID, ref string NationalNo, ref string Gender, ref string Notes, ref string IsActive, ref DateTime IssueDate,
          ref DateTime ExpireDate, ref DateTime DateOfBirth, ref string IssueReason, ref int DriverID,ref string IsDetained)

        {
            SqlConnection connection = new SqlConnection(clsSetting_DL.ConnectionString);
            SqlCommand command = new SqlCommand(clsQ_License.GetLicenseInfo,connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

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
                    ApplicationID = -1;

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
