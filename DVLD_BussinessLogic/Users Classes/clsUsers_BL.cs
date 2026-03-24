using DVLD_BussinessLogic.Users_Classes.User_Setting;
using DVLD_DataLayer.Tables;
using System.Data;
using System.IO;
using System.Linq;
//using static System.Net.WebRequestMethods;
namespace DVLD_BussinessLogic.Users_Classes
{
    public class clsUsers_BL
    {
        enum eMode { Update = 1, Add = 0 };
        eMode mode;
        public string  GetModeType() 
        {

           return mode.ToString();
        }

        public enum eSetError { none = 0, Empty = 1, Exists = 2, UserLinked = 3, References = 4 };
        eSetError e_error = eSetError.none;


        public eSetError GetError()
        {
            return e_error;
        }
        public int UserID { get; set; }
        public int PersonID { get; set; }

        public string Username { get; set; }
        private string CurrentUsername = null;
        public bool IsActive { get; set; }
        public string Password { get; set; }

        public clsUsers_BL()
        {
            UserID = -1;
            Username = null;
            IsActive = false;
        }
        public clsUsers_BL(int UserID)
        {
            int PersonID = -1;
            string Username = null;
            string Password = null;
            bool IsActive = false;
            if (GetUserRecord(UserID, ref PersonID, ref Username, ref Password, ref IsActive))
            {
                this.UserID = UserID;
                this.PersonID = PersonID;
                this.Username = Username;
                CurrentUsername = Username;
                this.Password = Password;
                this.IsActive = IsActive;

                mode = eMode.Update;

            }


        }

        private void SetMode()
        {
            if (UserID != -1)
                mode = eMode.Update;
            else
                mode = eMode.Add;

        }
        private void SetCurrentUserName()
        {
            if (UserID != -1)
                CurrentUsername = Username;
        }


        private bool Validation()
        {
            if (IsDataEmpty())
            {
                e_error = eSetError.Empty;
                return false;
            }


            if (IsUsernameExists(Username))
            {
                e_error = eSetError.Exists;
                return false;
            }
            if (mode == eMode.Update) return true;

            if (IsThePersonLinkedTableUsers(PersonID))
            {
                e_error = eSetError.UserLinked;
                return false;
            }

            e_error = eSetError.none;

            return true;
        }

        public bool Save()
        {
            if (!Validation())
                return false;

            switch (mode)
            {
                case eMode.Add:
                    UserID = clsUsers_DL.AddNewUser(PersonID, Username, Password, IsActive);

                    SetMode();
                    SetCurrentUserName();
                    break;

                case eMode.Update:
                     clsUsers_DL.UpdateUser(UserID, Username, Password, IsActive);
                    SetCurrentUserName();
                    break;
            }

            return (UserID != -1) ? true : false;
        }
        private static bool GetUserRecord(int UserID, ref int PersonID, ref string UserName, ref string Password, ref bool IsActive)
        {

            return clsUsers_DL.GetUserRecord(UserID, ref PersonID, ref UserName, ref Password, ref IsActive);

        }
        public static DataTable GetAllUsers(string FilterType = "", object Filter = null)
        {

            return clsUsers_DL.GetAllUsers(FilterType, Filter);
        }
        public static string GetUserByUserName(string Username, string Password)
        {
            int ID = -1;
            bool IsActive = false;

            if (clsUsers_DL.GetUserByUserName(ref ID, ref Username, Password, ref IsActive))
            {

                if (!IsActive) return "Not Active";

                CurrentUser.Set_IsActive(IsActive);
                CurrentUser.SetUserID(ID);
                CurrentUser.SetUserName(Username);


                return "Success";
            }
            else
                CurrentUser.SetUserID(-1);

            return "Fail";


        }

        static string FilePathRememberUser = @"C:\RememberUser\User_Info.txt";
        public static void RememberUser()
        {

            File.WriteAllText(FilePathRememberUser, CurrentUser.GetUserName());

        }
        public static void GetRememberMeUser(ref string Username)
        {
            if (File.Exists(FilePathRememberUser))
                Username = File.ReadLines(FilePathRememberUser).First();

        }
        private static string GetColumnValueByUserID(int UserID, string ColumnName)
        {
            // not complated
            return clsUsers_DL.GetColumnValueByUserID(UserID, ColumnName);
        }


        public static void Delete_Remembered_User()
        {
            if (File.Exists(FilePathRememberUser))
                File.Delete(FilePathRememberUser);

        }
        public static bool DeleteUser(int UserID)
        {
            return clsUsers_DL.DeleteUser(UserID);

        }

        private bool IsDataEmpty()
        {
            return PersonID <= 0 ||
                   string.IsNullOrEmpty(Username) ||
                   string.IsNullOrEmpty(Password);
        }
        public bool IsUsernameExists(string Username)
        {
            if (CurrentUsername != Username && IsUserExists(Username)) return true;


            return false;
        }
        public static bool IsThePersonLinkedTableUsers(int PersonID)
        {

            return clsUsers_DL.IsThePersonLinkedTableUsers(PersonID);
        }
        public static bool IsUserExists(string Username)
        {

            return clsUsers_DL.IsUserExists(Username);

        }






    }
}
