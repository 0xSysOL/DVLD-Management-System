using DVLD_DataLayer.Application_Classes;
using DVLD_DataLayer.Tables.Application_Classes;
using System;
using System.Data.SqlClient;

namespace DVLD_DataLayer.Tables.Workflow
{
    public class clsWF_IssueInternationalLicense_DL
    {

        
        public static bool CreateIssueInternationalLicense(
            Structures_DL.Application ApplicationV,
            Structures_DL.InternationalLicense internationalV)
        {

            using (SqlConnection connection = new SqlConnection(clsSetting_DL.ConnectionString))
            {
                SqlTransaction transaction = null;


                ApplicationV.ApplicationID = clsApplication_DL.CreateApplicationUnderProce(
                        ApplicationV.ApplicationDate, (byte)ApplicationV.modeStatus,
                        ApplicationV.PaidFees, (int)ApplicationV.eAppTypeID, ApplicationV.UserID,
                        ApplicationV.PersonID, ApplicationV.LastStateDate, connection, ref transaction);

                try
                {
                    // Here We Will Issue InternationalLicense license
                    SqlCommand command = new SqlCommand(clsQ_InternationalLicense.AddNewInternationalLicense
                        , connection, transaction);

                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@ApplicationID", ApplicationV.ApplicationID);
                    command.Parameters.AddWithValue("@DriverID", internationalV.DriverID);
                    command.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", internationalV.IssuedUsingLocalLicenseID);
                    command.Parameters.AddWithValue("@IssueDate", internationalV.IssueDate);
                    command.Parameters.AddWithValue("@ExpirationDate", internationalV.ExpirationDate);
                    command.Parameters.AddWithValue("@IsActive", internationalV.IsActive);
                    command.Parameters.AddWithValue("@CreatedByUserID", internationalV.CreatedByUserID);

                    internationalV.InternationalLicenseID = Convert.ToInt32(command.ExecuteScalar());


                    transaction.Commit();

                }
                catch (Exception e)
                {
                    transaction.Rollback();
                    internationalV.InternationalLicenseID = -1;
                }
                finally
                {
                    connection.Close();
                }


            }





            return internationalV.InternationalLicenseID != -1 ? true : false;

        }




    }












}
