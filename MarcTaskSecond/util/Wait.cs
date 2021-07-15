using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
namespace MarcTaskSecond.util
{
    class Wait
    {
        public static void ElementExist(IWebDriver driver, string locator, string locatorVlaue, int Seconds)
        {
            try
            {
                if (locator == "Id")
                {
                    var wait = new WebDriverWait(driver, new TimeSpan(0, 0, Seconds));
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id(locatorVlaue)));
                }
                if (locator == "XPath")
                {
                    var wait = new WebDriverWait(driver, new TimeSpan(0, 0, Seconds));
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath(locatorVlaue)));
                }
                if (locator == "CssSelector")
                {
                    var wait = new WebDriverWait(driver, new TimeSpan(0, 0, Seconds));
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector(locatorVlaue)));
                }
                if (locator == "Name")
                {
                    var wait = new WebDriverWait(driver, new TimeSpan(0, 0, Seconds));
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Name(locatorVlaue)));
                }
                if (locator == "LinkText")
                {
                    var wait = new WebDriverWait(driver, new TimeSpan(0, 0, Seconds));
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.LinkText(locatorVlaue)));
                }
            }
            catch (Exception ex)
            {
                Assert.Fail("test fail waitin for element exist", ex.Message);
            }



        }


        // generic fuction to wait element Clickable....


        public static void ElementToBeClickable(IWebDriver driver, string locator, string locatorVlaue, int Seconds)
        {
            try
            {
                if (locator == "Id")
                {
                    var wait = new WebDriverWait(driver, new TimeSpan(0, 0, Seconds));
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id(locatorVlaue)));
                }
                if (locator == "XPath")
                {
                    var wait = new WebDriverWait(driver, new TimeSpan(0, 0, Seconds));
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(locatorVlaue)));
                }
                if (locator == "CssSelector")
                {
                    var wait = new WebDriverWait(driver, new TimeSpan(0, 0, Seconds));
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector(locatorVlaue)));
                }
                if (locator == "Name")
                {
                    var wait = new WebDriverWait(driver, new TimeSpan(0, 0, Seconds));
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Name(locatorVlaue)));
                }
                if (locator == "LinkText")
                {
                    var wait = new WebDriverWait(driver, new TimeSpan(0, 0, Seconds));
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.LinkText(locatorVlaue)));
                }
            }
            catch (Exception ex)
            {
                Assert.Fail("test fail waitin for element exist", ex.Message);
            }


        }
    }
}
