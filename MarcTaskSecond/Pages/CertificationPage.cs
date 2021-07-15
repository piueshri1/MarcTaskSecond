using MarcTaskSecond.util;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarcTaskSecond.Pages
{
    class CertificationPage
    {
        public CertificationPage()
        {
            PageFactory.InitElements(CommonDriver.driver, this);
        }

        //click on Certificate tab.................
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.top.attached.tabular.menu > a:nth-child(4)")]
        private IWebElement OnClickCertiTab { get; set; }

        //Add new Certificate
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div.row > div.twelve.wide.column.scrollTable > div > table > thead > tr > th.right.aligned > div")]
        private IWebElement AddNewCerti { get; set; }

        //Enter Certification Name
        [FindsBy(How = How.Name, Using = "certificationName")]
        private IWebElement EnterCerti { get; set; }

        //Certified from
        [FindsBy(How = How.Name, Using = "certificationFrom")]
        private IWebElement CertiFrom { get; set; }

        //Year
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div.row > div.twelve.wide.column.scrollTable > div > div > div:nth-child(2) > div.three.wide.field > select > option.hidden")]
        private IWebElement CertiYear { get; set; }

        //Choose Opt from Year
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div.row > div.twelve.wide.column.scrollTable > div > div > div:nth-child(2) > div.three.wide.field > select > option:nth-child(8)")]
        private IWebElement CertiYearOpt { get; set; }

        //Add Ceritification
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div.row > div.twelve.wide.column.scrollTable > div > div > div.five.wide.field > input.ui.teal.button")]
        private IWebElement AddCerti { get; set; }

        //Read data from Excel
        private string certificate = ExcelLib.ReadData(1, "Certificate");
        private string certifiedfrom = ExcelLib.ReadData(1, "CertifiedFrom");
        private string certificatemessage = ExcelLib.ReadData(1, "CertificateMessage");
        private string editcertificate = ExcelLib.ReadData(1, "EditCertificate");

        public void AddCertification(IWebDriver driver)
        {
            Wait.ElementExist(driver, "CssSelector", "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.top.attached.tabular.menu > a:nth-child(4)", 5);

            OnClickCertiTab.Click();
            AddNewCerti.Click();
            EnterCerti.SendKeys(certificate);
            CertiFrom.SendKeys(certifiedfrom);
            CertiYear.Click();
            CertiYearOpt.Click();
            AddCerti.Click();
        }

    }
}
