using MarcTaskSecond.util;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MarcTaskSecond.Pages
{
    class SkillsPage
    {
        public SkillsPage()
        {
            PageFactory.InitElements(CommonDriver.driver, this);
        }

        // navigate to skills tab............
        //Click on skill tab.....

        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.top.attached.tabular.menu > a:nth-child(2)")]
        private IWebElement ClickSkills { get; set; }

        //Click on Add new to add new skill
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > thead > tr > th.right.aligned > div")]
        private IWebElement AddNewSkill { get; set; }

      

        //Enter the Skill on text box
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > div:nth-child(1) > input[type=text]")]
        private IWebElement EditNewSkills { get; set; }

        //Click on skill level dropdown
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > div:nth-child(2) > select > option:nth-child(1)")]
        private IWebElement SelectSkillsDropDown { get; set; }

        //Choose the skill level option
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > div:nth-child(2) > select > option:nth-child(2)")]
        private IWebElement SelectedSkills { get; set; }

        //Add Skill
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > span > input.ui.teal.button")]
        private IWebElement AddSelectedSkills { get; set; }
       // upadate add skills
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody > tr > td.right.aligned > span:nth-child(1) > i")]
        private IWebElement ClickUpdateSkills { get; set; }
      //  dropdown for update new skills
       // [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eighcolumn > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody > tr > td > div > div:nth-child(1) > input[type=text]")]
       //  private IWebElement UpdateNewSkills { get; set; }
        [FindsBy(How = How.Name, Using = "name")]
        private IWebElement UpdateNewSkills { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody > tr > td > div > div:nth-child(2) > select")]
        private IWebElement DropDownForUpdateSkills { get; set; }
        // update skills
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody > tr > td > div > div:nth-child(2) > select > option:nth-child(4)")]
        private IWebElement UpdateSkill { get; set; }
        // clock upadate skills button
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody > tr > td > div > span > input.ui.teal.button")]
        private IWebElement ClickUpdateSkillsButton { get; set; }
        //delete skills...
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.top.attached.tabular.menu > a:nth-child(2)")]
        private IWebElement DeleteEditedSkill { get; set; }

        //Read data from Excel
        private string skill = ExcelLib.ReadData(1, "Skill");
        private string skillmessage = ExcelLib.ReadData(1, "SkillMessage");
        private string editskill = ExcelLib.ReadData(1, "EditSkill");


        public void AddSkills(IWebDriver driver)
        {
            Wait.ElementExist(driver, "CssSelector", "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.top.attached.tabular.menu > a:nth-child(2)", 10);
            ClickSkills.Click();
            AddNewSkill.Click();
            EditNewSkills.SendKeys(skill);
            SelectSkillsDropDown.Click();
            SelectedSkills.Click();
            AddSelectedSkills.Click();
            Thread.Sleep(2000);
        }
       

        public void UpdateSkills(IWebDriver driver)
        {
            // upadate skills
            Wait.ElementExist(driver, "CssSelector", "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody > tr > td.right.aligned > span:nth-child(1) > i", 10);

            ClickUpdateSkills.Click();
            //UpdateNewSkills.Clear();
            // Thread.Sleep(8000);
            Wait.ElementExist(driver, "Name", "name", 5);
            UpdateNewSkills.SendKeys(editskill);
            DropDownForUpdateSkills.Click();
            UpdateSkill.Click();
            ClickUpdateSkillsButton.Click();
           
        }

        public void DeleteSkills(IWebDriver driver)
        {
            Wait.ElementExist(driver, "CssSelector", "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.top.attached.tabular.menu > a:nth-child(2)", 5);

            DeleteEditedSkill.Click();
        }

           




           



           

    }

}
