using AventStack.ExtentReports;
using MarcTaskSecond.ExtentReport;
using MarcTaskSecond.Pages;
using MarcTaskSecond.util;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarcTaskSecond.Test
{
    [TestFixture]
   // [Parallelizable]
    class NotificationTest : CommonDriver
    {
       
        [Test]
        public void NotificationFunction()
        {
            try
            {

                extentTest = extentReports.CreateTest(TestContext.CurrentContext.Test.Name).Info("Test Started");
                extentTest.Log(Status.Info, "EditShareSkill method is called");

                //extentTest = extentReports.CreateTest("NotificationFunction");
                //extentTest.Log(Status.Info, "Startin the EditProfileTest test");
                //Notification object

                NotificationPage notificationObj = new NotificationPage();
                notificationObj.Notification(driver);
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
       
    }
}
