using NUnit.Framework;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace TestProject1
{
    [Binding]
    public class SampleStepDefinitions
    {

        string uname = "nmntest1";
        string pwd = "Test_at_qualitest";
        string url = "http://practice.automationtesting.in/";
        string url2 = "https://outlook.live.com/owa/";

        temp_po obj = new temp_po(bd.driver);

        private static readonly log4net.ILog log =log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);


        //Practice site Register

        [Given(@"to register_username:""([^""]*)"" and password:""([^""]*)"" is given")]
        public void GivenToRegister_UsernameAndPasswordIsGiven(string reg_uname, string reg_pwd)
        {
            bd.driver.Navigate().GoToUrl(url);

            obj.my_acc_t1.Click();
            obj.reg_email.SendKeys(reg_uname + "@test.com");
            log.Info("******************************************kdbfksbdfkbfdkb*************************");
            obj.reg_pwd.SendKeys(reg_pwd);
        }

        [When(@"user register to the site")]
        public void WhenUserRegisterToTheSite()
        {
            obj.reg_btn.Click();
        }

        [Then(@"verify the registration")]
        public void ThenVerifyTheRegistration()
        {
           Assert.IsTrue(obj.validate_t1.Displayed);
        }


        //practice site login

        [Given(@"username:""([^""]*)"" and password:""([^""]*)"" is given")]
        public void GivenUsernameAndPasswordIsGiven(string username, string password)
        {
            bd.driver.Navigate().GoToUrl(url);
            log.Info("******************************************kdbfksbdfkbfdkb*************************");

            obj.my_acc_t1.Click();
            obj.uname_t1.SendKeys(username);
            obj.pwd_t1.SendKeys(password);
        }

        [When(@"user login to the site")]
        public void WhenUserLoginToTheSite()
        {
            obj.login_t1.Click();
        }

        [Then(@"verify the login")]
        public void ThenVerifyTheLogin()
        {
            Assert.IsTrue(obj.validate_t1.Displayed);
        }


        //outlook login

        [Given(@"user outlook ID:""([^""]*)"" and password:""([^""]*)"" is given")]
        public void GivenUserOutlookIDAndPasswordIsGiven(string uname, string pwd)
        {

            bd.driver.Navigate().GoToUrl(url2);
            obj.sigin_icon.Click();
            obj.username.SendKeys(uname + "@outlook.com");
            obj.uname_next.Click();
            Thread.Sleep(2000);
            obj.password.SendKeys(pwd);
            obj.sigin_btn.Click();
        }

        [When(@"user login to outlook")]
        public void WhenUserLoginToOutlook()
        {
            obj.dailogue_no.Click();
        }

        [Then(@"verify user is able to login successfully")]
        public void ThenVerifyUserIsAbleToLoginSuccessfully()
        {
            bool flag = obj.validate_login.Displayed;
            Assert.IsTrue(flag);
        }

        //outlook invalid login

        [When(@"usertry to login to outlook")]
        public void WhenUsertryToLoginToOutlook()
        {
            obj.sigin_btn.Click();
        }

        [Then(@"verify error message is shown")]
        public void ThenVerifyErrorMessageIsShown()
        {
            obj.sigin_btn.Click();

            Assert.IsTrue(obj.pwd_error.Displayed);
        }

        //message sending - outlook

        [Given(@"upon successful login")]
        public void GivenUponSuccessfulLogin()
        {
            
            obj.dailogue_no.Click();
            Assert.IsTrue(obj.validate_login.Displayed);
        }

        [When(@"user try to send the mail")]
        public void WhenUserTryToSendTheMail()
        {
            obj.new_message.Click();
            obj.to.SendKeys(uname + "@outlook.com");
            obj.cc_click.Click();
            obj.cc.SendKeys(uname + "@outlook.com");
            obj.sub.SendKeys("sampleTest c#");
            obj.body.SendKeys("Hello World C#");
            obj.send.Click();
        }

        [Then(@"message should be sent successfully")]
        public void ThenMessageShouldBeSentSuccessfully()
        {
            Console.WriteLine("Message sent");
        }


        //invalid Message sending -  outlook

        [When(@"user try to send the mail without recepient email id")]
        public void WhenUserTryToSendTheMailWithoutRecepientEmailId()
        {
            obj.new_message.Click();
            obj.sub.SendKeys("sampleTest");
            obj.body.SendKeys("Hello World");
            obj.send.Click();
        }

        [Then(@"error message should be shown successfully")]
        public void ThenErrorMessageShouldBeShownSuccessfully()
        {
            Assert.IsTrue(obj.recepient_error.Displayed);
        }



    }
}
