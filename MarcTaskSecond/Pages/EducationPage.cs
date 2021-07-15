using MarcTaskSecond.util;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarcTaskSecond.Pages
{
    class EducationPage
    {
        public EducationPage()
        {
            PageFactory.InitElements(CommonDriver.driver, this);
        }
        //Click on Add new to Educaiton
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.top.attached.tabular.menu > a:nth-child(3)")]
        private IWebElement OnClickEducation { get; set; }

        //Enter university in the text box
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > thead > tr > th.right.aligned > div ")]
        private IWebElement AddNewEducation { get; set; }

        //Enter university in the text box
        [FindsBy(How = How.Name, Using = "instituteName")]
        private IWebElement EnterUniversity { get; set; }

        //Choose the country
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > div:nth-child(1) > div.six.wide.field > select > option:nth-child(1) ")]
        private IWebElement ChooseCountry { get; set; }

        //Choose the skill level option
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > div:nth-child(1) > div.six.wide.field > select > option:nth-child(11) ")]
        private IWebElement ChooseCountryOpt { get; set; }

        //Click on Title dropdown
        [FindsBy(How = How.Name, Using = "title")]
        private IWebElement ChooseTitle { get; set; }

        //Choose title
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > div:nth-child(2) > div:nth-child(1) > select > option:nth-child(7) ")]
        private IWebElement ChooseTitleOpt { get; set; }

        //Degree
        [FindsBy(How = How.Name, Using = "degree")]
        private IWebElement Degree { get; set; }

        //Year of graduation
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > div:nth-child(2) > div.four.wide.field > select > option.hidden ")]
        private IWebElement DegreeYear { get; set; }

        //Choose Year
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > div:nth-child(2) > div.four.wide.field > select > option:nth-child(8) ")]
        private IWebElement DegreeYearOpt { get; set; }

        //Click on Add
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > div:nth-child(3) > div > input.ui.teal.button")]
        private IWebElement AddEdu { get; set; }
        //Read data from Excel
        private string university = ExcelLib.ReadData(1, "University");
        private string degree = ExcelLib.ReadData(1, "Degree");
       // private string educationmessage = ExcelLib.ReadData(1, "EducationMessage");
       // private string edituniversity = ExcelLib.ReadData(1, "EditUniversity");

        public void AddEducation(IWebDriver driver)
        {
            Wait.ElementExist(driver, "CssSelector", "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.top.attached.tabular.menu > a:nth-child(3)", 5);

            OnClickEducation.Click();
            AddNewEducation.Click();
            EnterUniversity.SendKeys(university);
            ChooseCountry.Click();
            ChooseCountryOpt.Click();
            ChooseTitle.Click();
            ChooseTitleOpt.Click();
            Degree.SendKeys(degree);
            DegreeYear.Click();
            DegreeYearOpt.Click();
            AddEdu.Click();
        }

    }
}
