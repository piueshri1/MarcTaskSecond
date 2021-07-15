using AventStack.ExtentReports;
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
    class SearchPageTest : CommonDriver
    {
        [Test]
        public void SearchSkillsByAllCategoriesTest()
        {
            try
            {

                extentTest = extentReports.CreateTest("SearchSkillsByAllCategoriesTest");
                extentTest.Log(Status.Info, "Startin the EditProfileTest test");
                //Search Page Objects
                SearchPage searchPageObj = new SearchPage();
                searchPageObj.SearchSkills(driver);
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
        public void ChatWithSeller()
        {
                try
                {
                extentTest = extentReports.CreateTest(TestContext.CurrentContext.Test.Name).Info("Test Started");
                extentTest.Log(Status.Info, "EditShareSkill method is called");

                //extentTest = extentReports.CreateTest("ChatWithSeller");
                //extentTest.Log(Status.Info, "Startin the EditProfileTest test");

                ChatPage chatPage = new ChatPage();
                   chatPage.ChatWithSeller(driver);
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
