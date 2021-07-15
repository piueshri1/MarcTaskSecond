using MarcTaskSecond.util;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarcTaskSecond.Pages
{
    class DescriptionPage
    {
        public DescriptionPage()
        {
            PageFactory.InitElements(CommonDriver.driver, this);
        }

        //Click Desctiption icon...
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > div > div > div > h3 > span")]
        private IWebElement DescriptionIcon { get; set; }

        //Add Desctiption
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > div > div > form > div > div > div.ui.twelve.wide.column > div.field > textarea")]
        private IWebElement Description { get; set; }

        //Click on Save Button
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > div > div > form > div > div > div.ui.twelve.wide.column > button")]
        private IWebElement Save { get; set; }
        //Read Data from Excel
        private string profiledescription = ExcelLib.ReadData(1, "ProfileDescription");
        private string descriptionmessage = ExcelLib.ReadData(1, "DescriptionMessage");

        public void AddDescription(IWebDriver driver)
        {
            Wait.ElementExist(driver, "CssSelector", "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > div > div > div > h3 > span", 5);

            DescriptionIcon.Click();
            Description.Clear();
            Description.SendKeys(profiledescription);
            Save.Click();
        }

    }
}
