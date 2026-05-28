using DVLD_DataLayer.Application_Classes;
using System;

namespace DVLD_DataLayer.Structures_DL
{


    public class Application
    {
        public int ApplicationID { get; internal set; }
        public DateTime ApplicationDate { get; set; }
        public decimal PaidFees { get; set; }
        public  enum enApplicationType
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
        public eModeStatus modeStatus;
        public enApplicationType eAppTypeID;

        public Application()
        {
            ApplicationID = -1;
            ApplicationDate = DateTime.Now;
            PaidFees = -1;
            UserID = -1;
            PersonID = -1;
            LastStateDate = DateTime.Now;
            modeStatus = eModeStatus.None;
            eAppTypeID = enApplicationType.None;


        }
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
