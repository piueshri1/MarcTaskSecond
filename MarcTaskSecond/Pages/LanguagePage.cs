using MarcTaskSecond.util;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Threading;

namespace MarcTaskSecond.Pages
{
    class LanguagePage
    {
        public LanguagePage()
        {
            PageFactory.InitElements(CommonDriver.driver, this);
        }

        // Navigate to Language  tab

        //Click on  Language tab........
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.top.attached.tabular.menu > a:nth-child(1)")]
        private IWebElement OnClickLanguage { get; set; }

 

        //Click on Add new to add new Language
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.active.tooltip-target > div > div.twelve.wide.column.scrollTable > div > table > thead > tr > th.right.aligned > div")]
        private IWebElement AddNewLangBtn { get; set; }

        //Enter the Language on text box
        [FindsBy(How = How.Name, Using = "name")]
        private IWebElement AddLangText { get; set; }

        //Enter the Language on text box
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > div:nth-child(2) > select > option:nth-child(1)")]
        private IWebElement ChooseLang { get; set; }

        //Enter the Language on text box
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.active.tooltip-target > div > div.twelve.wide.column.scrollTable > div > div > div:nth-child(2) > select > option:nth-child(3)")]
        private IWebElement ChooseLangOpt { get; set; }

        //Add Language
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > div.six.wide.field > input.ui.teal.button")]
        private IWebElement AddLang { get; set; }


        // Update new  language
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody:nth-child(2) > tr > td.right.aligned > span:nth-child(1) > i")]
        private IWebElement EditLaguage { get; set; }
        //  clear old and update new language
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody:nth-child(2) > tr > td > div > div:nth-child(1) > input[type=text]")]
        private IWebElement SaveEditLaguage { get; set; }
        // dropdown to  update language
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody:nth-child(2) > tr > td > div > div:nth-child(2) > select")]
        private IWebElement ClickToUpdateLaguage { get; set; }
        // select language to update......
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody:nth-child(2) > tr > td > div > div:nth-child(2) > select > option:nth-child(5)")]
        private IWebElement SelectLanguageToUpdate { get; set; }
        // click to update......
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody:nth-child(2) > tr > td > div > span > input.ui.teal.button")]
        private IWebElement ClickUpdate { get; set; }

        // delete language...
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody:nth-child(3) > tr > td.right.aligned > span:nth-child(2) > i")]
        private IWebElement DeleteLanguages { get; set; }


        //Read Data from Excel
        private string language = ExcelLib.ReadData(1, "Language");
        private string validatelanguagemessage = ExcelLib.ReadData(1, "ValidateLanguageMessage");
        private string editlanguage = ExcelLib.ReadData(1, "EditLanguage");

        // method for  edit new language...
        public void AddLanguage(IWebDriver driver)
        {
            Wait.ElementExist(driver, "CssSelector", "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.top.attached.tabular.menu > a:nth-child(1)", 5);
            OnClickLanguage.Click();
            AddNewLangBtn.Click();
            AddLangText.Clear();
            AddLangText.SendKeys(language);
            ChooseLang.Click();


            ChooseLangOpt.Click();
            AddLang.Click();
          

        }
        // method for  UpdateLanguage...
        public void UpdateLanguage(IWebDriver driver)
        {
            Wait.ElementExist(driver, "CssSelector", "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody:nth-child(2) > tr > td.right.aligned > span:nth-child(1) > i", 5);

            EditLaguage.Click();
            SaveEditLaguage.Clear();
            SaveEditLaguage.SendKeys(editlanguage);
            ClickToUpdateLaguage.Click();
            SelectLanguageToUpdate.Click();
            ClickUpdate.Click();
            

        }
        // method for  DeleteLanguage...
        public void DeleteLanguage(IWebDriver driver)
        {
            Wait.ElementExist(driver, "CssSelector", "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody:nth-child(3) > tr > td.right.aligned > span:nth-child(2) > i", 5);

            DeleteLanguages.Click();
            

        }
    }
}
