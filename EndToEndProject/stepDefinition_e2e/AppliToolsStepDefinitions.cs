using Newtonsoft.Json;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using TestProject1.EndToEndProject.base_e2e;
using TestProject1.EndToEndProject.pageObjects_e2e;

namespace TestProject1
{
    [Binding]
    public class AppliToolsStepDefinitions
    {
        Actions action = new Actions(Driver.driver);
        AppliTools_PageObjects obj = new AppliTools_PageObjects(Driver.driver);


        //YouTube Player Validation

        [Given(@"the url of the website ""([^""]*)""")]
        public void GivenTheUrlOfTheWebsite(string url)
        {
            Driver.driver.Navigate().GoToUrl(url);
        }

        [When(@"clicked on play button of mini player")]
        public void WhenClickedOnPlayButtonOfMiniPlayer()
        {
           obj.play_btn.Click();
            Thread.Sleep(1000);
            //Driver.driver.SwitchTo().Frame(obj.iFrame_main);
            //Driver.driver.FindElement(By.XPath("//button[@class='play']")).Click();
            //Thread.Sleep(1000);

        }

        [When(@"seeked to the near end of the video")]
        public void WhenSeekedToTheNearEndOfTheVideo()
        {
            Driver.driver.SwitchTo().Frame(Driver.driver.FindElement(By.XPath("//div/iframe[@title='Applitools Visual AI Overview Video']")));
            Driver.driver.SwitchTo().Frame(Driver.driver.FindElement(By.XPath("//*[@id='player']")));

            Driver.driver.FindElement(By.XPath("//button[@class='ytp-play-button ytp-button']")).Click();
            action.SendKeys(Keys.NumberPad9).Perform();
            action.SendKeys(Keys.Space).Perform();

            

            //IWebElement ele = Driver.driver.FindElement(By.XPath("//div[@class='ytp-scrubber-container']"));

            //int xcord = ele.Location.X;
            //int ycord = ele.Location.Y;

            //action.MoveByOffset(150, ycord).Perform();
            //Thread.Sleep(1000);
            //action.Click();

            //obj.iFrame_sub.Click();
            //action.SendKeys(Keys.Space).Click().Perform();

            //for (int act = 0; act < 30; act++)
            //{

            //    action.SendKeys(Keys.Right).Click().Perform();

            //}
            
        }

        [Then(@"should wait until the video is completely played and should validate the same")]
        public void ThenShouldWaitUntilTheVideoIsCompletelyPlayedAndShouldValidateTheSame()
        {
            WebDriverWait wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(15));

            wait.Until(driver => Driver.driver.FindElement(By.XPath("//button[@aria-label='Replay']")).Displayed);

            //Thread.Sleep(15000);
            //Driver.driver.FindElement(By.XPath("//button[@aria-label='Replay']"));
            Assert.IsTrue(Driver.driver.FindElement(By.XPath("//button[@aria-label='Replay']")).Displayed);
            Driver.driver.SwitchTo().DefaultContent();
        }
        //Navigation Bar validation

        [When(@"hovered on the navigation bar and validated the same")]
        public void WhenHoveredOnTheNavigationBarAndValidatedTheSame()
        {
            List<string> nav = new List<string> { "Products", "Use Cases", "Resources", "Pricing", "Company" };
            var e2ePath = @"C:\Users\nikhil.mn\vs-workspace\TestProject1\json\e2e_validate.json";
            dynamic jsonFile = JsonConvert.DeserializeObject(File.ReadAllText(e2ePath));

            for (int req = 0; req < nav.Count; req++)
            {
                string reqNav = nav[req];
                action.MoveToElement(Driver.driver.FindElement(By.XPath("//a[text()='" + reqNav + "']"))).Perform();

                if (reqNav != nav[3])
                {
                    var ele = Driver.driver.FindElements(By.XPath("//a[text()='" + reqNav + "']/parent::li/ul/li"));

                    for (int i = 0; i < ele.Count; i++)
                    {

                        String all1 = ele[i].Text;
                        if (reqNav == nav[0])
                        {
                            var splitString = all1.Split("\r");
                            all1 = splitString[0];
                            var list = jsonFile["products"];
                            string temp = list[i].ToString();
                            Assert.IsTrue(all1 == temp);
                        }
                        else if (reqNav == nav[1])
                        {
                            var list = jsonFile["use_case"];
                            string temp = list[i].ToString();
                            Assert.IsTrue(all1 == temp);
                        }
                        else if (reqNav == nav[2])
                        {
                            var list = jsonFile["resources"];
                            string temp = list[i].ToString();
                            Assert.IsTrue(all1 == temp);
                        }
                        else if (reqNav == nav[4])
                        {
                            var list = jsonFile["company"];
                            string temp = list[i].ToString();
                            Assert.IsTrue(all1 == temp);
                        }
                        Console.WriteLine(all1);

                    }
                }
                else if (reqNav == nav[3])
                {
                    Console.WriteLine("There is no sub elements to validate");
                }

                
            }
        }

