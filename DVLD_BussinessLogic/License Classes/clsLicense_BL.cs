using DVLD_DataLayer.Tables.License_Class;
using System;
using System.Data;

namespace DVLD_BussinessLogic.License_Classes
{
    public class clsLicense_BL
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

        public clsLicense_BL()
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

        }
        public clsLicense_BL(int LicenseID) : this()
        {


        }
        public static void GetLicenseInfo(int Value, ref string ClassName, ref string FullName,
            ref int LicenseID, ref string NationalNo, ref string Gender, ref string Notes, ref string IsActive, ref DateTime IssueDate,
            ref DateTime ExpireDate, ref DateTime DateOfBirth, ref string IssueReason, ref int DriverID, ref string IsDetained,
            ref string ImagePath,string ParameterName)

        {

            clsLicense_DL.GetLicenseInfo(Value, ref ClassName, ref FullName, ref LicenseID,
                ref NationalNo, ref Gender, ref Notes, ref IsActive, ref IssueDate, ref ExpireDate, ref DateOfBirth,
                ref IssueReason, ref DriverID, ref IsDetained,ref ImagePath, ParameterName);




        }



        public static DataTable GetAllPersonLocalLicense(int DriverID)
        {

            return clsLicense_DL.GetAllPersonLocalLicense(DriverID);
        }

        public static DataTable GetAllPersonInternationalLicense(int DriverID = -1)
        {

            return clsLicense_DL.GetAllPersonInternationalLicense(DriverID);
        }
        public static DateTime GetExpirationDate(int LicenseID)
        {

            return clsLicense_DL.GetLicenseExpireDate(LicenseID);
        }
        public static void  GetInternationalLicenseByApplication
            (
             int ApplicationID,
            ref string FullName,
            ref int InternationalID,
            ref int LicenseID,
            ref string NationalNo,
            ref string Gendor,
            ref DateTime IssueDate,
            ref string IsActive,
            ref DateTime DateOfBirth,
            ref int DriverID,
            ref DateTime ExpirationDate,
            ref string ImagePath
            )
        {
            clsLicense_DL.GetInternationalLicenseByApplication
                (ApplicationID,
                ref FullName,
                ref InternationalID,
                ref LicenseID,
                ref NationalNo,
                ref Gendor,
                ref IssueDate,
                ref IsActive,
                ref DateOfBirth,
                ref DriverID,
                ref ExpirationDate,
                ref ImagePath);

        }



        public static bool IsLicenseActive(int LicenseID)
        {
            return clsLicense_DL.IsLicenseActive(LicenseID);
        }

        public static bool IsLicenseExpired(int LicenseID)
        {

            return (DateTime.Now > clsLicense_DL.GetLicenseExpireDate(LicenseID)) ? true : false;

        }

        public static int GetLicenseClassIDByLicenseID(int LicenseID)
        {

            return clsLicense_DL.GetLicenseClassIDByLicenseID(LicenseID);

        }

        public static int GetPersonIDByLicenseID(int LicenseID)
        {

           return clsLicense_DL.GetPersonIDByLicenseID(LicenseID);
        }



        public static void AddDataToLicense_DL_Structure
            (DVLD_DataLayer.Structures_DL.clsLicense License_DL,int LicenseID)
        {
            clsLicense_BL License_BL = new clsLicense_BL(LicenseID);

            License_DL.SetApplicationID(License_BL.GetApplicationID());
            License_DL.SetLicenseID(License_BL.GetLicenseID());
            License_DL.SetDriverID(License_BL.GetDriverID());
            License_DL.SetCreatedByUserID(License_BL.GetCreatedByUserID());
            License_DL.SetIssueDate(License_BL.GetIssueDate());
            License_DL.SetExpireDate(License_BL.GetExpireDate());
            License_DL.SetNotes(License_BL.GetNotes());
            License_DL.SetPaidFees(License_BL.GetPaidFees());
            License_DL.SetIsActive(License_BL.GetIsActive());
            License_DL.SetIssueReasonID(License_BL.GetIssueReasonID());


        } 


    }
}
