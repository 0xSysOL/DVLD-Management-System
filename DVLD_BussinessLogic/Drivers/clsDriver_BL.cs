using DVLD_DataLayer.Tables.Drivers;
using DVLD_DataLayer.Tables.License_Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BussinessLogic.Drivers
{
    public class clsDriver_BL
    {
     public   int DriverID { set; get; }
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

        public clsDriver_BL()
        {

            DriverID = -1;
            CreateByUserID = -1;
            PersonID = -1;
            

        } 
        public clsDriver_BL(int DriverID)
        {

            clsDriver_DL.GetDriver(DriverID,ref CreateDate,ref PersonID,ref CreateByUserID);
            this.DriverID = DriverID;
        }

        public static bool IsPersonDriver(int PersonID)
        {

           return clsDriver_DL.IsPersonDriver(PersonID);
        }

        public static int GetDriverIDByPersonID(int PersonID)
        {


          return  clsDriver_DL.GetDriverIDByPersonID(PersonID);

        }
        public static DataTable GetDrivers()
        {

            return clsDriver_DL.GetDrivers();


        }
        public static int GetPersonIDByDriverID(int DriverID)
        {

            return clsDriver_DL.GetPersonIDByDriverID(DriverID);

        }

        public static bool IsDriverHaveInternationalLicense(int DriverID)
        {

            return clsDriver_DL.IsDriverHaveInternationalLicense(DriverID);


        }


        public static DataTable GetAllDrivers(string Value = null, string ColumnName = null) 
        {


            return clsDriver_DL.GetAllDrivers(Value, ColumnName);
        }

    }
}
