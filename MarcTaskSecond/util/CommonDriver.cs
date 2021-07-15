using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using MarcTaskSecond.ExtentReport;
using MarcTaskSecond.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Text;

namespace MarcTaskSecond.util
{
   public class CommonDriver
    { 
        // init driver
        public static IWebDriver driver { get; set; }
        // public static LoginPage loginPage = new LoginPage();
        // ExtentReports rep = GenerateExtentReport.getInstence();
        public static ExtentReports extentReports;
        public static ExtentHtmlReporter htmlReporter;
        public static ExtentTest extentTest;

        [OneTimeSetUp]
        public void Setup()
        {
            try
            {
                htmlReporter = new ExtentHtmlReporter(@"C:\testingProject\MarcTaskSecond\MarcTaskSecond\ExtentReport\CommonDriver.html");
                htmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Standard;
                extentReports = new ExtentReports();
                extentReports.AttachReporter(htmlReporter);
                extentReports.AddSystemInfo("OS", "Windows");
                extentReports.AddSystemInfo("Host Name", "Piue");
                extentReports.AddSystemInfo("Envirment", "QA");
                extentReports.AddSystemInfo("UserNmae", "Piue Shri");

                //extentTest = rep.CreateTest("Setup");
                //extentTest.Log(Status.Info, "Startin the EditProfileTest test");
                driver = new ChromeDriver();
                NavigateUrl();
                driver.Manage().Window.Maximize();



                Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
                ExcelLib.PopulateInCollection(ConstantClass.DataFilePath, "Register");
                ExcelLib.PopulateInCollection(ConstantClass.DataFilePath, "Login");
                ExcelLib.PopulateInCollection(ConstantClass.DataFilePath, "ProfilePage");
                ExcelLib.PopulateInCollection(ConstantClass.DataFilePath, "AddSkill");
                ExcelLib.PopulateInCollection(ConstantClass.DataFilePath, "ManageListings");
                ExcelLib.PopulateInCollection(ConstantClass.DataFilePath, "SearchSkill");
                ExcelLib.PopulateInCollection(ConstantClass.DataFilePath, "ServiceDetail");
                ExcelLib.PopulateInCollection(ConstantClass.DataFilePath, "Chat");
                ExcelLib.PopulateInCollection(ConstantClass.DataFilePath, "ManageRequests");
                ExcelLib.PopulateInCollection(ConstantClass.DataFilePath, "Notification");


                LoginPage loginPageObj = new LoginPage();
                loginPageObj.LoginSteps(driver);
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

            //extentTest.Log(Status.Pass, "test pass")
        }
        public static string BaseUrl
        {
            get { return ConstantClass.Url; }
        }


        public static void NavigateUrl()
        {
            driver.Navigate().GoToUrl(BaseUrl);
        }

        [OneTimeTearDown]
        public void Close()
        {
           
            driver.Close();
            driver.Quit();
            extentReports.Flush();
        }



    }
}
