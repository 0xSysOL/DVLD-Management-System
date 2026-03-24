namespace DVLD_DataLayer
{


    #region People Queries
    internal static class clsQ_People
    {
        public const string GetAllPeople = "SELECT * FROM ShowPeople ";
        public const string GetOnePerson = "SELECT * FROM GetOnePerson ";
        public const string GetImagePath = @"Select ImagePath from People where PersonID = @PersonID";
        public const string GetPersonByNationalNo = "SELECT * FROM GetOnePerson WHERE NationalNo = @value";



        public const string AddPerson = @"INSERT INTO People 
    (FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gendor, Address, Phone, Email, ImagePath, Nationality, NationalNo) 
    VALUES 
    (@FN, @SN, @TN, @LN, @DateOfBirth, @Gendor, @Address, @Phone, @Email, @ImagePath, @Nationality, @NationalNo);
SELECT SCOPE_IDENTITY()";
        public const string UpdatePerson = @"UPDATE People 
    set FirstName = @FN,
        SecondName = @SN,
        ThirdName= @TN,
        LastName = @LN,
        DateOfBirth= @DOB,
        Gendor = @Gendor,
        Address= @Address,
        Phone = @PhNumber,
        Email = @Email,
        ImagePath = @Key,
        Nationality = @Na_ID
where PersonID = @PersonID
";
        public const string DeletePerson = "Delete from People where PersonID = @value";
        public const string FindNationalNo = @"select  NationalNo = 1 from People where NationalNo = @NationalNo";


    }
    #endregion

    #region Countries Query

    internal static class clsQ_Countries
    {
        public const string GetAll = "select CountryName from Countries order by case when CountryName = 'Iraq' then 0 else 1 end,CountryName asc";

        public const string GetCountryID_ByCountryName = @"select CountryID from Countries
                                                           where CountryName = @CountryName";

    }



    #endregion End

    #region User Queries
    internal static class clsQ_User
    {
        public const string GetAll = "SELECT * FROM ShowUsers";
        public const string QueryIsUserExists = "select * from Users where Username= @username AND Password = @password";
        public const string GetAllUsers = "SELECT * FROM GetAllUsersWithFullName";
        public const string GetOneUser = "SELECT * FROM Users where UserID = @value";

        public const string IsPersonConected = @"select Found=1 from Users
                                              where PersonID = @value";
        public const string IsUserExists = "select Found=1 from Users where Username = @value";
        public const string AddNewUser = @"insert into Users values
                                (@Username,@Password,@IsActive,@PersonID)
                                   select SCOPE_IDENTITY()";
        public const string UpdateUser =@"Update Users set   Username = @Username,Password = @Password,IsActive = @IsActive
                  where UserID = @UserID";
        public const string DeleteUser = @"delete Users where UserID = @value";

    }
    #endregion

}

