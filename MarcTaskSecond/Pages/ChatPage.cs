using MarcTaskSecond.util;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarcTaskSecond.Pages
{
    class ChatPage
    {
        private readonly ServiceDetailsPage serviceDetailPage;
        private  SearchPage searchPage;
        public ChatPage()
        {

            PageFactory.InitElements(CommonDriver.driver, this);
            searchPage = new SearchPage();
            serviceDetailPage = new ServiceDetailsPage();
        }
       

        //Finding the Sign Link
        //*[@id="service-detail-section"]/div[2]/div/div[2]/div[2]/div[1]/div/div[1]/div/a
        [FindsBy(How = How.XPath, Using = "//*[@id='chatTextBox']")]
        private IWebElement ChatTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btnSend']")]
        private IWebElement Send { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[text()='Hello I want to trade my skill']")]
        private IWebElement SentMessage { get; set; }

        //Read data from Excel
        private string chatmessage = ExcelLib.ReadData(1, "ChatMessage");


        //sending message to seller
        public void ChatWithSeller(IWebDriver driver)
        {
            searchPage.SearchSkills(driver);
            // searchPage.ClickSearchedSkill(driver);
           // serviceDetailPage.ValidateYouAreAtServiceDetailPage();
            serviceDetailPage.ClickChat();
            ValidateYouAreOnChatPage();
            EnterChatMessage(chatmessage);
            ClickSend();
            //bool isMessageSent = ValidateMessageSent(chatmessage);
            //Assert.IsTrue(isMessageSent);
        }

        public void EnterChatMessage(string chatmessage)
        {

            //enter message in chat text box
            ChatTextBox.SendKeys(chatmessage);

        }
        public void ClickSend()
        {
            //click send
            Send.Click();
        }

        public void ValidateYouAreOnChatPage()
        {
            bool isChatRoom = ChatTextBox.Displayed;
            Assert.IsTrue(isChatRoom);
        }

        public bool ValidateMessageSent(string chatmessage)
        {
            //validate message is sent to seller
            if (SentMessage.Text == chatmessage)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
