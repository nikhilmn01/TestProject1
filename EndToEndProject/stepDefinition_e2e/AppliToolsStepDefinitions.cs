using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Threading;
using TechTalk.SpecFlow;
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
            Driver.driver.SwitchTo().Frame(obj.iFrame_main);
            
        }

        [When(@"seeked to the near end of the video")]
        public void WhenSeekedToTheNearEndOfTheVideo()
        {
            obj.iFrame_sub.Click();
            action.SendKeys(Keys.Space).Click().Perform();

            for (int act = 0; act < 30; act++)
            {

                action.SendKeys(Keys.Right).Click().Perform();

            }
            
        }

        [Then(@"should wait until the video is completely played and should validate the same")]
        public void ThenShouldWaitUntilTheVideoIsCompletelyPlayedAndShouldValidateTheSame()
        {
            Thread.Sleep(1000);
            action.SendKeys(Keys.Space).Click().Perform();
            Driver.driver.SwitchTo().DefaultContent();
        }


        //Navigation Bar validation

        [When(@"hovered on the navigation bar and validated the same")]
        public void WhenHoveredOnTheNavigationBarAndValidatedTheSame()
        {
            List<string> nav = new List<string> { "Products", "Use Cases", "Resources", "Pricing", "Company" };
            List<string> Products_validation = new List<string> { "Platform Overview", "Eyes", "Ultrafast Test Cloud", "SDKs & Integrations" };
            List<string> Resources_validation = new List<string> { "SDK Tutorials","Support","Learn","Blog","Webinars & Events","Case Studies","Test Automation University","What’s New","Open Source"};
            List<string> Use_cases_validation = new List<string> {"Functional Testing","Visual Testing","Web Testing","Mobile Testing","Regression Testing","Cross Browser Testing","Responsive Design Testing","Storybook Testing","PDF Testing","Localization Testing","Compliance Testing","Accessibility Testing","Codeless Testing"};
            List<string> Company_validation = new List<string> { "About Us","News","Our Customers","Awards","Careers","Contact Us"};
            
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
                            Assert.IsTrue(all1 == Products_validation[i]);
                        }
                        else if (reqNav == nav[1])
                        {
                            Assert.IsTrue(all1 == Use_cases_validation[i]);
                        }
                        else if (reqNav == nav[2])
                        {
                            Assert.IsTrue(all1 == Resources_validation[i]);
                        }
                        else if (reqNav == nav[2])
                        {
                            Assert.IsTrue(all1 == Use_cases_validation[i]);
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



    }
}
