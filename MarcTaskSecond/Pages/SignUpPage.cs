using MarcTaskSecond.util;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Threading;

namespace MarcTaskSecond.Pages
{
    class SignUpPage
    {
        // page Object for SignUpPage.....

        public SignUpPage()
        {
            PageFactory.InitElements(CommonDriver.driver, this);
        }

      

        //Find signUp link

        [FindsBy(How = How.XPath, Using = "//*[@id='home']/div/div/div[1]/div/button")]
        private IWebElement SignUpLink { get; set; }


        // enter first name 
        [FindsBy(How = How.Name, Using = "firstName")]
        private IWebElement FirstName { get; set; }

        // enter lastnamE...
        [FindsBy(How = How.Name, Using = "lastName")]
        private IWebElement LastName { get; set; }

        //enter email addeess
        [FindsBy(How = How.Name, Using = "email")]
        private IWebElement EmailAddress { get; set; }

        // enter password
        [FindsBy(How = How.Name, Using = "password")]
        private IWebElement Password { get; set; }

        //enter confirm password
        [FindsBy(How = How.Name, Using = "confirmPassword")]
        private IWebElement ConfirmPassword { get; set; }

        // agree for term and condition
        [FindsBy(How = How.Name, Using = "terms")]
        private IWebElement AgreeForTermCondition { get; set; }

        //click join button
        [FindsBy(How = How.Id, Using = "submit-btn")]
        private IWebElement ClickJoinButton { get; set; }

        //Read Data from Excel
        private string firstName = ExcelLib.ReadData(1, "FirstName");
        private string lastName = ExcelLib.ReadData(1, "LastName");
        private string email = ExcelLib.ReadData(1, "Email");
        private string userpassword = ExcelLib.ReadData(1, "UserPassword");
        private string confirmregPassword = ExcelLib.ReadData(1, "ConfirmRegPassword");

        public void Register(IWebDriver driver)
        {
            // Thread.Sleep(2000);
            driver.Navigate().GoToUrl(ConstantClass.Url);
            //  Wait.ElementExist(driver, "XPath", "//*[@id='home']/div/div/div[1]/div/button", 5);
            Thread.Sleep(8000);
            SignUpLink.Click();
            FirstName.SendKeys(firstName);
            LastName.SendKeys(lastName);
            EmailAddress.SendKeys(email);
            Password.SendKeys(userpassword);
            ConfirmPassword.SendKeys(confirmregPassword);
            AgreeForTermCondition.Click();
            ClickJoinButton.Click();

        }

      
    }
}
