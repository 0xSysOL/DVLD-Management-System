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
        public const string IsPersonExists = "Select Found=1 from People where PersonID = @Value";
        public const string ReturnMeleOrFemale =
             @"select PersonID,FirstName
,SecondName,ThirdName,LastName,
DateOfBirth,
case when Gendor = 0 then 'Male' else 'Female' end as Gendor
,Address,Phone,Email,ImagePath,Nationality,NationalNo from (
select * from People
where Gendor = @ColumnValue
)R1";

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
        public const string UpdateUser = @"Update Users set   Username = @Username,Password = @Password,IsActive = @IsActive
                  where UserID = @UserID";
        public const string DeleteUser = @"delete Users where UserID = @value";

    }
    #endregion



    #region Application Queries

    internal static class clsQManage_Application_Types
    {


        public const string GetApplicationTypes = "select * from ApplicationTypes";
        public const string GetOneRecord = "select * from ApplicationTypes where ApplicationTypeID = @value";
        public const string UpdateRecord =
            @"

update ApplicationTypes
set ApplicationTypeTitle = @Title ,ApplicationFees = @Fees
where ApplicationTypeID = @ID
            ";




    }

    #region Test Appointment
    internal static class clsQTestAppointment
    {

        public const  string IsVisionTestPassed =
            @"
select TestResult from TestAppointment 
join Tests on Tests.TestAppointmentID = TestAppointment.AppointmentID
where  LocalDrivingLicenseApplicationID = @Value
and Islocked = 1 and TestResult = 1 and TestTypeID = 1

            ";
        public const string IsWrittenTestPassed =
         @"
select TestResult from TestAppointment 
join Tests on Tests.TestAppointmentID = TestAppointment.AppointmentID
where  LocalDrivingLicenseApplicationID = @Value
and Islocked = 1 and TestResult = 1 and TestTypeID = 2

            ";
        public const string IsStreetTestPassed =
        @"
select TestResult from TestAppointment 
join Tests on Tests.TestAppointmentID = TestAppointment.AppointmentID
where  LocalDrivingLicenseApplicationID = @Value
and Islocked = 1 and TestResult = 1 and TestTypeID = 3

            ";

        public const string GetAppointmentsBy_LDLAPP_ID = "select * from GetAppointmentsBy_LDLAPP_ID(@LDLAPP_ID,@TestType)";

        public const string IsPersonPassedTest = "select * from IsPersonPassedTest(@LDLAPP_ID,@TestType)";

        public const string IsPersonTakeTestBefore = "select * from IsPersonTakeTestBefore(@LDLAPP_ID,@TestType)";

        public const string GetTestAppointmentDetails = "select * from GetTestAppointmentDetails(@LDLAPP_ID,@TestType)";
        public const string GetApplicationDetailsForNewAppointment = @"
select * from GetApplicationDetailsForNewAppointment(@LDLAPP_ID)";
        public const string FindAnyActiveAppointment = "select * from FindAnyActiveAppointment(@LDLAPP_ID,@TestType)";

    }

    internal static class clsQVisionTestAppointment
    {
       
    }
    #endregion End



    internal static class clsQManage_Test_Types
    {


        public const string GetTestTypes = "select * from TestsType";
        public const string GetOneRecord = "select * from TestsType where ID = @value";
        public const string UpdateRecord =
            @"

update TestsType
set Title = @Title ,
Fees = @Fees,
Description = @Description
where ID = @ID
            ";




    }

    internal static class clsQApplication
    {

        public const string AddApplication = @"insert into Applications
(ApplicationDate,ApplicationState,PaidFees,ApplicationTypeID,
UserID,ApplicationPersonID,LastDateApplication)
values
(@Date,@State,@PaidFees,@ApplicationTypeID,@UserID,@PersonID,@LastStateDate)
SELECT SCOPE_IDENTITY()";
        public const string UpdateApplication = @"
update Applications 
set LastDateApplication = @LastDateApplication,UserID = @UserID,PaidFees = @PaidFees
where ApplicationID = @ID";
        public const string CancelApplication = @"
update Applications 
set ApplicationState = 2
where ApplicationID = @Value";
        public const string Delete_Application = @"
delete Applications
where ApplicationID = @Value";


        public const string IsApplicationNew = @"
select ApplicationState from Applications join LocalDrivingLicenseApplication on
Applications.ApplicationID = LocalDrivingLicenseApplication.ApplicationID
where Applications.ApplicationPersonID = @PersonID 
and 
LocalDrivingLicenseApplication.LicenseClassID = @LC_ID
and
ApplicationState = 1

";
        public const string IsApplicationCompleted = @"
select ApplicationState from Applications join LocalDrivingLicenseApplication on
Applications.ApplicationID = LocalDrivingLicenseApplication.ApplicationID
where Applications.ApplicationPersonID = @PersonID 
and 
LocalDrivingLicenseApplication.LicenseClassID = @LC_ID
and
ApplicationState = 3

";

        public const string IsLicenseClassExists = @"
select LicenseClassID = 1 from Applications join LocalDrivingLicenseApplication on
Applications.ApplicationID = LocalDrivingLicenseApplication.ApplicationID
where Applications.ApplicationPersonID = @PersonID
and 
LocalDrivingLicenseApplication.LicenseClassID = LC_ID
";
        public const string IsAnyTestsFoundBy_LDLA_ID = @"Select top 1 Found = 1 from TestAppointment
                                                       where LocalDrivingLicenseApplicationID = @Value";

        public const string GetAllApplications = "select * from GetApplications";
        public const string GetAllApplications_WithFilter = @"select * from GetApplications
                                                where [@ColumnName] like @Value  + '%'";
        public const string GetApplicationByID = @"select * from Applications
                                 Where ApplicationID = @Value";
        public const string GetApplicationID_By_LDLAID = @"select ApplicationID from LocalDrivingLicenseApplication
where [Local Driving License Application ID] = @Value
";
  
        public const string GetTestAppointmentResult = @"
Select top 1 case when Islocked = 0 then Sum(1) end as Result from TestAppointment
 group by Islocked,LocalDrivingLicenseApplicationID
 having LocalDrivingLicenseApplicationID = @LDLAPPID
";
        public const string GetApplicationBasicInfo = "select * from ApplicationBasicInfo(@LDLAPP_ID)";

    }


    internal static class clsQLocalDrivingLicenseApp
    {

        public const string AddNew_LDLA =
            @"insert into LocalDrivingLicenseApplication
(ApplicationID,LicenseClassID)
values 
(@ApplicationID,@LicenseClassID)
SELECT SCOPE_IDENTITY()
             ";

        public const string Update_LDLA = @"update LocalDrivingLicenseApplication 
set LicenseClassID = @LC_ID where [Local Driving License Application ID] = @ID";

        public const string Delete_LDLAPPBy_ID = @"delete LocalDrivingLicenseApplication
where[Local Driving License Application ID] = @Value";
        public const string GetApplicationID = @"select ApplicationID from LocalDrivingLicenseApplication
where [Local Driving License Application ID] = @Value";
        public const string Get_LDLA = @"select * from LocalDrivingLicenseApplication 
                                     where ApplicationID = @Value";

 public const string GetDrivingLicenseApplication = "select * from fn_GetDrivingLicenseInfo(@LDLAPP_ID)";

    }



    #endregion End


    #region License Class

    internal static class clsQ_LicenseClass
    {

        public const string GetAllClasses = "select * from LicenseClasses";
        public const string GetOneRecord = @"select * from LicenseClasses
                                            Where ClassName = @Value";

    }

    #endregion End





}

