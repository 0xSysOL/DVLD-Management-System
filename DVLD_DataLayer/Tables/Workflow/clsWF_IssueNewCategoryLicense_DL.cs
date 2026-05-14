using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataLayer.Tables.Workflow
{
    public class clsWF_IssueNewCategoryLicense_DL
    {


        public static bool Save_NewLicenseAndUpAPP(
   int DriverID, int D_PersonID, int D_CreateByUserID, DateTime D_CreateDate,
   ref int L_LicenseID, int L_LicenseClassID, int L_ApplicationID,
    DateTime L_IssueDate, DateTime L_ExpireDate, string L_Notes, decimal L_PaidFees,
    bool L_IsActive, int L_IssueReasonID
)
        {

            SqlCommand command;

            using (SqlConnection connection = new SqlConnection(clsSetting_DL.ConnectionString))
            {
                connection.Open();

                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                 

                    // license 
                    command = new SqlCommand(clsQWFSave_DLAPP.IssueLicense, connection, transaction);

                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@LicenseClassID", L_LicenseClassID);
                    command.Parameters.AddWithValue("@DriverID", DriverID);
                    command.Parameters.AddWithValue("@ApplicationID", L_ApplicationID);
                    command.Parameters.AddWithValue("@CreateByUserID", D_CreateByUserID);
                    command.Parameters.AddWithValue("@IssueDate", L_IssueDate);
                    command.Parameters.AddWithValue("@ExpireDate", L_ExpireDate);
                    command.Parameters.AddWithValue("@PaidFees", L_PaidFees);
                    command.Parameters.AddWithValue("@IsActive", L_IsActive);
                    command.Parameters.AddWithValue("@IssueReasonID", L_IssueReasonID);
                    if (L_Notes != null)
                        command.Parameters.AddWithValue("@Notes", L_Notes);
                    else
                        command.Parameters.AddWithValue("@Notes", DBNull.Value);

                    L_LicenseID = Convert.ToInt32(command.ExecuteScalar());

                    // application
                    command = new SqlCommand(clsQWFSave_DLAPP.ConvertApplicationToCompleted, connection, transaction);
                    command.Parameters.AddWithValue("@Value", L_ApplicationID);

                    command.ExecuteNonQuery();

                    transaction.Commit();
                    return true;
                }
                catch (Exception e)
                {
                    transaction.Rollback();
                    DriverID = -1;
                    L_LicenseID = -1;

                }
                finally
                { connection.Close(); }

            }


            return false;
        }



    }




}
