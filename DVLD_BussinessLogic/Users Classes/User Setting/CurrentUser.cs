namespace DVLD_BussinessLogic.Users_Classes.User_Setting
{
    public static class CurrentUser
    {
        static string _Username = null;
        static int _UserID = -1;
        static bool _IsUserActive = false;
        static int PermissionID = -1;
        static int PermissionValue = -3;
        public static void SetUserName(string UserName)
        {
            _Username = UserName;
        }
        public static void SetUserID(int UserID)
        {
            _UserID = UserID;
        }
        public static void Set_IsActive(bool IsUserActive)
        {
            _IsUserActive = IsUserActive;
        }
        public static bool IsActive(bool IsUserActive)
        {
            return _IsUserActive;
        }
        public static string GetUserName()
        {
            return _Username;
        }
        public static int GetUserID()
        {
            return _UserID;
        }
        public static void SetPermission(int _PermissionID)
        {

            PermissionID = _PermissionID;

        }

        public static int GetPermissionValue()
        {
            if (PermissionID == -1)
                return -3;

            return clsUsers_BL.GetPermissionValue(PermissionID);

        }
        public static void _Reset()
        {

            _UserID = -1;
            _Username = null;
        }



    }
}
