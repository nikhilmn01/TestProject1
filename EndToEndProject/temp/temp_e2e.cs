﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TestProject1.EndToEndProject.base_e2e;


namespace TestProject1.EndToEndProject.temp
{
    public class temp_e2e
    {
        
        [Test]

        public void runner()
        {
            //tabsValidation();
            //iconValidation();
            //youtubePlayer();
            bitCoinGraph();
        }
        public void tabsValidation()
        {
            Driver.driver = new ChromeDriver();
            Driver.driver.Manage().Window.Maximize();
            Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            PageObjects_e2e obj = new PageObjects_e2e(Driver.driver);

            Driver.driver.Navigate().GoToUrl("https://compendiumdev.co.uk/default.php");

            obj.hireMe_tab.Click();
            Assert.IsTrue(obj.validate_hireMe.Displayed);
            Driver.driver.Navigate().Back();

            obj.e_training_tab.Click();
            Assert.IsTrue(obj.validate_e_training_tab.Displayed);
            Driver.driver.Navigate().Back();

            obj.books_tab.Click();
            Assert.IsTrue(obj.validate_books_tab.Displayed);
            Driver.driver.Navigate().Back();

            obj.face_to_face_tab.Click();
            Assert.IsTrue(obj.validate_face_to_face.Displayed);
            Driver.driver.Navigate().Back();

            obj.about_tab.Click();
            Assert.IsTrue(obj.validate_about.Displayed);
            Driver.driver.Navigate().Back();

            obj.contact_tab.Click();
            Assert.IsTrue(obj.validate_contact.Displayed);
            Driver.driver.Navigate().Back();

            obj.email_list.Click();
            Assert.IsTrue(obj.validate_email_list.Displayed);
            Driver.driver.Navigate().Back();

            obj.blog_tab.Click();
            Assert.IsTrue(obj.validate_blog.Displayed);
            Driver.driver.Navigate().Back();

            Thread.Sleep(2000);
            Driver.driver.Close();
        }

        public void iconValidation()
        {
            Driver.driver = new ChromeDriver();
            Driver.driver.Manage().Window.Maximize();
            Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            PageObjects_e2e obj = new PageObjects_e2e(Driver.driver);

            Driver.driver.Navigate().GoToUrl("https://compendiumdev.co.uk/default.php");

            obj.email_icon.Click();
            Assert.IsTrue(obj.email_icon_validate.Displayed);
            Driver.driver.Navigate().Back();

            obj.twitter_icon.Click();
            Assert.IsTrue(obj.twitter_icon_validate.Displayed);
            Driver.driver.Navigate().Back();

            obj.youTube_icon.Click();
            obj.youTube_popUp.Click();
            Assert.IsTrue(obj.youTube_icon_validate.Displayed);
            Driver.driver.Navigate().Back();

            obj.linkedIn_icon.Click();
            Assert.IsFalse(obj.linkedIn_icon_validate.Displayed);
            Driver.driver.Navigate().Back();

            obj.gitHub_icon.Click();
            Assert.IsTrue(obj.gitHub_icon_validate.Displayed);
            Driver.driver.Navigate().Back();

            obj.pintrest_icon.Click();
            Assert.IsTrue(obj.pintrest_icon_validate.Displayed);
            Driver.driver.Navigate().Back();

            obj.inst_icon.Click();
            Assert.IsTrue(obj.inst_icon_validate.Displayed);
            Driver.driver.Navigate().Back();

            obj.facebook_icon.Click();
            Assert.IsTrue(obj.facebook_icon_validate.Displayed);
            Driver.driver.Navigate().Back();

            obj.rss_icon.Click();
            Assert.IsFalse(false);
            Driver.driver.Navigate().Back();


            Thread.Sleep(2000);
            Driver.driver.Close();



        }

        public void youtubePlayer()
        {
            //var nav[2] = {"Products","Use Cases"};
            //var nav = new List<string>();
            List<string> nav = new List<string> { "Products", "Use Cases", "Resources", "Pricing", "Company" };
            List<string> Products_validation = new List<string> { "Platform Overview", "Eyes", "Ultrafast Test Cloud", "SDKs & Integrations" };


           
            Driver.driver = new ChromeDriver();
            Driver.driver.Manage().Window.Maximize();
            Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Actions action = new Actions(Driver.driver);

            Driver.driver.Navigate().GoToUrl("https://applitools.com/");
            //Driver.driver.FindElement(By.XPath("//*[name()='path'][@fill='#FF0476']")).Click();
            Driver.driver.FindElement(By.XPath("//button[@class='play']")).Click();
            Thread.Sleep(1000);
            Driver.driver.SwitchTo().Frame(Driver.driver.FindElement(By.XPath("//div/iframe[@title='Applitools Visual AI Overview Video']")));
            //Driver.driver.SwitchTo().Frame(Driver.driver.FindElement(By.Id("player")));

            Driver.driver.SwitchTo().Frame(Driver.driver.FindElement(By.XPath("//*[@id='player']")));



            

            //iframe[@id='player']
            //Driver.driver.FindElement(By.XPath("//iframe")).Click();

            Driver.driver.FindElement(By.XPath("//button[@class='ytp-play-button ytp-button']")).Click();

            IWebElement ele = Driver.driver.FindElement(By.XPath("//div[@class='ytp-scrubber-container']"));

            int xcord = ele.Location.X;
            int ycord = ele.Location.Y;

            action.MoveByOffset(350, ycord).Perform();
            Thread.Sleep(1000);
            action.Click();

            action.SendKeys(Keys.NumberPad9).Perform();
            action.SendKeys(Keys.Space).Perform();

            WebDriverWait wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(15));

