using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace TestProject1.EndToEndProject.hooks_e2e
{
    [Binding]
    public sealed class browserInit_e2e
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeScenario]
        public void BeforeScenarioWithTag()
        {
            bd.driver = new ChromeDriver();
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