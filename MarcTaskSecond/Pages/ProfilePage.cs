using MarcTaskSecond.util;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Threading;

namespace MarcTaskSecond.Pages
{
    class ProfilePage
    {
        public ProfilePage()
        {
            // this.driver = driver;
            PageFactory.InitElements(CommonDriver.driver, this);
        }


        // navigate to profile tab......................

        // on click profile page.....
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section.nav-secondary > div > a:nth-child(2)")]
        private IWebElement OnClickProfile { get; set; }

        // click on profile name.....
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div:nth-child(2) > div > div > div.title > i")]
        private IWebElement OnClickProfileName { get; set; }
        // enter first name......
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div:nth-child(2) > div > div > div.content.active > div > div.field > input[type=text]:nth-child(2)")]
        private IWebElement EditFirstName { get; set; }
        // enter last name.......
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div:nth-child(2) > div > div > div.content.active > div > div.field > input[type=text]:nth-child(4)")]
        private IWebElement EditLastName { get; set; }
        // on click save button......
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div:nth-child(2) > div > div > div.content.active > div > div:nth-child(2) > button")]
        private IWebElement SaveEdittedProfile { get; set; }

        //Click on Edit button
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div.extra.content > div > div:nth-child(2) > div > span > i")]
        private IWebElement AvailabilityTimeEdit { get; set; }

        //validate profile is added...
        // [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div:nth-child(2) > div > div > div.title")]
        // private IWebElement ValProfileAdded { get; set; }

        //Click on Availability Time dropdown
        [FindsBy(How = How.Name, Using = "availabiltyType")]
        private IWebElement AvailabilityTime { get; set; }

        //Click on Availability Time option
        [FindsBy(How = How.XPath, Using = "//option[@value='0']")]
        private IWebElement AvailabilityTimeOpt { get; set; }

        //Click on Availability Hour icon
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div.extra.content > div > div:nth-child(3) > div > span > i")]
        private IWebElement WorkinHour { get; set; }

        //Click on salary
        [FindsBy(How = How.Name, Using = "availabiltyHour")]
        private IWebElement DwopDownForWorkingHours { get; set; }

        //SelectedWorkinHours
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div.extra.content > div > div:nth-child(3) > div > span")]
        private IWebElement SelectedWorkinHours { get; set; }

        // click on earnTaget icon .......
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div.extra.content > div > div:nth-child(4) > div > span > i")]
        private IWebElement EarnTaget { get; set; }

        // availabilityTarget......
        [FindsBy(How = How.Name, Using = "availabiltyTarget")]
        private IWebElement AvailabilityTarget { get; set; }

        // availabilityToEarn.....
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div.extra.content > div > div:nth-child(4) > div > span > select > option:nth-child(3) ")]
        private IWebElement AvailabilityToEarn { get; set; }

        ////Read Excel value
        private string editFirstName = ExcelLib.ReadData(1, "EditFirstName");
        private string editLastName = ExcelLib.ReadData(1, "EditLastName");


        public void ProfileTest(IWebDriver driver)
        {
            Wait.ElementExist(driver, "CssSelector", "#account-profile-section > div > section.nav-secondary > div > a:nth-child(2)", 5);
            OnClickProfile.Click();
            OnClickProfileName.Click();
          
            Wait.ElementExist(driver, "CssSelector", "#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div:nth-child(2) > div > div > div.content.active > div > div.field > input[type=text]:nth-child(2)", 3);
            EditFirstName.Clear();
            EditFirstName.SendKeys(editFirstName);
            EditLastName.Clear();
            EditLastName.SendKeys(editLastName);
            SaveEdittedProfile.Click();
            
            Wait.ElementExist(driver, "CssSelector", "#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div.extra.content > div > div:nth-child(2) > div > span > i", 10);
            AvailabilityTimeEdit.Click();
            AvailabilityTime.Click();
            AvailabilityTimeOpt.Click();
            WorkinHour.Click();
            DwopDownForWorkingHours.Click();
            SelectedWorkinHours.Click();
            EarnTaget.Click();
            AvailabilityTarget.Click();
            AvailabilityToEarn.Click();
           
        }

    }
}
