using NUnit.Framework;
using OpenQA.Selenium.Chrome;
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
            iconValidation();
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

        
    }
}
