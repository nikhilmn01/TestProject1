using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TestProject1;
using System;
using System.Threading;

namespace TestProject1
{
	public class temp
	{
		string uname = "nmntest1";
		string pwd = "Test_at_qualitest";
		string url = "http://practice.automationtesting.in/";
		string url2 = "https://outlook.live.com/owa/";

		[Test]
		public void validLogin()
		{
			IWebDriver driver = new ChromeDriver();
			driver.Navigate().GoToUrl(url2);
			driver.Manage().Window.Maximize();
			driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

			temp_po obj = new temp_po(driver);

			obj.sigin_icon.Click();
			obj.username.SendKeys(uname + "@outlook.com");
			obj.uname_next.Click();
            Thread.Sleep(2000);
			obj.password.SendKeys(pwd);
            Console.WriteLine("asdasd");
			obj.sigin_btn.Click();
            obj.dailogue_no.Click();
            bool flag = obj.validate_login.Displayed;
            Assert.IsTrue(flag);
        }

    }
}