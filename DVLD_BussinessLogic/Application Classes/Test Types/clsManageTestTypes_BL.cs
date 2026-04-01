using DVLD_DataLayer.Application_Classes;
using DVLD_DataLayer.Tables.Application_Classes.Test_Types;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BussinessLogic.Application_Classes
{

    public class clsManageTestTypes_BL : clsManageApplicationTypes_BL
    {
        private string Description;

        public string GetDescription()
        {

            return Description;
        }
        public void SetDescription(string Description)
        {
            this.Description = Description;
        }

        public clsManageTestTypes_BL() : base()
        {
            Description = "";
            mode = eMode.Add;
        }

      public  clsManageTestTypes_BL(int ID) : this()
        {
            this.ID = GetRecordTestTypeByID(ID,ref Title,ref Description,ref Fees);
            mode = eMode.Update;
        }

        int GetRecordTestTypeByID(int ID,ref string  Title,ref string Description,ref decimal Fees)
        {
            return clsManageTestTypes_DL.GetTestTypeByID(ID, ref Title, ref Description, ref Fees);
        }

        
        
        [Obsolete(@"this Function inherited from clsManageApplicationTypes  but we changed his behavior")]
         public override DataTable GetManageApplicationType()
        {
            return clsManageTestTypes_DL.GetTestsTypes();
        } 
         public override bool Save() 
        {

            switch (mode)
            {

                case eMode.Add:
                    // not set for now
                    break;

                case eMode.Update:
                    return clsManageTestTypes_DL.UpdateTestTypesType(ID, Title, Description, Fees);


            }

            return false;

        }



    }



}
