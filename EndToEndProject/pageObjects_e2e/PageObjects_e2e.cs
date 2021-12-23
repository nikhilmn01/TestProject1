using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.EndToEndProject
{
    public class PageObjects_e2e
    {

        public PageObjects_e2e(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        //Page objects for home page tabs 

        [FindsBy(How = How.XPath, Using = "//div[@id='cssmenu']/ul/li/a[text()='Hire Me']")]
        public IWebElement hireMe_tab { get; set; }

        [FindsBy(How = How.XPath, Using = "//h1[text()='Consultancy Can Work Quickly and Effectively']")]
        public IWebElement validate_hireMe { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='cssmenu']/ul/li/a[text()='e-Training']")]
        public IWebElement e_training_tab { get; set; }

        [FindsBy(How = How.XPath, Using = "//h1[text()='Learn More About Our Online Training']")]
        public IWebElement validate_e_training_tab { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='cssmenu']/ul/li/a[text()='Books']")]
        public IWebElement books_tab { get; set; }

        [FindsBy(How = How.XPath, Using = "//h1[text()='Books written by Alan Richardson']")]
        public IWebElement validate_books_tab { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='cssmenu']/ul/li/a[text()='Face to Face']")]
        public IWebElement face_to_face_tab { get; set; }

        [FindsBy(How = How.XPath, Using = "//h1[text()='Training']")]
        public IWebElement validate_face_to_face { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='cssmenu']/ul/li/a[text()='About']")]
        public IWebElement about_tab { get; set; }

        [FindsBy(How = How.XPath, Using = "//h1[text()='Boutique Consultancy']")]
        public IWebElement validate_about { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='cssmenu']/ul/li/a[text()='Contact']")]
        public IWebElement contact_tab { get; set; }

        [FindsBy(How = How.XPath, Using = "//h1[text()='Contact Us']")]
        public IWebElement validate_contact { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='cssmenu']/ul/li/a[text()='Join e-mail List']")]
        public IWebElement email_list { get; set; }

        [FindsBy(How = How.XPath, Using = "//h2[text()='Subscribe to our mailing list']")]
        public IWebElement validate_email_list { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='cssmenu']/ul/li/a[text()='Blog']")]
        public IWebElement blog_tab { get; set; }

        [FindsBy(How = How.XPath, Using = "//h2[contains(text(),'Blog Posts')]")]
        public IWebElement validate_blog { get; set; }


        //Page objects for icons

        [FindsBy(How = How.XPath, Using = "//div[@class='topright']/div/p/a/img[@alt='Connect via email']")]
        public IWebElement email_icon { get; set; }

        [FindsBy(How = How.XPath, Using = "//h1[text()='Contact Us']")]
        public IWebElement email_icon_validate { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='topright']/div/p/a/img[@alt='Follow on Twitter']")]
        public IWebElement twitter_icon { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@aria-label='Twitter']")]
        public IWebElement twitter_icon_validate { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='topright']/div/p/a/img[@alt='Subscribe to my YouTube Channel']")]
        public IWebElement youTube_icon { get; set; }

        [FindsBy(How = How.XPath, Using = "//tp-yt-paper-button/yt-formatted-string[text()='Cancel']")]
        public IWebElement youTube_popUp { get; set; }

        [FindsBy(How = How.XPath, Using = "//yt-icon[@id = 'logo-icon']")]
        public IWebElement youTube_icon_validate { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='topright']/div/p/a/img[@alt='Connect on LinkedIn']")]
        public IWebElement linkedIn_icon { get; set; }

        [FindsBy(How = How.XPath, Using = "//img[@alt='LinkedIn']")]
        public IWebElement linkedIn_icon_validate { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='topright']/div/p/a/img[@alt='Follow on GitHub']")]
        public IWebElement gitHub_icon { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@href='https://github.com/']")]
        public IWebElement gitHub_icon_validate { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='topright']/div/p/a/img[@alt='Follow on Pinterest']")]
        public IWebElement pintrest_icon { get; set; }

        [FindsBy(How = How.XPath, Using = "//h2[text()='Pinterest']")]
        public IWebElement pintrest_icon_validate { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='topright']/div/p/a/img[@alt='Follow on Instagram']")]
        public IWebElement inst_icon { get; set; }

        [FindsBy(How = How.XPath, Using = "//img[@alt='Instagram']")]
        public IWebElement inst_icon_validate { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='topright']/div/p/a/img[@alt='Follow on Facebook']")]
        public IWebElement facebook_icon { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@href='https://www.facebook.com/']")]
        public IWebElement facebook_icon_validate { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='topright']/div/p/a/img[@alt='Subscribe to my RSS Feed']")]
        public IWebElement rss_icon { get; set; }


        //Individual elements



        [FindsBy(How = How.XPath, Using = "//a[text()='My name is Alan Richardson. How do you want to improve?']")]
        public IWebElement Richardson_link { get; set; }


        [FindsBy(How = How.XPath, Using = "//p/a[text()='Join Our Email List']")]
        public IWebElement join_email_list { get; set; }

        

        [FindsBy(How = How.XPath, Using = "//a[text()='EvilTester Blog']")]
        public IWebElement evil_tester_blog { get; set; }


        [FindsBy(How = How.XPath, Using = "//a[text()='25 Years experience']")]
        public IWebElement experience { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[text()='17000+ Students taught online']")]
        public IWebElement students_taught_online { get; set; }

        
        [FindsBy(How = How.XPath, Using = "//a[text()='4 books authored']")]
        public IWebElement books_authored { get; set; }

        // iFrames

        [FindsBy(How = How.XPath, Using = "//div[@class='thumbCellSplit']//iframe")]
        public IWebElement iframe { get; set; }


        [FindsBy(How = How.XPath, Using = "//div/label[text()='Name']")]
        public IWebElement name_iFrame { get; set; }

        [FindsBy(How = How.XPath, Using = "//div/label[text()='Email']")]
        public IWebElement email_iFrame { get; set; }

        [FindsBy(How = How.XPath, Using = "//textarea[@name='message']")]
        public IWebElement message_iFrame { get; set; }

        //[FindsBy(How = How.XPath, Using = "Paste_your_XPATH_Here")]

        [FindsBy(How = How.XPath, Using = "//div[@aria-labelledby='sendtextSpan']")]
        public IWebElement send_iFrame { get; set; }

        //[FindsBy(How = How.XPath, Using = "Paste_your_XPATH_Here")]
        //public IWebElement Enter_your_element_name_here { get; set; }

        //[FindsBy(How = How.XPath, Using = "Paste_your_XPATH_Here")]
        //public IWebElement Enter_your_element_name_here { get; set; }

        //[FindsBy(How = How.XPath, Using = "Paste_your_XPATH_Here")]
        //public IWebElement Enter_your_element_name_here { get; set; }
        //public IWebElement Enter_your_element_name_here { get; set; }


    }
}
