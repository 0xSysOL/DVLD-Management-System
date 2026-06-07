using DVLD_BussinessLogic.Users_Classes.User_Setting;
using DVLD_DataLayer.Structures_DL;
using DVLD_DataLayer.Tables.Detained;
using System;
using System.Data;

namespace DVLD_BussinessLogic.Detained
{
    public class clsDetained_BL
    {

        DVLD_DataLayer.Structures_DL.clsDetainLicense Ob_Detain;
        public int GetDetainID()
        {

            return Ob_Detain.DetainID;
        }
        public clsDetained_BL(int License, decimal FineFees)
        {
            Ob_Detain
                = new clsDetainLicense(License, FineFees, CurrentUser.GetUserID());
        }


        public static void GetDetainByLicenseID
            (int LicenseID, ref int DetainID, ref DateTime DetainDate, ref string UserName, ref decimal FineFees)
        {

            clsDetained_DL.GetDetain(LicenseID, ref DetainID, ref DetainDate, ref UserName, ref FineFees);

        }
        public static DataTable GetDetainedList(object Value = null, string ColumnName = null)
        {
            if (Value != null || ColumnName != null)
                return clsDetained_DL.GetDetainedList(Value, ColumnName);
            else
                return clsDetained_DL.GetDetainedList();


        }

        public static bool IsLicenseDetain(int LicenseID)
        {

            return clsDetained_DL.IsLicenseDetain(LicenseID);
        }
        public static bool IsDetainReleased(int LicenseID)
        {

            return clsDetained_DL.IsDetainReleased(LicenseID);
        }
        public bool IsPassedValidation()
        {
            // FIXME: Create IsLicenseExists in License Class And Give Him License ID
            // if(clsLicense_BL.IsExists()) : Create Function For This!!

            if (!IsLicenseDetain(Ob_Detain.LicenseID) || Ob_Detain.FineFees > 0)
                return true;


            return false;
        }
        public bool Save()
        {
            if (!IsPassedValidation())
                return false;



            return clsDetained_DL.AddNewDetain(Ob_Detain);

        }
        public static int GetDetainIDByLicense(int LicenseID)
        {
            return clsDetained_DL.GetDetainIDByLicense(LicenseID);
        }



    }

}
