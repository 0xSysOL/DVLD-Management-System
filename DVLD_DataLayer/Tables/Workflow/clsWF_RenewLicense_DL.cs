using DVLD_DataLayer.Structures_DL;
using DVLD_DataLayer.Tables.Application_Classes;
using DVLD_DataLayer.Tables.License_Class;
using System;
using System.Data.SqlClient;

namespace DVLD_DataLayer.Tables.Workflow
{
    public class clsWF_RenewLicense_DL
    {

        public static bool CreateIssueInternationalLicense(
            Structures_DL.Application ApplicationV,
            Structures_DL.InternationalLicense internationalV)
        {

            using (SqlConnection connection = new SqlConnection(clsSetting_DL.ConnectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();


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





        public static bool IssueLicenseForLostOrRenewOrDamage(
            Application Application,
            clsLicense License,
            int OldLicense
            )
        {

            using (SqlConnection connection = new SqlConnection(clsSetting_DL.ConnectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {

                    Application.ApplicationID = clsApplication_DL.CreateApplicationUnderProce(
                       Application.ApplicationDate, (byte)Application.modeStatus,
                       Application.PaidFees, (int)Application.eAppTypeID, Application.UserID,
                       Application.PersonID, Application.LastStateDate, connection, ref transaction);

                    if (Application.ApplicationID == -1)
                        throw new Exception();

                    License.SetApplicationID(Application.ApplicationID);

                    if (clsLicense_DL.IssueLicenseUnderProce(License, connection,ref transaction) == -1)
                        throw new Exception();

                    if (!clsLicense_DL.ChangeActiveStatusForLicense(OldLicense,clsLicense_DL.LicenseStatus.UnActive,connection, transaction))
                        throw new Exception();
                    
                    transaction.Commit();
                    return true;
                }
                catch (Exception e)
                {
                    transaction.Rollback();
                    Application.ApplicationID = -1;
                    License.SetLicenseID(-1);
                    return false;
                }
              


            }





            


        }


    }


}
