using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
//using OpenQA.Selenium.Interactions;
//using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;
using TestProject1.EndToEndProject.base_e2e;

namespace TestProject1.EndToEndProject.temp
{
    public class MazeRunner
    {
        [Test]
        public void runner()
        {
            //driver basics
            Driver.driver = new ChromeDriver();
            Driver.driver.Manage().Window.Maximize();
            Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(4);

            //global declarations
            int clmNum;
            int rwNum;

            int wrongRight = 0;
            int wrongLeft = 0;
            int wrongUp = 0;
            int wrongDown = 0;
            string cell = ".currentCell";
            var ways = new List<bool>();
            var reversePath = new List<string>();
            bool deadEnd = false;

            int c = 0;
            bool finish = false;
            var availablePaths = new List<string>();
            var lastButtonClicked = new List<string>();
            lastButtonClicked.Add("right");
            int lbcLastIndex = 0;
            var wrongPath = "";
            int loopCounter = 1;

            //**********Functions start**********//

            List<bool> available_directions()
            {
                ways.Clear();
                string tempStr = Driver.driver.FindElement(By.CssSelector(cell)).GetAttribute("class");
                bool right = false;
                bool left = false;
                bool up = false;
                bool down = false;
                var temp4 = tempStr.Split(" ");
                var coloumn = temp4[1].Split("c");
                var rows = temp4[2].Split("r");
                clmNum = Int32.Parse(coloumn[1]);
                rwNum = Int32.Parse(rows[1]);
                //traverse Right
                {
                    string rightNext = ".c" + (clmNum + 1) + ".r" + (rwNum);
                    var rightString = Driver.driver.FindElement(By.CssSelector(rightNext)).GetAttribute("class");
                    if (rightString.Contains("inactiveCell"))
                    {
                        right = false;
                    }
                    else if (!(rightString.Contains("inactiveCell")))
                    {
                        right = true;
                    }
                }
                //traverse Left
                {
                    string leftNext = ".c" + (clmNum - 1) + ".r" + (rwNum);
                    var leftString = Driver.driver.FindElement(By.CssSelector(leftNext)).GetAttribute("class");
                    if (!(leftString.Contains("inactiveCell")))
                    {
                        left = true;
                    }
                }

                //traverse up
                {
                    string upNext = ".c" + (clmNum) + ".r" + (rwNum - 1);
                    var upString = Driver.driver.FindElement(By.CssSelector(upNext)).GetAttribute("class");
                    if (!(upString.Contains("inactiveCell")))
                    {
                        up = true;
                    }
                }
                //traverse down
                {
                    string downNext = ".c" + (clmNum) + ".r" + (rwNum + 1);
                    var downString = Driver.driver.FindElement(By.CssSelector(downNext)).GetAttribute("class");
                    if (!(downString.Contains("inactiveCell")))
                    {
                        down = true;
                    }
                }
                ways.Add(right);
                ways.Add(left);
                ways.Add(up);
                ways.Add(down);

                return ways;

            }

            //main Buttons

            void right()
            {
                Driver.driver.FindElement(By.XPath("//button[text()='Right']")).Click();
                lastButtonClicked.Add("right");
            }
            void left()
            {
                Driver.driver.FindElement(By.XPath("//button[text()='Left']")).Click();
                lastButtonClicked.Add("left");
            }
            void up()
            {
                Driver.driver.FindElement(By.XPath("//button[text()='Up']")).Click();
                lastButtonClicked.Add("up");
            }
            void down()
            {
                Driver.driver.FindElement(By.XPath("//button[text()='Down']")).Click();
                lastButtonClicked.Add("down");
            }

            // dry buttons

            void right1()
            {
                Driver.driver.FindElement(By.XPath("//button[text()='Right']")).Click();
            }
            void left1()
            {
                Driver.driver.FindElement(By.XPath("//button[text()='Left']")).Click();
            }
            void up1()
            {
                Driver.driver.FindElement(By.XPath("//button[text()='Up']")).Click();

            }
            void down1()
            {
                Driver.driver.FindElement(By.XPath("//button[text()='Down']")).Click();
            }

            List<string> obtainAvailablePaths()
            {
                c = 0;
                available_directions();
                availablePaths.Clear();
                for (int i = 0; i < ways.Count; i++)
                {
                    if (ways[i] == true)
                    {

                        if (i == 0) availablePaths.Add("right");
                        else if (i == 1) availablePaths.Add("left");
                        else if (i == 2) availablePaths.Add("up");
                        else if (i == 3) availablePaths.Add("down");
                        c++;
                    }

                }
                return availablePaths;

            }

            void keepTrackAndGoInAvailablePaths()
            {
                foreach (var path in availablePaths)
                {
                    lbcLastIndex = lastButtonClicked.Count - 1;
                    if (path == "down" && (lastButtonClicked[lbcLastIndex] != "up") && (wrongDown++ != 401))
                    {

                        down();
                        reversePath.Add("down_btn");
                        break;
                    }
                    else if ((path == "right") && (lastButtonClicked[lbcLastIndex] != "left") && (wrongRight++ != 401))
                    {
                        right();
                        reversePath.Add("right_btn");
                        break;
                    }
                    else if (path == "left" && (lastButtonClicked[lbcLastIndex] != "right") && (wrongLeft++ != 401))
                    {
                        left();
                        reversePath.Add("left_btn");
                        break;
                    }
                    else if (path == "up" && (lastButtonClicked[lbcLastIndex] != "down") && (wrongDown++ != 401))
                    {
                        up();
                        reversePath.Add("up_btn");
                        break;
                    }

                }
            }

            void deadEndFound()
            {
                deadEnd = true;
                wrongPath = reversePath[0];
                {
                    if (wrongPath == "right_btn")
                    {
                        wrongRight = 401;
                        lastButtonClicked.Add("right");
                    }
                    else if (wrongPath == "left_btn")
                    {
                        wrongLeft = 401;
                        lastButtonClicked.Add("left");

                    }
                    else if (wrongPath == "up_btn")
                    {
                        wrongUp = 401;
                        lastButtonClicked.Add("up");
                    }
                    else if (wrongPath == "down_btn")
                    {
                        wrongDown = 401;
                        lastButtonClicked.Add("down");
                    }
                }
                for (int i1 = (reversePath.Count - 1); i1 >= 0; i1--)
                {
                    if (reversePath[i1] == "right_btn")
                    {
                        left1();
                    }
                    else if (reversePath[i1] == "left_btn")
                    {
                        right1();
                    }
                    else if (reversePath[i1] == "down_btn")
                    {
                        up1();
                    }
                    else if (reversePath[i1] == "up_btn")
                    {
                        down1();
                    }
                }
                reversePath.Clear();
            }

            //**********Functions End**********//

            Driver.driver.Navigate().GoToUrl("http://127.0.0.1:8080/");
            Driver.driver.FindElement(By.XPath("//button[text()='Right']")).Click();

            try
            {
                do
                {
                    deadEnd = false;
                    obtainAvailablePaths();
                    if (c > 2)
                    {
                        //it is a junction
                        reversePath.Clear();
                        do
                        {
                            obtainAvailablePaths();

                            if (c == 2)
                            {
                                //Not a Junction, Just the regular path
                                keepTrackAndGoInAvailablePaths();
                            }

                            else if (c > 2 && loopCounter == 501)
                            {
                                //This loop is used to terminate the current junction and start over
                                loopCounter = 201;
                                break;
                            }

                            else if (c > 2)
                            {
                                //Junstion inside a junction found
                                keepTrackAndGoInAvailablePaths();
                                loopCounter = 501;
                            }

                            else if (c == 1)
                            {
                                //Reached the dead end
                                deadEndFound();
                                loopCounter = 201;
                            }

                        } while (deadEnd == false);
                    }
                    else if (c == 2)
                    {
                        //it is not a junction
                        keepTrackAndGoInAvailablePaths();
                    }
                    else if (c == 1)
                    {
                        //finish point
                        finish = true;
                    }
                } while (finish == false);
            }
            catch (Exception ex)
            {
                string message = Driver.driver.FindElement(By.XPath("//div/button[text()='GAME OVER']")).Text;
                Console.WriteLine(message);
                Driver.driver.Close();
            }
        }
    }
}
