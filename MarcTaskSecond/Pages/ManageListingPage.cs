using MarcTaskSecond.util;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MarcTaskSecond.Pages
{
    class ManageListingPage
    {
        public ManageListingPage()
        {
            PageFactory.InitElements(CommonDriver.driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Manage Listings')]")]
        private IWebElement ManageListingstab { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Manage Listings')]")]
        private IWebElement ManageListings { get; set; }
        [FindsBy(How =How.XPath,Using = "//*[@id='listing - management - section']/div[2]/div[1]/div[1]/table/tbody/tr/td[8]/div/button[1]/i")]
        private IWebElement ManageListingsView { get; set; }

        public bool ClickManageListings(IWebDriver driver)

        {
            Wait.ElementExist(driver, "XPath", "//a[contains(text(),'Manage Listings')]",5);
            //Click Manage Listings tab

            ManageListingstab.Click();


            //Validate at Manage Listings Page

            if (ManageListings.Text == "Manage Listings")
            {

                return true;
            }
            else
            {
                return false;
            }

        }

        //public void ClickManageListingsView(IWebDriver driver)
        //{
        //    ManageListingsView.Click();
        //}
    }
}
