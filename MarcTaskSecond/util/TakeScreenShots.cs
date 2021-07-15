using AventStack.ExtentReports;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarcTaskSecond.util
{
   public class TakeScreenShots
    {
        //public static string CaptureScreenshotAndReturnModel(IWebDriver driver, string ScreenShotName)
        //{
        //    ITakesScreenshot ts = (ITakesScreenshot)driver;
        //    Screenshot screenshot = ts.GetScreenshot();
        //    string path = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
        //    string upToPath = path.Substring(0, path.LastIndexOf("bin")) + "ScreenShots\\" + ScreenShotName + ".pnj";
        //    string localPath = new Uri(upToPath).LocalPath;
        //    screenshot.SaveAsFile(localPath, ScreenshotImageFormat.Png);
        //    return localPath;

        //}
        //Capture Screenshot

        public static MediaEntityModelProvider CaptureScreenshotAndReturnModel(string Name)
        {
            var screenshot = ((ITakesScreenshot)CommonDriver.driver).GetScreenshot().AsBase64EncodedString;
            return MediaEntityBuilder.CreateScreenCaptureFromBase64String(screenshot, Name).Build();

        }
    }
}
