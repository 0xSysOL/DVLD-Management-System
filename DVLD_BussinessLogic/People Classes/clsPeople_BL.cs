using DVLD_DataLayer;
using System;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.IO;
namespace DVLD_BusinessLogic
{ 
    public class clsPeople_BL
    {
        #region Members
        enum eMode { Update = 1, Add = 0 };
        eMode mode;
        public string GetModeType()
        {

            return mode.ToString();
        }
        public int PersonID { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public string NationalNo { get; set; }
        public DateTime DateOfBirth { get; set; }
        public short Gendor { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string CountryName { get; set; }
        public int CountryID { get; set; }
        public string ImagePath { get; set; }
        public string ImageKey { get; set; }

        #endregion End

        #region InitializeData

        private void _LoadPersonData(int ID = -1)
        {

            DataTable PersonInfo = clsPeople_DL.GetPersonByID(ID);

            if (PersonInfo == null) return;

            PersonID = (int)PersonInfo.Rows[0]["PersonID"];
            NationalNo = PersonInfo.Rows[0]["NationalNo"].ToString();
            FirstName = PersonInfo.Rows[0]["FirstName"].ToString();
            SecondName = PersonInfo.Rows[0]["SecondName"].ToString();
            ThirdName = PersonInfo.Rows[0]["ThirdName"].ToString();
            LastName = PersonInfo.Rows[0]["LastName"].ToString();
            Gendor = (PersonInfo.Rows[0]["Gendor"].ToString() == "Male") ? (short)0 : (short)1;
            DateOfBirth = (DateTime)PersonInfo.Rows[0]["DateOfBirth"];
            CountryName = PersonInfo.Rows[0]["Nationality"].ToString();
            Phone = PersonInfo.Rows[0]["Phone"].ToString();
            Email = PersonInfo.Rows[0]["Email"].ToString();
            Address = PersonInfo.Rows[0]["Address"].ToString();

            ImagePath = FindImagePath(PersonInfo.Rows[0]["ImagePath"].ToString());
            mode = eMode.Update;
            ImageKey = Path.GetFileNameWithoutExtension(ImagePath);



        }

        #endregion End
        #region Constructor
        public clsPeople_BL()
        {

            this.PersonID = -1;
            this.CountryID = -1;

            this.FirstName = "";
            this.SecondName = "";
            this.ThirdName = "";
            this.LastName = "";
            this.NationalNo = "";
            this.Address = "";
            this.Phone = "";
            this.Email = "";
            this.CountryName = "";
            this.ImagePath = "";
            this.ImageKey = null;
            this.ImagePath = null;
            this.DateOfBirth = DateTime.Now;

            this.Gendor = -1;
            mode = eMode.Add;

        }
        public clsPeople_BL(int ID)
        {
            _LoadPersonData(ID);

        }
        #endregion End

        public bool Save()
        {
            if (!_CheckIfEmailValid()) return false;
            if (_CheckTheDataEmpty()) return false;
            if (mode == eMode.Add && clsPeople_DL.IsNationalNoExists(NationalNo)) return false;
            _GetCountryID();
            switch (mode)
            {


                case eMode.Add:
                    _CopyImageToCurrentPath();
                    PersonID = clsPeople_DL.AddNewPerson(
                    #region Parameters
                        FirstName,
                        SecondName,
                        ThirdName,
                        LastName,
                        NationalNo,
                        Gendor,
                        Phone,
                        Email,
                        Address,
                        DateOfBirth,
                        CountryID,
                        ImageKey
                    #endregion End
                    );
                    this.mode = eMode.Update;

                    return (PersonID != 0) ? true : false;
                case eMode.Update:

                    // Wrong statement
                    if (ImageKey != Path.GetFileNameWithoutExtension(ImagePath))
                    {
                        _RemoveOldPicture();
                        _CopyImageToCurrentPath();
                    }
                    int RowChanged = clsPeople_DL.UpdatePerson(
                    #region Parameters
                    PersonID, FirstName,
                    SecondName,
                    ThirdName,
                    LastName,
                    Gendor,
                    Phone,
                    Email,
                    Address,
                    DateOfBirth,
                    CountryID,
                    ImageKey
                    #endregion End
                    );
                    return (RowChanged != 0) ? true : false;



            }


            return false;

        }



        #region Validation
        private bool _CheckIfEmailValid()
        {
            if (string.IsNullOrEmpty(Email)) return true;

            return (new EmailAddressAttribute().IsValid(Email));

        }
        private bool _CheckTheDataEmpty()
        {

            if (string.IsNullOrWhiteSpace(Email)) Email = null;

            return string.IsNullOrWhiteSpace(FirstName) ||
                   string.IsNullOrWhiteSpace(LastName) ||
                   string.IsNullOrWhiteSpace(SecondName) ||
                   string.IsNullOrWhiteSpace(ThirdName) ||
                   string.IsNullOrWhiteSpace(NationalNo) ||
                   string.IsNullOrWhiteSpace(Address) ||
                   string.IsNullOrWhiteSpace(Phone) ||
                   DateOfBirth == DateTime.MinValue ||
                   Gendor == -1 ||
                   CountryName == "";
        }
        private void _RemoveOldPicture()
        {
            if (string.IsNullOrEmpty(ImageKey)) return;

            string Path = FindImagePath(ImageKey);
            if (string.IsNullOrEmpty(Path)) return;
            File.Delete(Path);
            ImageKey = null;
        }
        private void _CopyImageToCurrentPath()
        {


            if (string.IsNullOrEmpty(ImagePath)) return;

            string RadomKey = Guid.NewGuid().ToString();
            string GetExtantion = Path.GetExtension(ImagePath);
            File.Copy(ImagePath, @"C:\DVLD_Person_Images\" + RadomKey + GetExtantion);
            ImageKey = RadomKey;
            ImagePath = @"C:\DVLD_Person_Images\" + ImageKey;

        }
        public static string FindImagePath(string ImageKey)
        {
            if (ImageKey == null) return null;


            string[] extensions = { ".png", ".jpg", ".jpeg" };

            foreach (string ext in extensions)
            {
                string path = Path.Combine(@"C:\DVLD_Person_Images", ImageKey + ext);

                if (File.Exists(path))
                {
                    return path;
                }
            }

            return "";
        }
        private void _GetCountryID()
        {
            CountryID = clsCountries_DL.GetCountryID_ByName(CountryName);
        }



        public static bool IsNationalNoExists(string NationalNo)
        {

            return clsPeople_DL.IsNationalNoExists(NationalNo);
        }

        #endregion END



        public static DataTable GetPersonByNationalNo(string NationalNo) 
        {
            if (NationalNo.Length < 50)
                return clsPeople_DL.GetPersonByNationalNo(NationalNo);
            else
                return null;

        }
        public static DataTable GetAllPeople(string FilterType = "", object Filter = null)
        {

            return clsPeople_DL.GetAllPeople(FilterType, Filter);

        }
        public static DataTable GetPersonByID(int ID)
        {

            return clsPeople_DL.GetPersonByID(ID);
        }
        public  void FillPersonObject(string _NationalNo)
        {
            DataTable data = GetPersonByNationalNo(_NationalNo);

            if (data.Rows.Count <= 0) return;
            PersonID = Convert.ToInt32(data.Rows[0]["PersonID"]);
            FirstName = (data.Rows[0]["FirstName"]).ToString();
            SecondName = (data.Rows[0]["SecondName"]).ToString();
            ThirdName = (data.Rows[0]["ThirdName"]).ToString();
            LastName = (data.Rows[0]["LastName"]).ToString();
            Address = (data.Rows[0]["Address"]).ToString();
            Phone = (data.Rows[0]["Phone"]).ToString();
            DateOfBirth = Convert.ToDateTime(data.Rows[0]["DateOfBirth"]);
            ImagePath = (data.Rows[0]["ImagePath"]).ToString();
            CountryName = data.Rows[0]["Nationality"].ToString();
            NationalNo = data.Rows[0]["NationalNo"].ToString();
            Email = data.Rows[0]["Email"].ToString();

            Gendor = (data.Rows[0]["Gendor"].ToString() == "Male") ? (short)0 : (short)1;
            

        }

        #region Delete Person

        private static string _GetImagePath(int ID)
        {
            return clsPeople_DL.GetImagePath(ID);

        }
        private static void _RemovePicture(string Key)
        {
            
            if (string.IsNullOrEmpty(Key)) return;

            string Path = FindImagePath(Key);
            if (string.IsNullOrEmpty(Path)) return;
            File.Delete(Path);
      
        }
        public static bool DeletePerson(int ID)
        {
            string ImagePath = _GetImagePath(ID);

            if (clsPeople_DL.DeletePerson(ID) == -1)
            {

                _RemovePicture(ImagePath);
                return true;
            }
            


            return false;

        }


        #endregion End

    }


}
