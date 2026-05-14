using DVLD_BussinessLogic.Application_Classes.New_Local_License_App;
using DVLD_BussinessLogic.Drivers;
using DVLD_BussinessLogic.License_Class;
using DVLD_BussinessLogic.License_Classes;
using DVLD_BussinessLogic.Users_Classes.User_Setting;
using DVLD_DataLayer.Tables.Workflow;
using System;

namespace DVLD_BussinessLogic.Workflows
{


    public class clsWF_IssueFirstTimeLicense_BL
    {

        clsNewLocalDriverLicenseApplication_BL LDLAPP;
        public clsDriver_BL Ob_Driver;
        public clsLicense NewLicense;

        public void SetNote(string Note)
        {

            NewLicense.SetNotes(Note);
        }

        public void InitializeDriverOB(clsNewLocalDriverLicenseApplication_BL Ob)
        {

            Ob_Driver = new clsDriver_BL();
            Ob_Driver.SetPersonID(Ob.PersonID);
            Ob_Driver.SetUserID(CurrentUser.GetUserID());
            Ob_Driver.SetCreateDate(DateTime.Now);


        }

        public void InitializeDriverOB(int DriverID)
        {

            Ob_Driver = new clsDriver_BL(DriverID);
          

        }



        public void InitializeLicenseOB(clsNewLocalDriverLicenseApplication_BL Ob)
        {
            if (Ob.GetLDLA() == -1)
                return;


            NewLicense = new clsLicense();
            NewLicense.SetLicenseClassID(Ob.GetLicenseClassID());
            NewLicense.SetCreatedByUserID(CurrentUser.GetUserID());
            NewLicense.SetIsActive(true);
            NewLicense.SetIssueDate(DateTime.Now);
            NewLicense.SetApplicationID(Ob.Get_BaseAPP_ID());
            NewLicense.SetIssueReasonID((int)Ob.eAppTypeID);
            NewLicense.SetPaidFees(clsLicenseClass_BL.GetLicensePrice(Ob.GetLicenseClassID()));
            NewLicense.SetExpireDate
                (
                DateTime.Now.AddYears(clsLicenseClass_BL.GetDefaultValidityLength(Ob.GetLicenseClassID())));



        }
        public clsWF_IssueFirstTimeLicense_BL(int ApplicationID)
        {
            LDLAPP = new clsNewLocalDriverLicenseApplication_BL(ApplicationID);

            InitializeLicenseOB(LDLAPP);
            InitializeDriverOB(LDLAPP);

        }

        public virtual bool Save()
        {
            // FIXME: Check If Person a Driver Or Not 
            int DriverID = -1; // Ref
            int LicenseID = -1; // Ref


            return clsWF_IssueFirstTimeLicense_DL.
                SaveNew_Driver_License_UPDAPP(ref DriverID,
                Ob_Driver.GetPersonID(),
                CurrentUser.GetUserID(),
                Ob_Driver.GetCreateDate(),
                ref LicenseID,
                NewLicense.GetLicenseClassID(),
                NewLicense.GetApplicationID(),
                NewLicense.GetIssueDate(),
                NewLicense.GetExpireDate(),
                NewLicense.GetNotes(),
                NewLicense.GetPaidFees(),
                NewLicense.GetIsActive(),
                NewLicense.GetIssueReasonID());


        }





    }


}
