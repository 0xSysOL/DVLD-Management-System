using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DVLD_DataLayer;

namespace DVLD_BussinessLogic
{
    public  class clsCountries_BL
    {


        public static DataTable GetCountries()
        {

            return clsCountries_DL.GetCountries();
        }


    }
}
