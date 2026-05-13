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
        clsDriver NewDriver;
        clsLicense NewLicense;

        public void SetNote(string Note)
        {

            NewLicense.SetNotes(Note);
        }
        public void InitializeObjects(clsNewLocalDriverLicenseApplication_BL Ob)
        {
            if (Ob.GetLDLA() == -1)
                return;

            NewDriver = new clsDriver();
            NewDriver.SetPersonID(Ob.PersonID);
            NewDriver.SetUserID(CurrentUser.GetUserID());
            NewDriver.SetCreateDate(DateTime.Now);

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

            InitializeObjects(LDLAPP);

        }

        public bool Save()
        {
            /*
        int DriverID ;
        DateTime CreateDate;
        int PersonID;
        int CreateByUserID;


            
         int _LicenseID;
         int _LicenseClassID;
         int _DriverID;
         int _ApplicationID;
         int _CreatedByUserID;
         DateTime _IssueDate;
         DateTime _ExpireDate;
         string _Notes;
         decimal _PaidFees;
         bool _IsActive;
         int _IssueReasonID;

             */
            int DriverID = -1; // Ref
            int LicenseID = -1; // Ref
        

            return clsWF_IssueFirstTimeLicense_DL.
                SaveNew_Driver_License_UPDAPP(ref DriverID,
                NewDriver.GetPersonID(),
                CurrentUser.GetUserID(),
                NewDriver.GetCreateDate(),
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
