using DVLD_BussinessLogic.Application_Classes.Application;
using DVLD_DataLayer.Tables.License_Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public static void GetLicenseInfoByApplicationID(int ApplicationID,ref string ClassName,ref string FullName,
            ref int LicenseID,ref string NationalNo,ref string Gender,ref string Notes,ref string IsActive,ref DateTime IssueDate,
            ref DateTime ExpireDate,ref DateTime DateOfBirth,ref string IssueReason,ref int DriverID, ref string IsDetained) 
        
        {

            clsLicense_DL.GetLicenseInfoByApplicationID(ApplicationID, ref ClassName, ref FullName, ref LicenseID,
                ref NationalNo, ref Gender, ref Notes, ref IsActive, ref IssueDate, ref ExpireDate, ref DateOfBirth,
                ref IssueReason, ref DriverID, ref  IsDetained);




        }






    }
}
