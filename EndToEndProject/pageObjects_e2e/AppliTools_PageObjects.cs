using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.EndToEndProject.pageObjects_e2e
{
    public class AppliTools_PageObjects
    {

        public AppliTools_PageObjects(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

    
        [FindsBy(How = How.XPath, Using = "//button[@class='play']")]
        public IWebElement play_btn { get; set; }

        [FindsBy(How = How.XPath, Using = "//div/iframe[@title='Applitools Visual AI Overview Video']")]
        public IWebElement iFrame_main { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='player']")]
        public IWebElement iFrame_sub { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@class='ytp-play-button ytp-button']")]
        public IWebElement iFrame_sub_play { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='Replay']")]
        public IWebElement iFrame_sub_replay { get; set; }

        //div[@class='scrollable-menu']

        [FindsBy(How = How.XPath, Using = "//a[text()='Login']")]
        public IWebElement login_icon { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@type='email']")]
        public IWebElement email { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='password']")]
        public IWebElement password { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@type='submit']")]
        public IWebElement login_btn { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='icon ai ai-batch-summary-view']")]
        public IWebElement batchSummaryView { get; set; }

        [FindsBy(How = How.XPath, Using = "//h2[text()='Test results status']")]
        public IWebElement batchSummaryView_validate { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@class='icon ai ai-sessions-view']")]
        public IWebElement sessionView { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='carousel-top-section']")]
        public IWebElement sessionView_validation { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='icon ai ai-gallery-view']")]
        public IWebElement galleryView { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='gallery-view-item']")]
        public IWebElement galleryView_validation { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='icon ai ai-collaboration']")]
        public IWebElement remarksView { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='empty-display']")]
        public IWebElement remarksView_validation { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='icon ai ai-profile']")]
        public IWebElement profile_Btn { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[text()='Log out']")]
        public IWebElement logout { get; set; }

        [FindsBy(How = How.XPath, Using = "//i[@class='ai ai-intercom']")]
        public IWebElement message_send_icon { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='icon ai ai-chevron-down dropdown-icon']")]
        public IWebElement dropdown_arrow { get; set; }





    }
}
