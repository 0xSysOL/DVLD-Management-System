using System.Data.SqlClient;
using System;
using DVLD_DataLayer.Tables.Application_Classes;
namespace DVLD_DataLayer.Tables.Workflow
{
    public class clsWF_ReleaseDetain_DL
    {




        public static bool ReleaseDetain(int DetainID, Structures_DL.clsDetainLicense OB_Detain,
            Structures_DL.Application OB_Application)
        {
            bool IsReleased = false;
            using (SqlConnection connection = new SqlConnection(clsSetting_DL.ConnectionString))
            {

                SqlTransaction transaction = null;
                try
                {
                    connection.Open();
                    transaction = connection.BeginTransaction();

                    OB_Detain.ReleaseApplicationID = clsApplication_DL.CreateApplicationUnderProce(OB_Application.ApplicationDate,
                      (byte)OB_Application.modeStatus,
                      OB_Application.PaidFees,(int)OB_Application.eAppTypeID,
                      OB_Application.UserID, OB_Application.PersonID, OB_Application.LastStateDate,
                      connection,ref transaction);

                    if(OB_Detain.ReleaseApplicationID == -1)
                        throw new Exception();

                    SqlCommand command = new SqlCommand(clsQ_Detained.ReleaseDetain, connection,transaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@DetainID", DetainID);
                    command.Parameters.AddWithValue("@ReleaseDate", DateTime.Now);
                    command.Parameters.AddWithValue("@ReleasedByUserID", OB_Detain.ReleasedByUserID);
                    command.Parameters.AddWithValue("@ReleaseApplicationID", OB_Detain.ReleaseApplicationID);
                    command.Parameters.AddWithValue("@IsReleased", true);

                    IsReleased = command.ExecuteNonQuery() > 0;
                    if (IsReleased == false)
                        throw new Exception();

                    transaction.Commit();
                   OB_Detain.DetainID = DetainID;
                }
                catch (Exception e)
                {
                    if(transaction != null)
                    transaction.Rollback();

                }

            }





            return IsReleased;
        }

    }


}
