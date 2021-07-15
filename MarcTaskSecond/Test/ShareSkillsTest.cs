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
    class ShareSkillsTest : CommonDriver
    {
    
        [Test]
        public void AddShareSkills()
        {
            try
            {

                //extentTest = extentReports.CreateTest("AddShareSkills");
                //extentTest.Log(Status.Info, "Startin the EditProfileTest test");

                extentTest = extentReports.CreateTest(TestContext.CurrentContext.Test.Name).Info("Test Started");
                extentTest.Log(Status.Info, "SendChat method is called");

                ShareSkillsPage shareskillObj = new ShareSkillsPage();
                shareskillObj.createShareSkill(driver);

                extentTest.Log(Status.Pass, "Chat sent successfully");
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

        [Test]
        public void EditShareSkill()
        {
            try
            {
                extentTest = extentReports.CreateTest(TestContext.CurrentContext.Test.Name).Info("Test Started");
                extentTest.Log(Status.Info, "EditShareSkill method is called");
                //extentTest = extentReports.CreateTest("EditShareSkill");
                //extentTest.Log(Status.Info, "Startin the EditProfileTest test");
                ManageListingPage manageListingPage = new ManageListingPage();
                manageListingPage.ClickManageListings(driver);


                //Edit Share Skill object

                ShareSkillsPage shareskillObj = new ShareSkillsPage();

                shareskillObj.EditShareSkill(driver);

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
        ////[Test]
        ////public void DeleteShareSkill()
        ////{
        ////            try
        ////            {

        ////                extentTest = rep.CreateTest("DeleteShareSkill");
        ////                extentTest.Log(Status.Info, "Startin the EditProfileTest test");
        ////                ManageListingPage manageListingPage = new ManageListingPage();
        ////    manageListingPage.ClickManageListings(driver);


        ////    //Edit Share Skill object

        ////    ShareSkillsPage shareskillObj = new ShareSkillsPage();

        ////    shareskillObj.DeleteShareSkill(driver);
        ////    }
        ////    catch (Exception msg)
        ////    {
        ////        string ScreenShotPath = TakeScreenShots.CaptureScreenshotAndReturnModel(driver, "screenshot");
        ////        Assert.Fail("Test fail at Edit profile", msg.Message);
        ////        extentTest.Log(Status.Fail, "test fail");
        ////        extentTest.AddScreenCaptureFromPath(ScreenShotPath);


        ////        rep.Flush();
        ////    }
        //}
        //[Test]
        //public void ViewShareSkill()
        //{
        //    ManageListingPage manageListingPage = new ManageListingPage();
        //    manageListingPage.ClickManageListings(driver);
        //    manageListingPage.ClickManageListingsView(driver);
        //}

    }
}
