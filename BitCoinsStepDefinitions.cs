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
        //string Value;
        bool flag;
        temp_po obj = new temp_po(Driver.driver);
        [Given(@"When user enters the url = ""([^""]*)""")]
        public void GivenWhenUserEntersTheUrl(string url)
        {

            Driver.driver.Navigate().GoToUrl(url);
        }

        [When(@"user hovers over the graph at date = ""([^""]*)"" and time = ""([^""]*)"" or ""([^""]*)""")]
        public void WhenUserHoversOverTheGraphAtDateAndTimeOr(string date, string time1, string time2)
        {


            IWebElement element = Driver.driver.FindElement(By.XPath("(//*[local-name()='svg']//*[@class='highcharts-series highcharts-series-0 highcharts-area-series'])[1]"));
            //IWebElement element = obj.BitCoinElement;
            //X and Y co-ordinates to hover through the graph
            int Y = ((element.Size.Height) / 2);
            int X = ((element.Size.Width) / 2);
            string inputA = date.Trim() + ", " + time1.Trim() + " GMT+5:30";
            string inputB = date.Trim() + ", " + time2.Trim() + " GMT+5:30";

            obj.svgGraph_Hover_bitCoin.Click();
            for (int i = 0; i < element.Size.Width; i++)
            {
                Actions action = new Actions(Driver.driver);
                action.MoveToElement(element, (X + i), (Y + i)).Perform();
                string data = obj.svg_graphTable_bitCoin.Text;

                if (data == inputA || data == inputB)
                {
                    flag= true;
                    break;
                }
            }
        }

        [Then(@"should get the appropriate price at that point")]
        public void ThenShouldGetTheAppropriatePriceAtThatPoint()
        {
            if (flag==true)
            {                
                Console.WriteLine(obj.svg_price_bitCoin.Text);

            }
        }
    }
}
