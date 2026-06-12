using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BussinessLogic.Users_Classes.User_Setting
{
    public class clsPermission
    {
      public  enum ePermissions
        {
            All = -1,
            None = 0,
            ManagePeople = 1,
            ManageUsers = 4,
            ListDrivers = 2,
            ManageApplications = 16,
            NormalSetting = 8

        }


        public static bool IsUserHavePermissionToThisProce(int SelectedPermission)
        {
            int Value = CurrentUser.GetPermissionValue();

            if ((Value & SelectedPermission) == SelectedPermission)
                    return true;

            return false;
        }

    }
}
