using DVLD_DataLayer.Application_Classes;
using DVLD_DataLayer.Tables.Application_Classes;
using System;
using System.Data.SqlClient;

namespace DVLD_DataLayer.Tables.Workflow
{
    public class clsWF_IssueInternationalLicense_DL
    {

        public class cls_APP_And_IL_Variables
        {
            public class Application
            {
                public int ApplicationID { get; internal set; }
                public DateTime ApplicationDate { get; set; }
                public decimal PaidFees { get; set; }
                public enum enApplicationType
                {
                    None,
                    LocalDrivingLicense = 1,
                    RenewDrivingLicense = 2,
                    ReplacementLost = 3,
                    ReplacementDamaged = 4,
                    ReleaseDetained = 5,
                    NewInternationalLicense = 6,
                    RetakeTest = 7
                }
                public int UserID { get; set; }
                public int PersonID { get; set; }
                public DateTime LastStateDate { get; set; }
                public enum eModeStatus { New = 1, Cancel = 2, Completed = 3, None = 0 };
                public eModeStatus modeStatus; public enApplicationType eAppTypeID;


                public Application(enApplicationType eAppTypeID,
                    int PersonID, int UserID, eModeStatus _modeStatus)
                {
                    this.ApplicationID = -1;
                    modeStatus = _modeStatus;
                    PaidFees = clsManageApplicationTypes_DL.GetFeesByID((int)eAppTypeID);
                    this.eAppTypeID = eAppTypeID;
                    this.UserID = UserID;
                    this.PersonID = PersonID;
                    this.LastStateDate = DateTime.Now;
                    this.ApplicationDate = DateTime.Now;


                }




            }

            public class InternationalLicense
            {
                public int InternationalLicenseID { get; internal set; }
                public int ApplicationID { get; set; }
                public int DriverID { get; set; }
                public int IssuedUsingLocalLicenseID { get; set; }
                public DateTime IssueDate { get; set; }
                public DateTime ExpirationDate { get; set; }
                public bool IsActive { get; set; }
                public int CreatedByUserID { get; set; }


                public InternationalLicense(int DriverID, int UserID, int DriverLicenseID)
                {

                    this.DriverID = DriverID;
                    this.IssuedUsingLocalLicenseID = DriverLicenseID;
                    this.CreatedByUserID = UserID;
                    this.InternationalLicenseID = -1; // In proce
                    this.ApplicationID = -1; // InProce

                    this.IssueDate = DateTime.Now;
                    // InternationalLicense licenses typically expire after 1 year
                    this.ExpirationDate = DateTime.Now.AddYears(1);
                    this.IsActive = true;

                }


            }


        }

        public static bool CreateIssueInternationalLicense(
            cls_APP_And_IL_Variables.Application ApplicationV,
            cls_APP_And_IL_Variables.InternationalLicense internationalV)
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
