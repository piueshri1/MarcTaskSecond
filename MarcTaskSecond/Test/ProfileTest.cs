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
    class ProfileTest : CommonDriver
    {
      
        [Test]
       public void profileTest()
        {
            try
            {
                extentTest = extentReports.CreateTest(TestContext.CurrentContext.Test.Name).Info("Test Started");
                extentTest.Log(Status.Info, "EditShareSkill method is called");

                //extentTest = extentReports.CreateTest("profileTest");
                //extentTest.Log(Status.Info, "Startin the EditProfileTest test");
                // loginPage.LoginSteps(driver);
                ProfilePage profilePage = new ProfilePage();
                 profilePage.ProfileTest(driver);

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

        [Test]
        public void LanguageTest()
        {
            try
            {

                extentTest = extentReports.CreateTest(TestContext.CurrentContext.Test.Name).Info("Test Started");
                extentTest.Log(Status.Info, "EditShareSkill method is called");

                //extentTest = extentReports.CreateTest("LanguageTest");
                //extentTest.Log(Status.Info, "Startin the EditProfileTest test");
                // loginPage.LoginSteps(driver);
                LanguagePage languagePage = new LanguagePage();
                languagePage.AddLanguage(driver);
                languagePage.UpdateLanguage(driver);
                languagePage.DeleteLanguage(driver);

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

        [Test]
        public void SkillsTest()
        {
            try
            {

                extentTest = extentReports.CreateTest(TestContext.CurrentContext.Test.Name).Info("Test Started");
                extentTest.Log(Status.Info, "EditShareSkill method is called");

                //extentTest = extentReports.CreateTest("SkillsTest");
                //extentTest.Log(Status.Info, "Startin the EditProfileTest test");
                // loginPage.LoginSteps(driver);
                SkillsPage skillsPage = new SkillsPage();
                skillsPage.AddSkills(driver);
                skillsPage.UpdateSkills(driver);
                skillsPage.DeleteSkills(driver);

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

        [Test]
        public void AddEducationTest()
        {
            try
            {

                extentTest = extentReports.CreateTest(TestContext.CurrentContext.Test.Name).Info("Test Started");
                extentTest.Log(Status.Info, "EditShareSkill method is called");

                //extentTest = extentReports.CreateTest("AddEducationTest");
                //extentTest.Log(Status.Info, "Startin the EditProfileTest test");
                // loginPage.LoginSteps(driver);
                EducationPage educationPage = new EducationPage();
                educationPage.AddEducation(driver);

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

        [Test]
        public void AddCertification()
        {
            try
            {

                extentTest = extentReports.CreateTest(TestContext.CurrentContext.Test.Name).Info("Test Started");
                extentTest.Log(Status.Info, "EditShareSkill method is called");

                //extentTest = extentReports.CreateTest("AddCertification");
                //extentTest.Log(Status.Info, "Startin the EditProfileTest test");
                // loginPage.LoginSteps(driver);
                CertificationPage certificationPage = new CertificationPage();
                certificationPage.AddCertification(driver);

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
        [Test]
        public void AddCertificationTest()
        {
            try
            {

                extentTest = extentReports.CreateTest(TestContext.CurrentContext.Test.Name).Info("Test Started");
                extentTest.Log(Status.Info, "EditShareSkill method is called");
                //extentTest = extentReports.CreateTest("AddCertificationTest");
                //extentTest.Log(Status.Info, "Startin the EditProfileTest test");
                // loginPage.LoginSteps(driver);
                DescriptionPage descriptionPage = new DescriptionPage();
                descriptionPage.AddDescription(driver);

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
