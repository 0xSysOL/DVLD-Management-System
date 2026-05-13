using System;
using System.Data.SqlClient;

namespace DVLD_DataLayer.Tables.Workflow
{
    public class clsWF_IssueFirstTimeLicense_DL
    {






        public static bool SaveNew_Driver_License_UPDAPP(
  ref int DriverID, int D_PersonID, int D_CreateByUserID, DateTime D_CreateDate,
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
                    // driver
                    command = new SqlCommand(clsQWFSave_DLAPP.AddDriver, connection, transaction);


                    // license 
                    command = new SqlCommand(clsQWFSave_DLAPP.IssueLicense, connection, transaction);


                    // application
                    command = new SqlCommand(clsQWFSave_DLAPP.ConvertApplicationToCompelated, connection, transaction);

                    transaction.Commit();
                }
                catch (Exception e)
                {
                    transaction.Rollback();
                    DriverID = -1;
                    L_LicenseID = -1;

                }
                finally { connection.Close(); }
            }


            return false;
        }




    }


}
