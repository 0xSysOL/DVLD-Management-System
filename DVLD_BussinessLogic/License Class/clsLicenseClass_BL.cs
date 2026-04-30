using DVLD_DataLayer.Tables.License_Class;
using System.Data;

namespace DVLD_BussinessLogic.License_Class
{
    public class clsLicenseClass_BL
    {
        int ID;
       public int GetID()
        {

            return ID;
        }
        string ClassName;
        string ClassDescription;
        byte MinimumAllowedAge;
        byte DefaultValidityLength;
        decimal ClassFees;



        // ClassName
        public string GetClassName()
        {
            return ClassName;
        }
        public void SetClassName(string value)
        {
            ClassName = value;
        }

        // ClassDescription
        public string GetClassDescription()
        {
            return ClassDescription;
        }
        public void SetClassDescription(string value)
        {
            ClassDescription = value;
        }

        // MinimumAllowedAge
        public short GetMinimumAllowedAge()
        {
            return MinimumAllowedAge;
        }
        public void SetMinimumAllowedAge(byte value)
        {
            MinimumAllowedAge = value;
        }

        // DefaultValidityLength
        public short GetDefaultValidityLength()
        {
            return DefaultValidityLength;
        }
        public void SetDefaultValidityLength(byte value)
        {
            DefaultValidityLength = value;
        }

        // ClassFees
        public decimal GetClassFees()
        {
            return ClassFees;
        }
        public void SetClassFees(decimal value)
        {
            ClassFees = value;
        }



        public clsLicenseClass_BL()
        {
            ID = -1;
            ClassName = "";
            ClassDescription = "";
            MinimumAllowedAge = 0;
            DefaultValidityLength = 0;
            ClassFees = -1;
        }

        public clsLicenseClass_BL(string ClassName)
        {

            GetClassByName(ClassName);

        }
        public static DataTable GetAllClass()
        {

            return clsLicenseClass_DL.GetAllClass();

        }
        private void GetClassByName(string ClassName)
        {

            clsLicenseClass_DL.GetClassByName(ref ID, ClassName, ref ClassDescription, ref MinimumAllowedAge,
               ref DefaultValidityLength, ref ClassFees);

        }

    }
}
