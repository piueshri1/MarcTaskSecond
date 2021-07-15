using MarcTaskSecond.util;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarcTaskSecond.Pages
{
    class NotificationPage
    {

        public NotificationPage()
        {
            PageFactory.InitElements(CommonDriver.driver, this);
        }
        //Page Factory
        [FindsBy(How =How.XPath,Using = "//body/div[@id='account-profile-section']/div[1]/div[1]/div[2]/div[1]/div[1]")]
        private IWebElement Notificationicon { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'See All...')]")]
        private IWebElement SeeAlllink { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Load More...')]")]
        private IWebElement LoadMorelink { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'...Show Less')]")]
        private IWebElement ShowLesslink { get; set; }

        [FindsBy(How = How.XPath, Using = "//body/div[@id='notification-section']/div[2]/div[1]/div[1]/div[3]/div[1]/div[1]/i[1]")]
        private IWebElement SelectAllIcon { get; set; }

        [FindsBy(How = How.XPath, Using = "//body/div[@id='notification-section']/div[2]/div[1]/div[1]/div[3]/div[1]/div[2]/i[1]")]
        private IWebElement UnSelectAllIcon { get; set; }

        [FindsBy(How = How.XPath, Using = "//body/div[@id='notification-section']/div[2]/div[1]/div[1]/div[3]/div[2]/span[1]/span[1]/div[1]/div[1]/div[1]/div[1]/div[3]/input[1]")]
        private IWebElement Checkbox { get; set; }

       

        ////Excel Read Message
        //private string validatemessage = ExcelLib.ReadData(1, "NotificationMessage");

       

        public void Notification(IWebDriver driver)
        {
            //Click Notification icon
            Wait.ElementExist(driver, "XPath", "//body/div[@id='account-profile-section']/div[1]/div[1]/div[2]/div[1]/div[1]", 8);
            Notificationicon.Click();
            Wait.ElementExist(driver, "XPath", "//a[contains(text(),'See All...')]", 8);
            SeeAlllink.Click();
            SelectNotification(driver);
            UnselectNotification(driver);
            SelectAllIcon.Click();
            UnSelectAllIcon.Click();
        }
        //selecting a notification
        public void SelectNotification(IWebDriver driver)
        {
            Wait.ElementExist(driver, "XPath", "//body/div[@id='notification-section']/div[2]/div[1]/div[1]/div[3]/div[2]/span[1]/span[1]/div[1]/div[1]/div[1]/div[1]/div[3]/input[1]", 5);
            if (!Checkbox.Selected)
            {
                Checkbox.Click();
            }

        }

        //unselecting a notification
        public void UnselectNotification(IWebDriver driver)
        {
            Wait.ElementExist(driver, "XPath", "//body/div[@id='notification-section']/div[2]/div[1]/div[1]/div[3]/div[2]/span[1]/span[1]/div[1]/div[1]/div[1]/div[1]/div[3]/input[1]", 5);
            if (Checkbox.Selected)
            {
                Checkbox.Click();
            }
        }
    }
}
