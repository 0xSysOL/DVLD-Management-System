using DVLD_BussinessLogic.Application_Classes.New_Local_License_App;

namespace TestProjects
{
    public class UnitTest1
    {
        [Fact]
        public void IS_OBJECTFILL_AND_NOT_EMPTY()
        {
            clsNewLocalDriverLicenseApplication_BL app
                = new clsNewLocalDriverLicenseApplication_BL(16);

            Assert.NotNull(app);
            Assert.Equal(16, app.GetApplicationID());
            Assert.Equal(clsNewLocalDriverLicenseApplication_BL.eMode.Update, app.mode);

        }
    }
}