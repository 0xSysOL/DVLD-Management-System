using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BussinessLogic.Drivers
{
    public class clsDriver
    {
        int DriverID { set; get; }
        DateTime CreateDate;
        int PersonID;
        int CreateByUserID;

        public void SetPersonID(int PersonID)
        {
          this.PersonID =  PersonID;

        }
        public int GetPersonID()
        {
         return   this.PersonID;

        }
        public void SetUserID(int UserID)
        {
            this.CreateByUserID = UserID;

        }
        public void SetCreateDate(DateTime CreateDate)
        {
            this.CreateDate = CreateDate;

        }
        public DateTime GetCreateDate()
        {

           return this.CreateDate;
        }

        enum eMode { Add = 1,None =0 }

        public clsDriver()
        {

            DriverID = -1;
            CreateByUserID = -1;
            PersonID = -1;
            

        } 


    }
}