        [Then(@"there should be no error in validation")]
        public void ThenThereShouldBeNoErrorInValidation()
        {
            Console.WriteLine("Validation successful");
        }

        //UL elements validation

        [When(@"user performs valid login with username = ""([^""]*)"" and password = ""([^""]*)""")]
        public void WhenUserPerformsValidLoginWithUsernameAndPassword(string uname, string pwd)
        {
            obj.login_icon.Click();
            obj.email.SendKeys(uname);
            obj.password.SendKeys(pwd);
            obj.login_btn.Click();

        }

        [When(@"when user performs validation on the multiple UI elements present on the home page")]
        public void WhenWhenUserPerformsValidationOnTheMultipleUIElementsPresentOnTheHomePage()
        {

            obj.batchSummaryView.Click();
            Assert.IsTrue(obj.batchSummaryView_validate.Displayed);

            obj.sessionView.Click();
            Assert.IsTrue(obj.sessionView_validation.Displayed);

            obj.remarksView.Click();
            Assert.IsTrue(obj.remarksView_validation.Displayed);

            obj.galleryView.Click();
            Assert.IsTrue(obj.galleryView_validation.Displayed);

            obj.message_send_icon.Click();
            Thread.Sleep(1000);
            obj.message_send_icon.Click();

            obj.dropdown_arrow.Click();
            var dropdownList = Driver.driver.FindElements(By.XPath(" //div[@class='scrollable-menu']"));
            var splitString = dropdownList[0].Text.Split("\r\n");

            for (int i=0;i<dropdownList.Count;i++)
            {
                string temp = splitString[i];
                Console.WriteLine(splitString[i]);
            }
        }

        [Then(@"successful logout should happen")]
        public void ThenSuccessfulLogoutShouldHappen()
        {
            obj.profile_Btn.Click();
            obj.logout.Click();
        }

        [When(@"hovered on the navigation bar item ""([^""]*)"" and validated the same")]
        public void WhenHoveredOnTheNavigationBarItemAndValidatedTheSame(string products)
        {
            
            var e2ePath = @"C:\Users\nikhil.mn\vs-workspace\TestProject1\json\e2e_validate.json";
            dynamic jsonFile = JsonConvert.DeserializeObject(File.ReadAllText(e2ePath));

            string reqNav = products;
                action.MoveToElement(Driver.driver.FindElement(By.XPath("//a[text()='" + reqNav + "']"))).Perform();

                if (reqNav != "Pricing")
                {
                    var ele = Driver.driver.FindElements(By.XPath("//a[text()='" + reqNav + "']/parent::li/ul/li"));

                    for (int i = 0; i < ele.Count; i++)
                    {

                        String all1 = ele[i].Text;
                        if (reqNav == "Products")
                        {
                            var splitString = all1.Split("\r");
                            all1 = splitString[0];
                            var list = jsonFile["products"];
                            string temp = list[i].ToString();
                            Assert.IsTrue(all1 == temp);
                        }
                        else if (reqNav == "Use Cases")
                        {
                            var list = jsonFile["use_case"];
                            string temp = list[i].ToString();
                            Assert.IsTrue(all1 == temp);
                        }
                        else if (reqNav == "Resources")
                        {
                            var list = jsonFile["resources"];
                            string temp = list[i].ToString();
                            Assert.IsTrue(all1 == temp);
                        }
                        else if (reqNav == "Company")
                        {
                            var list = jsonFile["company"];
                            string temp = list[i].ToString();
                            Assert.IsTrue(all1 == temp);
                        }
                        Console.WriteLine(all1);

                    }
                }
                else if (reqNav == "Pricing")
                {
                    Console.WriteLine("There is no sub elements to validate");
                }    
        }


    }
}
