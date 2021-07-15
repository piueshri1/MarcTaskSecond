using AventStack.ExtentReports;
using MarcTaskSecond.ExtentReport;
using MarcTaskSecond.Pages;
using MarcTaskSecond.util;
using NUnit.Framework;
using System;

namespace MarcTaskSecond.Test
{
    [TestFixture]
   // [Parallelizable]
    class Program : CommonDriver
    {
    
        [Test]
        public void SignUpTest()
        {
            try
            {
                extentTest = extentReports.CreateTest(TestContext.CurrentContext.Test.Name).Info("Test Started");
                extentTest.Log(Status.Info, "EditShareSkill method is called");

                //extentTest = extentReports.CreateTest("SignUpTest");
                //extentTest.Log(Status.Info, "Startin the EditProfileTest test");
                SignUpPage signUp = new SignUpPage();
                signUp.Register(driver);
                extentTest.Log(Status.Pass, "EditShareSkill  successfully");
                extentTest.Pass("Test Passed");
            }
            catch (Exception msg)
            {
                var mediaEntity = TakeScreenShots.CaptureScreenshotAndReturnModel(TestContext.CurrentContext.Test.Name.Trim());
                extentTest.Log(Status.Fail, msg.StackTrace.ToString());
                extentTest.Fail("Test Failed", mediaEntity);
                //string ScreenShotPath = TakeScreenShots.CaptureScreenshotAndReturnModel(driver, "screenshot");
                //Assert.Fail("Test fail at Edit profile", msg.Message);
                //extentTest.Log(Status.Fail, "test fail");
                //extentTest.AddScreenCaptureFromPath(ScreenShotPath);
            }
        }




        //[Test]
        //public void LoginTest()
        //{
        //    LoginPage loginPage = new LoginPage();
        //    loginPage.LoginSteps(driver);
        //}


        //[Test]
        //public void ChangePassword()
        //{
        //    ChangePasswordPage changepasswordobj = new ChangePasswordPage();
        //    changepasswordobj.ChangePassword(driver);
        //}

    }
}
