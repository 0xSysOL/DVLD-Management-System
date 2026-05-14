using DVLD_BussinessLogic.Application_Classes.New_Local_License_App;
using DVLD_BussinessLogic.Workflows;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestMyProjects
{
    [TestClass]
    public class TestProject
    {
        //[TestMethod]
        //public void TestMethod1() { 
        ////{
        ////    int APP_ID = 4047;
        ////    clsNewLocalDriverLicenseApplication_BL app
        ////        = new clsNewLocalDriverLicenseApplication_BL(APP_ID);

        ////    Assert.IsNotNull(app);
        ////    Assert.AreEqual(APP_ID, app.GetApplicationID());
        ////    Assert.AreEqual(clsNewLocalDriverLicenseApplication_BL.eMode.Update, app.mode);


        //}

        [TestMethod]
        public void Test_clsWF_IssueFirstTimeLicense_BL()
        {

            int Application = 31;
            clsWF_IssueFirstTimeLicense_BL WFIFTL = new clsWF_IssueFirstTimeLicense_BL(Application);


            WFIFTL.SetNote("sdf");
         bool istr =   WFIFTL.Save();

            Assert.IsTrue(istr);
            Assert.AreNotEqual(WFIFTL.NewLicense.GetDriverID(), -1);
            
        }


    }
}
