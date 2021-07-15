using MarcTaskSecond.util;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MarcTaskSecond.Pages
{
    class SearchPage
    {
        public SearchPage()
        {
            // this.driver = driver
            PageFactory.InitElements(CommonDriver.driver, this);
        }
        ////page factory design
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/div[1]/div[1]/i")]
        private IWebElement SearchIcon { get; set; }
        [FindsBy(How =How.XPath,Using = "//*[@id='service-search-section']/div[2]/div/section/div/div[1]/div[2]/input")]
        private IWebElement SearchSkill { get; set; }
         [FindsBy(How =How.CssSelector,Using = "#service-search-section > div.ui.container > div > section > div > div.twelve.wide.column > div > div.two.column.row > div.right.floated.column > div > button:nth-child(7)")]
          private IWebElement GoToPageSix { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#service-search-section > div.ui.container > div > section > div > div.twelve.wide.column > div > div:nth-child(2) > div > div > div > a")]
        private IWebElement SearchedSkillResult { get; set; }

        //Read data from Excel
        private string searchskill = ExcelLib.ReadData(1, "SearchSkill");

        public void SearchSkills(IWebDriver driver)
        {
            Wait.ElementExist(driver, "XPath", "//*[@id='account-profile-section']/div/div[1]/div[1]/i", 15);
            SearchIcon.Click();
            Wait.ElementExist(driver, "XPath", "//*[@id='service-search-section']/div[2]/div/section/div/div[1]/div[2]/input", 8);
            SearchSkill.SendKeys(searchskill);
            SearchSkill.SendKeys(Keys.Enter);
            Wait.ElementExist(driver, "CssSelector", "#service-search-section > div.ui.container > div > section > div > div.twelve.wide.column > div > div:nth-child(2) > div > div > div > a", 8);

            SearchedSkillResult.Click();
           


        }


       
    }
}
