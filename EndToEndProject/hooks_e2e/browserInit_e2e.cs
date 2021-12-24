using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
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

        public static ExtentReports extentReports;
        public static ExtentHtmlReporter extentHtmltReporter;
        public static ScenarioContext _scenarioContext;
        public static FeatureContext _featureContext;
        public static ExtentTest _feature;
        public static ExtentTest _scenario;


        [BeforeTestRun]
        public static void Before_test_run()
        {
            extentHtmltReporter = new ExtentHtmlReporter(@"C:\Users\nikhil.mn\vs-workspace\TestProject1\EndToEndProject\index.html");
            extentReports = new ExtentReports();
            extentReports.AttachReporter(extentHtmltReporter);
        }



        [BeforeFeature]
        public static void Before_feature(FeatureContext featureContext)
        {
            if (null != featureContext)
            {
                _feature = extentReports.CreateTest<Feature>(featureContext.FeatureInfo.Title, featureContext.FeatureInfo.Description);
            }
        }

        [BeforeScenario]
        public void BeforeScenarioWithTag()
        {
            Driver.driver = new ChromeDriver();
            Driver.driver.Manage().Window.Maximize();
            Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        [BeforeScenario]
        public static void Before_scenario(ScenarioContext scenarioContext)
        {
            if (null != scenarioContext)
            {
                _scenarioContext = scenarioContext;
                _scenario = _feature.CreateNode<Scenario>(scenarioContext.ScenarioInfo.Title, scenarioContext.ScenarioInfo.Description);
            }
        }



        [AfterScenario]
        public void AfterScenario()
        {
            Driver.driver.Close();
        }

            [AfterStep]
            public static void afterEachstep()
            {
                ScenarioBlock scenarioBlock = _scenarioContext.CurrentScenarioBlock;
                switch (scenarioBlock)
                {
                    case ScenarioBlock.Given:
                        _scenario.CreateNode<Given>(_scenarioContext.StepContext.StepInfo.Text);
                        break;



                    case ScenarioBlock.When:
                        _scenario.CreateNode<When>(_scenarioContext.StepContext.StepInfo.Text);
                        break;



                    case ScenarioBlock.Then:
                        _scenario.CreateNode<Then>(_scenarioContext.StepContext.StepInfo.Text);
                        break;



                    default:
                        _scenario.CreateNode<And>(_scenarioContext.StepContext.StepInfo.Text);
                        break;
                }
            }



            [AfterTestRun]
            public static void aftertest()
            {
                extentReports.Flush();
            }
        }
}