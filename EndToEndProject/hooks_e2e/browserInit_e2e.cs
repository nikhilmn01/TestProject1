using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using TestProject1.EndToEndProject.base_e2e;

namespace TestProject1.EndToEndProject.hooks_e2e
{
    [Binding]
    public sealed class browserInit_e2e
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeScenario]
        public void BeforeScenarioWithTag()
        {
            Driver.driver = new ChromeDriver();
            Driver.driver.Manage().Window.Maximize();
            Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Driver.driver.Close();
        }
    }
}