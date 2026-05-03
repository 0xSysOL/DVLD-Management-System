using DVLD_BussinessLogic.Application_Classes.Application;
using DVLD_BussinessLogic.Users_Classes.User_Setting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BussinessLogic.Application_Classes
{
    public class clsRetakeTestApplication_BL : clsApplication_BL
    {
 


        public clsRetakeTestApplication_BL(int APP_ID) :
            base(enApplicationType.RetakeTest)
        {
            ApplicationDate = DateTime.Now;
            ApplicationState = (int)clsApplication_BL.eModeState.New;
            PaidFees = GetRetakeFees();
            LastStateDate = DateTime.Now;
            UserID = CurrentUser.GetUserID();
            PersonID = clsApplication_BL.GetPersonID(APP_ID);


        }

        public decimal GetRetakeFees()
        {
            clsManageApplicationTypes_BL APPType = new clsManageApplicationTypes_BL
                ((int)enApplicationType.RetakeTest);

            return APPType.GetFees();

        }   




    }


}