            wait.Until(driver => Driver.driver.FindElement(By.XPath("//button[@aria-label='Replay']")).Displayed);

            //Thread.Sleep(15000);
            //Driver.driver.FindElement(By.XPath("//button[@aria-label='Replay']"));
            Assert.IsTrue(Driver.driver.FindElement(By.XPath("//button[@aria-label='Replay']")).Displayed);

            //action.SendKeys(Keys.).Click().Perform();

            //Actions action2 = new Actions(Driver.driver);

            //IWebElement ele = Driver.driver.FindElement(By.XPath("//div[@class='ytp-scrubber-container']"));
            
            ////div[@class='ytp-progress-bar-container']
            //int xcord = ele.Location.X;
            //int ycord = ele.Location.Y;
  
            ////action2.MoveByOffset(300, 457).Perform();
            //action2.MoveByOffset(xcord + 180, ycord).Perform();
            ////Thread.Sleep(5000);
            //action2.Click();
            //action.SendKeys(Keys.NumberPad9).Click().Perform();

            //for (int act = 0; act < 30; act++)
            //{
                
            //    action.SendKeys(Keys.ArrowRight).Click().Perform();

            //}
            //Thread.Sleep(1000);
            //action.SendKeys(Keys.Space).Click().Perform();
            Driver.driver.SwitchTo().DefaultContent();

            


            //for (int req = 0; req < nav.Count; req++) 
            //{
            //    string reqNav = nav[req];
            //    action.MoveToElement(Driver.driver.FindElement(By.XPath("//a[text()='" + reqNav + "']"))).Perform();
            //    //a[text()='Products']/parent::li/ul/li
            //    //Driver.driver.FindElements(By.XPath("//a[text()='" + reqNav + "']/parent::li/ul/li"));

            //    if (reqNav != nav[3])
            //    {


            //    var ele = Driver.driver.FindElements(By.XPath("//a[text()='" + reqNav + "']/parent::li/ul/li"));

            //        for (int i = 0; i < ele.Count; i++)
            //        {

            //            String all1 = ele[i].Text;
            //            if (reqNav == nav[0])
            //            {
            //                var splitString = all1.Split("\r");
            //                all1 = splitString[0];
            //                Assert.IsTrue(all1 == Products_validation[i]);
            //            }
            //            Console.WriteLine(all1);
            //        }


            //    }
            //    else if (reqNav == nav[3])
            //    {
            //        Console.WriteLine("There is no sub elements to validate");
            //    }
            //}

            Thread.Sleep(2000);
            Driver.driver.Close();
        }
        
        public void bitCoinGraph()
        {
            Driver.driver = new ChromeDriver();
            Driver.driver.Manage().Window.Maximize();
            Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            Driver.driver.Navigate().GoToUrl("https://www.coindesk.com/price/bitcoin/");

            Actions action = new Actions(Driver.driver);

            IWebElement element = Driver.driver.FindElement(By.XPath("(//*[local-name()='svg']//*[@class='highcharts-series highcharts-series-0 highcharts-area-series'])[1]"));
            //X and Y co-ordinates to hover through the graph
            int Y = ((element.Size.Height) / 2);
            int X = ((element.Size.Width) / 2);
            string date = "2 ";
            string month = "Jan 2022";
            string time = " 22:14";
            string time2 = " 22:15";
            string input = date.Trim()+" Dec 2021, "+time.Trim()+" GMT+5:30";
            string inputA = date.Trim() + " "+month.Trim()+", " + time.Trim() + " GMT+5:30";
            string inputB = date.Trim() + " " + month.Trim() + ", " + time2.Trim() + " GMT+5:30";
            string input2 = date.Trim() + " Dec 2021, " + time2.Trim() + " GMT+5:30";
            string compare = "30 Dec 2021, 03:08 GMT+5:30";
            string compare2 = "30 Dec 2021, 03:09 GMT+5:30";
            bool flag = (compare == inputA || inputB == compare2);

            Driver.driver.FindElement(By.XPath("//*[local-name()='svg']//*[@class='highcharts-series highcharts-series-0 highcharts-area-series']")).Click();

            for (int i = 0; i < element.Size.Width; i++)
            {

                action.MoveToElement(element, X + i, Y + i).Perform();
                string data = Driver.driver.FindElement(By.XPath("//div[@class=('highcharts-label highcharts-tooltip chart-tooltip highcharts-color-undefined')]/span/span[@class='date']")).Text;
                if (data == inputA || data == inputB)
                {
                    Console.WriteLine(Driver.driver.FindElement(By.XPath("//div[@class=('highcharts-label highcharts-tooltip chart-tooltip highcharts-color-undefined')]/span/span[@class='price']")).Text);
                    break;
                }
                //if(data == test1.ToString("d MMM yyyy, HH:mm 'GMT+5:30'"))
                //{
                //    Console.WriteLine(driver.FindElement(By.XPath("//div[@class=('highcharts-label highcharts-tooltip chart-tooltip highcharts-color-undefined')]/span/span[@class='price']")).Text);
                //    break;
                //}

            }

            Driver.driver.Close();




        }
    }
}
