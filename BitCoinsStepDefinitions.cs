using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using TechTalk.SpecFlow;
using TestProject1.EndToEndProject.base_e2e;

namespace TestProject1
{
    [Binding]
    public class BitCoinsStepDefinitions
    {
        [Given(@"When user enters the url = ""([^""]*)""")]
        public void GivenWhenUserEntersTheUrl(string url)
        {
            Driver.driver.Navigate().GoToUrl(url);
        }

        [When(@"user hovers over the graph at date = ""([^""]*)"" and time = ""([^""]*)"" or ""([^""]*)""")]
        public void WhenUserHoversOverTheGraphAtDateAndTimeOr(string date, string time1, string time2)
        {
            Actions action = new Actions(Driver.driver);

            IWebElement element = Driver.driver.FindElement(By.XPath("(//*[local-name()='svg']//*[@class='highcharts-series highcharts-series-0 highcharts-area-series'])[1]"));
            //X and Y co-ordinates to hover through the graph
            int Y = ((element.Size.Height) / 2);
            int X = ((element.Size.Width) / 2);
            //string date = "2 ";
            //string month = "Jan 2022";
            //string time = " 22:14";
            //string time2 = " 22:15";
            //string input = date.Trim() + " Dec 2021, " + time.Trim() + " GMT+5:30";
            string inputA = date.Trim() + ", " + time1.Trim() + " GMT+5:30";
            string inputB = date.Trim() + ", " + time2.Trim() + " GMT+5:30";
            string compare = "2 Jan 2022, 22:16 GMT+5:30";
            string compare2 = "2 Jan 2022, 22:15 GMT+5:30";
            bool flag = (compare == inputA || inputB == compare2);

            Driver.driver.FindElement(By.XPath("//*[local-name()='svg']//*[@class='highcharts-series highcharts-series-0 highcharts-area-series']")).Click();

            for (int i = 0; i < element.Size.Width; i++)
            {

                action.MoveToElement(element, X + i, Y + i).Perform();
                string data = Driver.driver.FindElement(By.XPath("//div[@class=('highcharts-label highcharts-tooltip chart-tooltip highcharts-color-undefined')]/span/span[@class='date']")).Text;
                if (data == inputA || data == inputB)
                {
                    Console.WriteLine(Driver.driver.FindElement(By.XPath("//div[@class=('highcharts-label highcharts-tooltip chart-tooltip highcharts-color-undefined')]/span/span[@class='price']")).Text);
                    break;
                }


            }
        }

        [Then(@"should get the appropriate price at that point")]
        public void ThenShouldGetTheAppropriatePriceAtThatPoint()
        {
            Console.WriteLine("Done");
        }
    }
}
