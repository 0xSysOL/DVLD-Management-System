using DVLD_BussinessLogic.License_Classes;
using DVLD_BussinessLogic.Users_Classes.User_Setting;
using DVLD_DataLayer.Structures_DL;
using DVLD_DataLayer.Tables.Detained;
using DVLD_DataLayer.Tables.Workflow;
using System;

namespace DVLD_BussinessLogic.Workflows.ReleaseDetain
{


    public class clsWF_ReleaseDetain_BL
    {
        DVLD_DataLayer.Structures_DL.clsDetainLicense OB_Detain;
        DVLD_DataLayer.Structures_DL.Application OB_Application;

        int _DetainID = -1;
        int _LicenseID = -1;

        public int GetApplicationID()
        {

            return OB_Detain.ReleaseApplicationID != null ? (int)OB_Detain.ReleaseApplicationID : 0;

        }
        public void InitializeApplicationOb(int LicenseID)
        {
            OB_Application = new Application
                (Application.enApplicationType.ReleaseDetained,
                clsLicense_BL.GetPersonIDByLicenseID(LicenseID), CurrentUser.GetUserID(), Application.eModeStatus.Completed);
        }
        public clsWF_ReleaseDetain_BL(int LicenseID)
        {
            _DetainID = clsDetained_DL.GetDetainIDByLicense(LicenseID);
            _LicenseID = LicenseID;

            if (_DetainID == -1)
                return;

            OB_Detain = new clsDetainLicense();
            OB_Detain.IsReleased = true;
            OB_Detain.ReleaseDate = DateTime.Now;
            OB_Detain.ReleasedByUserID = CurrentUser.GetUserID();
            InitializeApplicationOb(LicenseID);



        }
        private bool IsPassedValidation()
        {
            if (clsDetained_DL.IsLicenseDetain(_LicenseID))
                return true;


            return false;
        }
        public bool Save()
        {
            if (!IsPassedValidation())
                return false;


            return clsWF_ReleaseDetain_DL.ReleaseDetain(_DetainID, OB_Detain, OB_Application);
        }



    }




}
