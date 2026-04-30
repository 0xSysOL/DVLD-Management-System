using System;
using System.Linq;


namespace DVLD_BusinessLogic
{
    public class Methods_BL
    {


        public static bool IsAgeValid(short MinAge, DateTime DateOfBirth)
        {
            if ((DateOfBirth.Year <= DateTime.Now.Year - MinAge))
                return true;

            return false;
        }

    }
}
