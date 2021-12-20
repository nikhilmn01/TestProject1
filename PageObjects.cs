using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
	internal class temp_po
	{
		IWebDriver driver;

		public temp_po(IWebDriver driver)
		{
			this.driver = driver;
		}

		public IWebElement sigin_icon()
		{
			return driver.FindElement(By.XPath("//a[text()='Sign in']"));
		}

		public IWebElement username()
		{
			return driver.FindElement(By.XPath("//input[@type='email']"));
		}

		public IWebElement uname_next()
		{
			return driver.FindElement(By.XPath("//input[@type='submit']"));
		}

		public IWebElement password()
		{
			return driver.FindElement(By.XPath("//input[@type='password']"));
		}

		public IWebElement sigin_btn()
		{
			return driver.FindElement(By.XPath("//input[@value='Sign in']"));
		}

		public IWebElement dailogue_no()
		{
			return driver.FindElement(By.XPath("//input[@value='No']"));
		}

		public IWebElement validate_login()
		{
			return driver.FindElement(By.XPath("//span[text()='Inbox']"));
		}

	}
}
