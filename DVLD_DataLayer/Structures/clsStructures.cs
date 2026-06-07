using DVLD_DataLayer.Application_Classes;
using System;
using System.ComponentModel;

namespace DVLD_DataLayer.Structures_DL
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


    public class clsLicense
    {

        private int _LicenseID;
        private int _LicenseClassID;
        private int _DriverID;
        private int _ApplicationID;
        private int _CreatedByUserID;
        private DateTime _IssueDate;
        private DateTime _ExpireDate;
        private string _Notes;
        private decimal _PaidFees;
        private bool _IsActive;
        private int _IssueReasonID;

        // Getters and Setters
        public int GetLicenseID() { return _LicenseID; }
        public void SetLicenseID(int value) { _LicenseID = value; }

        public int GetLicenseClassID() { return _LicenseClassID; }
        public void SetLicenseClassID(int value) { _LicenseClassID = value; }

        public int GetDriverID() { return _DriverID; }
        public void SetDriverID(int value) { _DriverID = value; }

        public int GetApplicationID() { return _ApplicationID; }
        public void SetApplicationID(int value) { _ApplicationID = value; }

        public int GetCreatedByUserID() { return _CreatedByUserID; }
        public void SetCreatedByUserID(int value) { _CreatedByUserID = value; }

        public DateTime GetIssueDate() { return _IssueDate; }
        public void SetIssueDate(DateTime value) { _IssueDate = value; }

        public DateTime GetExpireDate() { return _ExpireDate; }
        public void SetExpireDate(DateTime value) { _ExpireDate = value; }

        public string GetNotes() { return _Notes; }
        public void SetNotes(string value)
        {
            if (!string.IsNullOrWhiteSpace(value))
                _Notes = value;
            else
                _Notes = null;
        }

        public decimal GetPaidFees() { return _PaidFees; }
        public void SetPaidFees(decimal value) { _PaidFees = value; }

        public bool GetIsActive() { return _IsActive; }
        public void SetIsActive(bool value) { _IsActive = value; }

        public int GetIssueReasonID() { return _IssueReasonID; }
        public void SetIssueReasonID(int value) { _IssueReasonID = value; }

        public clsLicense()
        {
            this._LicenseID = -1;
            this._LicenseClassID = -1;
            this._DriverID = -1;
            this._ApplicationID = -1;
            this._CreatedByUserID = -1;
            this._Notes = "";
            this._PaidFees = 0;
            this._IsActive = false;
            this._IssueReasonID = -1;
            _IssueDate = DateTime.Now;



        }







    }

    public class clsDetainLicense
    {

        public int DetainID { get;internal set; }
        public DateTime DetainDate { get; set; }
        public decimal FineFees { get; set; }
        public bool IsReleased { get; set; }

        // Nullable fields
        public DateTime? ReleaseDate { get; set; }
        public int? ReleasedByUserID { get; set; }

        public int LicenseID { get; set; }
        public int CreatedByUserID { get; set; }
        public int? ReleaseApplicationID { get; set; }

        public clsDetainLicense()
        {
            DetainID = -1;                     // -1 commonly indicates a new, unsaved record
            DetainDate = DateTime.Now;         // Defaults to the current time of detention
            IsReleased = false;                // Freshly detained, so not yet released
            LicenseID = -1;
            this.FineFees = -1;
            CreatedByUserID = -1;

            // Nullable fields are explicitly set to null by default
            ReleaseDate = null;
            ReleasedByUserID = null;
            ReleaseApplicationID = null;

        }
        public clsDetainLicense(int License, decimal FineFees, int UserID)
        {
            DetainID = -1;                     // -1 commonly indicates a new, unsaved record
            DetainDate = DateTime.Now;         // Defaults to the current time of detention
            IsReleased = false;                // Freshly detained, so not yet released
            LicenseID = License;
            this.FineFees = FineFees;
            CreatedByUserID = UserID;

            // Nullable fields are explicitly set to null by default
            ReleaseDate = null;
            ReleasedByUserID = null;
            ReleaseApplicationID = null;


        }


    }

}
