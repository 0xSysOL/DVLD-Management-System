using DVLD_DataLayer.Application_Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BussinessLogic.Application_Classes
{
    public class clsManageApplicationTypes_BL
    {
       protected enum eMode { Update=0,Add=1}
       protected eMode mode;
       protected int ID;
       protected string Title;
       protected decimal Fees;
      
        public void SetTitle(string Title) 
        {

            this.Title = Title;
        }
        public void SetFees(decimal Fees)
        {

            this.Fees = Fees;
        }

        public int GetID()
        {

            return ID;
        }
        public string GetTitle()
        {

           return Title;
        }
        public decimal GetFees()
        {

            return Fees;
        }
        public clsManageApplicationTypes_BL()
        {
            ID = -1;
            Title = "";
            Fees = 0;
        }
        public  clsManageApplicationTypes_BL(int ID) :this()
        {

           this.ID =  GetAppTypeByID(ID,ref Title,ref Fees);

        }
        public virtual DataTable GetManageApplicationType() 
        {
            return clsManageApplicationTypes_DL.GetManageApplicationType();
        }

        private int GetAppTypeByID(int ID,ref string Title,ref decimal Fees) 
        {

            return clsManageApplicationTypes_DL.GetManageAppTypeByID(ID, ref Title, ref Fees);

        }
        public virtual bool Save() 
        {

            switch (mode)
            {

                case eMode.Add:
                    // not set for now
                    break;

                case eMode.Update:
                    return clsManageApplicationTypes_DL.UpdateApplicationType(ID, Title, Fees);
                    

            }

            return false;

        }




    }
}
