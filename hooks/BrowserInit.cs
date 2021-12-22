using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace TestProject1.hooks
{
    [Binding]
    public sealed class BrowserInit
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeScenario]
        public void BeforeScenarioWithTag()
        {
            bd.driver  = new ChromeDriver();
            bd.driver.Manage().Window.Maximize();
            bd.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }


        [AfterScenario]
        public void AfterScenario()
        {
            bd.driver.Close();
        }
    }
}