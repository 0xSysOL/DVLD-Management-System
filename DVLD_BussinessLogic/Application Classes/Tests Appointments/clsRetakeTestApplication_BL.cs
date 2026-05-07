using DVLD_BusinessLogic;
using DVLD_BussinessLogic.Application_Classes.Application;
using DVLD_BussinessLogic.Users_Classes.User_Setting;
using DVLD_DataLayer.Tables.Application_Classes;
using System;

namespace DVLD_BussinessLogic.Application_Classes
{
    public  class clsRetakeTestApplication_BL : clsApplication_BL
    {


        public clsRetakeTestApplication_BL(int APP_ID) :
            base(enApplicationType.RetakeTest)
        {
            ApplicationDate = DateTime.Now;
            ApplicationStatus = (int)clsApplication_BL.eModeState.New;
            PaidFees = GetRetakeFees();
            LastStateDate = DateTime.Now;
            UserID = CurrentUser.GetUserID();
            PersonID = clsApplication_BL.GetPersonID(APP_ID);


        }

        public decimal GetRetakeFees()
        {
            // FIX: Return Fees Without Create Object
            clsManageApplicationTypes_BL APPType = new clsManageApplicationTypes_BL
                ((int)enApplicationType.RetakeTest);


            return APPType.GetFees();

        }

        public override bool IsPassedValidation()
        {
            if (!clsPeople_BL.IsPersonExists(PersonID))
                       return false;


                return true;
        }
        public override bool Save()
        {

            if (!IsPassedValidation())
                return false;


            if (mode == eMode.Update || mode == eMode.None)
                return false;


            switch (mode)
            {

                case eMode.Add:
                    ID = clsApplication_DL.AddNewApplication(ApplicationStatus, (int)eAppTypeID, PaidFees,
                        UserID, PersonID, ApplicationDate, LastStateDate);
                    break;
                case eMode.None:
                    return false;
            }




            return ID != -1;

        }



    }


}
