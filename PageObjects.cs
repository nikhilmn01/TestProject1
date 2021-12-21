using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
	internal class temp_po
	{
        public temp_po(IWebDriver driver)
        {
			PageFactory.InitElements(driver, this);
        }

		[FindsBy(How = How.XPath, Using = "//a[text()='Sign in']")]
		public IWebElement sigin_icon { get; set; }

		[FindsBy(How = How.XPath, Using = "//input[@type='email']")]
		public IWebElement username { get; set; }

		[FindsBy(How = How.XPath, Using = "//input[@type='submit']")]
		public IWebElement uname_next { get; set; }

		[FindsBy(How = How.XPath, Using = "//input[@type='password']")]
		public IWebElement password { get; set; }

		[FindsBy(How = How.XPath, Using = "//input[@value='Sign in']")]
		public IWebElement sigin_btn { get; set; }

		[FindsBy(How = How.XPath, Using = "//input[@value='No']")]
		public IWebElement dailogue_no { get; set; }

		[FindsBy(How = How.XPath, Using = "//span[text()='Inbox']")]
		public IWebElement validate_login { get; set; }









		[FindsBy(How = How.XPath, Using = "//div[@id='passwordError']")]
		public IWebElement pwd_error { get; set; }

		[FindsBy(How = How.XPath, Using = "//span[text()='New message']")]
		public IWebElement new_message { get; set; }

		[FindsBy(How = How.XPath, Using = "//input[@aria-label='To']")]
		public IWebElement to { get; set; }

		[FindsBy(How = How.XPath, Using = "//span[text()='Cc']")]
		public IWebElement cc_click { get; set; }

		[FindsBy(How = How.XPath, Using = "//input[@aria-label='Cc']")]
		public IWebElement cc { get; set; }

		[FindsBy(How = How.XPath, Using = "//input[@placeholder='Add a subject']")]
		public IWebElement sub { get; set; }

		[FindsBy(How = How.XPath, Using = "//div[@aria-label='Message body']")]
		public IWebElement body { get; set; }

		[FindsBy(How = How.XPath, Using = "//span[text()='Send']")]
		public IWebElement send { get; set; }

		[FindsBy(How = How.XPath, Using = "//span[contains(text(),'This message must have at least one recipient.')]")]
		public IWebElement recepient_error { get; set; }

		[FindsBy(How = How.XPath, Using = "//a[text()='My Account']")]
		public IWebElement my_acc_t1 { get; set; }

		[FindsBy(How = How.Id, Using = "username")]
		public IWebElement uname_t1 { get; set; }

		[FindsBy(How = How.Id, Using = "password")]
		public IWebElement pwd_t1 { get; set; }

		[FindsBy(How = How.XPath, Using = "//input[@name='login']")]
		public IWebElement login_t1 { get; set; }

		[FindsBy(How = How.XPath, Using = "//a[text()='Dashboard']")]
		public IWebElement validate_t1 { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='reg_email']")]
        public IWebElement reg_email { get; set; }

		[FindsBy(How = How.XPath, Using = "//input[@id='reg_password']")]
		public IWebElement reg_pwd { get; set; }

		[FindsBy(How = How.XPath, Using = "//input[@name='register']")]
		public IWebElement reg_btn { get; set; }

		//This is just to make the copy pasting easy
		//[FindsBy(How = How.XPath, Using = "hdbfhsbdifbsihbsdfhb")]
		//public IWebElement sdabfiusbdfbsdfuibysu { get; set; }


	}
}
