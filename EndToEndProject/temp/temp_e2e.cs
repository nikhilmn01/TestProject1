using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TestProject1.EndToEndProject.base_e2e;


namespace TestProject1.EndToEndProject.temp
{
    public class temp_e2e
    {

        [Test]

        public void runner()
        {
            //tabsValidation();
            //iconValidation();
            //youtubePlayer();

            //maze();

            //testing();

            //quickMaze();
            quickMaze2();
        }
        public void tabsValidation()
        {
            Driver.driver = new ChromeDriver();
            Driver.driver.Manage().Window.Maximize();
            Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            PageObjects_e2e obj = new PageObjects_e2e(Driver.driver);

            Driver.driver.Navigate().GoToUrl("https://compendiumdev.co.uk/default.php");

            obj.hireMe_tab.Click();
            Assert.IsTrue(obj.validate_hireMe.Displayed);
            Driver.driver.Navigate().Back();

            obj.e_training_tab.Click();
            Assert.IsTrue(obj.validate_e_training_tab.Displayed);
            Driver.driver.Navigate().Back();

            obj.books_tab.Click();
            Assert.IsTrue(obj.validate_books_tab.Displayed);
            Driver.driver.Navigate().Back();

            obj.face_to_face_tab.Click();
            Assert.IsTrue(obj.validate_face_to_face.Displayed);
            Driver.driver.Navigate().Back();

            obj.about_tab.Click();
            Assert.IsTrue(obj.validate_about.Displayed);
            Driver.driver.Navigate().Back();

            obj.contact_tab.Click();
            Assert.IsTrue(obj.validate_contact.Displayed);
            Driver.driver.Navigate().Back();

            obj.email_list.Click();
            Assert.IsTrue(obj.validate_email_list.Displayed);
            Driver.driver.Navigate().Back();

            obj.blog_tab.Click();
            Assert.IsTrue(obj.validate_blog.Displayed);
            Driver.driver.Navigate().Back();

            Thread.Sleep(2000);
            Driver.driver.Close();
        }

        public void iconValidation()
        {
            Driver.driver = new ChromeDriver();
            Driver.driver.Manage().Window.Maximize();
            Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            PageObjects_e2e obj = new PageObjects_e2e(Driver.driver);

            Driver.driver.Navigate().GoToUrl("https://compendiumdev.co.uk/default.php");

            obj.email_icon.Click();
            Assert.IsTrue(obj.email_icon_validate.Displayed);
            Driver.driver.Navigate().Back();

            obj.twitter_icon.Click();
            Assert.IsTrue(obj.twitter_icon_validate.Displayed);
            Driver.driver.Navigate().Back();

            obj.youTube_icon.Click();
            obj.youTube_popUp.Click();
            Assert.IsTrue(obj.youTube_icon_validate.Displayed);
            Driver.driver.Navigate().Back();

            obj.linkedIn_icon.Click();
            Assert.IsFalse(obj.linkedIn_icon_validate.Displayed);
            Driver.driver.Navigate().Back();

            obj.gitHub_icon.Click();
            Assert.IsTrue(obj.gitHub_icon_validate.Displayed);
            Driver.driver.Navigate().Back();

            obj.pintrest_icon.Click();
            Assert.IsTrue(obj.pintrest_icon_validate.Displayed);
            Driver.driver.Navigate().Back();

            obj.inst_icon.Click();
            Assert.IsTrue(obj.inst_icon_validate.Displayed);
            Driver.driver.Navigate().Back();

            obj.facebook_icon.Click();
            Assert.IsTrue(obj.facebook_icon_validate.Displayed);
            Driver.driver.Navigate().Back();

            obj.rss_icon.Click();
            Assert.IsFalse(false);
            Driver.driver.Navigate().Back();


            Thread.Sleep(2000);
            Driver.driver.Close();



        }

        public void youtubePlayer()
        {
            //var nav[2] = {"Products","Use Cases"};
            //var nav = new List<string>();
            List<string> nav = new List<string> { "Products", "Use Cases", "Resources", "Pricing", "Company" };
            List<string> Products_validation = new List<string> { "Platform Overview", "Eyes", "Ultrafast Test Cloud", "SDKs & Integrations" };



            Driver.driver = new ChromeDriver();
            Driver.driver.Manage().Window.Maximize();
            Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Actions action = new Actions(Driver.driver);

            Driver.driver.Navigate().GoToUrl("https://applitools.com/");
            //Driver.driver.FindElement(By.XPath("//*[name()='path'][@fill='#FF0476']")).Click();
            Driver.driver.FindElement(By.XPath("//button[@class='play']")).Click();
            Thread.Sleep(1000);
            Driver.driver.SwitchTo().Frame(Driver.driver.FindElement(By.XPath("//div/iframe[@title='Applitools Visual AI Overview Video']")));
            //Driver.driver.SwitchTo().Frame(Driver.driver.FindElement(By.Id("player")));

            Driver.driver.SwitchTo().Frame(Driver.driver.FindElement(By.XPath("//*[@id='player']")));





            //iframe[@id='player']
            //Driver.driver.FindElement(By.XPath("//iframe")).Click();

            Driver.driver.FindElement(By.XPath("//button[@class='ytp-play-button ytp-button']")).Click();

            IWebElement ele = Driver.driver.FindElement(By.XPath("//div[@class='ytp-scrubber-container']"));

            int xcord = ele.Location.X;
            int ycord = ele.Location.Y;

            action.MoveByOffset(350, ycord).Perform();
            Thread.Sleep(1000);
            action.Click();

            action.SendKeys(Keys.NumberPad9).Perform();
            action.SendKeys(Keys.Space).Perform();

            WebDriverWait wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(15));

            wait.Until(driver => Driver.driver.FindElement(By.XPath("//button[@aria-label='Replay']")).Displayed);

            //Thread.Sleep(15000);
            //Driver.driver.FindElement(By.XPath("//button[@aria-label='Replay']"));
            Assert.IsTrue(Driver.driver.FindElement(By.XPath("//button[@aria-label='Replay']")).Displayed);

            //action.SendKeys(Keys.).Click().Perform();

            //Actions action2 = new Actions(Driver.driver);

            //IWebElement ele = Driver.driver.FindElement(By.XPath("//div[@class='ytp-scrubber-container']"));

            ////div[@class='ytp-progress-bar-container']
            //int xcord = ele.Location.X;
            //int ycord = ele.Location.Y;

            ////action2.MoveByOffset(300, 457).Perform();
            //action2.MoveByOffset(xcord + 180, ycord).Perform();
            ////Thread.Sleep(5000);
            //action2.Click();
            //action.SendKeys(Keys.NumberPad9).Click().Perform();

            //for (int act = 0; act < 30; act++)
            //{

            //    action.SendKeys(Keys.ArrowRight).Click().Perform();

            //}
            //Thread.Sleep(1000);
            //action.SendKeys(Keys.Space).Click().Perform();
            Driver.driver.SwitchTo().DefaultContent();




            //for (int req = 0; req < nav.Count; req++) 
            //{
            //    string reqNav = nav[req];
            //    action.MoveToElement(Driver.driver.FindElement(By.XPath("//a[text()='" + reqNav + "']"))).Perform();
            //    //a[text()='Products']/parent::li/ul/li
            //    //Driver.driver.FindElements(By.XPath("//a[text()='" + reqNav + "']/parent::li/ul/li"));

            //    if (reqNav != nav[3])
            //    {


            //    var ele = Driver.driver.FindElements(By.XPath("//a[text()='" + reqNav + "']/parent::li/ul/li"));

            //        for (int i = 0; i < ele.Count; i++)
            //        {

            //            String all1 = ele[i].Text;
            //            if (reqNav == nav[0])
            //            {
            //                var splitString = all1.Split("\r");
            //                all1 = splitString[0];
            //                Assert.IsTrue(all1 == Products_validation[i]);
            //            }
            //            Console.WriteLine(all1);
            //        }


            //    }
            //    else if (reqNav == nav[3])
            //    {
            //        Console.WriteLine("There is no sub elements to validate");
            //    }
            //}

            Thread.Sleep(2000);
            Driver.driver.Close();
        }

        public void bitCoinGraph()
        {
            Driver.driver = new ChromeDriver();
            Driver.driver.Manage().Window.Maximize();
            Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            Driver.driver.Navigate().GoToUrl("https://www.coindesk.com/price/bitcoin/");

            Actions action = new Actions(Driver.driver);

            IWebElement element = Driver.driver.FindElement(By.XPath("(//*[local-name()='svg']//*[@class='highcharts-series highcharts-series-0 highcharts-area-series'])[1]"));
            //X and Y co-ordinates to hover through the graph
            int Y = ((element.Size.Height) / 2);
            int X = ((element.Size.Width) / 2);
            string date = "2 ";
            string month = "Jan 2022";
            string time = " 22:14";
            string time2 = " 22:15";
            string input = date.Trim() + " Dec 2021, " + time.Trim() + " GMT+5:30";
            string inputA = date.Trim() + " " + month.Trim() + ", " + time.Trim() + " GMT+5:30";
            string inputB = date.Trim() + " " + month.Trim() + ", " + time2.Trim() + " GMT+5:30";
            string input2 = date.Trim() + " Dec 2021, " + time2.Trim() + " GMT+5:30";
            string compare = "30 Dec 2021, 03:08 GMT+5:30";
            string compare2 = "30 Dec 2021, 03:09 GMT+5:30";
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
                //if(data == test1.ToString("d MMM yyyy, HH:mm 'GMT+5:30'"))
                //{
                //    Console.WriteLine(driver.FindElement(By.XPath("//div[@class=('highcharts-label highcharts-tooltip chart-tooltip highcharts-color-undefined')]/span/span[@class='price']")).Text);
                //    break;
                //}

            }

            Driver.driver.Close();




        }

        public void maze()
        {
            Driver.driver = new ChromeDriver();
            Driver.driver.Manage().Window.Maximize();
            Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            Driver.driver.Navigate().GoToUrl("http://127.0.0.1:8080/");
            var currentCell = "";
            var checkpoint = "";
            var savePoint = "";
            int tempi = 0;
            int c = 0;
            int Rcount = 0;
            bool finish = false;
            bool loopTerminate = false;
            var availablePaths = new List<string>();
            var lastButtonClicked = new List<string>();
            lastButtonClicked.Add("right");
            int lbcLastIndex = 0;
            var wrongPath = "";
            int iterator = 1;
            int junctionCounter = 1;
            int loopCounter = 1;

            Driver.driver.FindElement(By.XPath("//table[@id='maze']"));
            Thread.Sleep(100);

            List<string> s = new List<string>();
            var l = Driver.driver.FindElements(By.XPath("//table/span/span/div"));

            List<bool> ways = new List<bool> { false, false, false, false };

            List<bool> waysInit()
            {
                ways.Clear();
                ways.Add(false);
                ways.Add(false);
                ways.Add(false);
                ways.Add(false);
                return ways;
            }

            void theLoop()
            {
                foreach (var ele in l)
                {
                    var sample = ele.GetAttribute("class");
                    s.Add(sample);

                }
                checkpoint = currentCell;
                foreach (var sub in s)
                {
                    var subSplit = sub.Split(" ");
                    if (subSplit.Contains("currentCell"))
                    {
                        currentCell = sub;

                    }
                }

                Thread.Sleep(1);

            }

            void rightButton_check()
            {
                //theLoop();
                Driver.driver.FindElement(By.XPath("//button[text()='Right']")).Click();
            }

            void leftButton_check()
            {
                Driver.driver.FindElement(By.XPath("//button[text()='Left']")).Click();
            }

            void upButton_check()
            {
                Driver.driver.FindElement(By.XPath("//button[text()='Up']")).Click();
            }

            void downButton_check()
            {
                Driver.driver.FindElement(By.XPath("//button[text()='Down']")).Click();
            }


            void rightButton()
            {

                Driver.driver.FindElement(By.XPath("//button[text()='Right']")).Click();
                lastButtonClicked.Add("right");
                theLoop();
            }
            void leftButton()
            {
                Driver.driver.FindElement(By.XPath("//button[text()='Left']")).Click();
                lastButtonClicked.Add("left");
                theLoop();
            }
            void upButton()
            {
                Driver.driver.FindElement(By.XPath("//button[text()='Up']")).Click();
                lastButtonClicked.Add("up");
                theLoop();
            }
            void downButton()
            {
                Driver.driver.FindElement(By.XPath("//button[text()='Down']")).Click();
                lastButtonClicked.Add("down");
                theLoop();
            }


            List<bool> waysAvailable()
            {
                ways = waysInit();
                theLoop();
                rightButton_check();
                theLoop();
                if (!checkpoint.Equals(currentCell))
                {
                    ways[0] = true;
                    leftButton_check();
                }
                theLoop();
                leftButton_check();
                theLoop();
                if (!checkpoint.Equals(currentCell))
                {
                    ways[1] = true;
                    rightButton_check();
                }
                theLoop();
                upButton_check();
                theLoop();
                if (!checkpoint.Equals(currentCell))
                {
                    ways[2] = true;
                    downButton_check();
                }
                theLoop();
                downButton_check();
                theLoop();
                if (!checkpoint.Equals(currentCell))
                {
                    ways[3] = true;
                    upButton_check();
                }
                return ways;
            }
            theLoop();
            theLoop();
            Driver.driver.FindElement(By.XPath("//button[text()='Right']")).Click();
            do
            {
                c = 0;
                iterator = 1;

                waysAvailable();
                availablePaths.Clear();
                //foreach (var count in ways)
                for (int i1 = 0; i1 < ways.Count; i1++)
                {
                    if (ways[i1] == true)
                    {

                        if (i1 == 0) availablePaths.Add("right");
                        else if (i1 == 1) availablePaths.Add("left");
                        else if (i1 == 2) availablePaths.Add("up");
                        else if (i1 == 3) availablePaths.Add("down");
                        c++;
                    }

                }
                if (c > 2)
                {
                    junctionCounter++;
                    int c1;
                    var availablePaths1 = new List<string>();
                    bool deadEnd = false;
                    var reversePath = new List<string>();
                    reversePath.Clear();
                    //it is a junction
                    do
                    {

                        c1 = 0;

                        //if (iterator > 1)
                        //{
                        //    loopTerminate = true;
                        //    break;

                        //}
                        waysAvailable();
                        availablePaths1.Clear();


                        for (int i2 = 0; i2 < ways.Count; i2++)
                        {

                            if (ways[i2] == true)
                            {

                                if (i2 == 0) availablePaths1.Add("right");
                                else if (i2 == 1) availablePaths1.Add("left");
                                else if (i2 == 2) availablePaths1.Add("up");
                                else if (i2 == 3) availablePaths1.Add("down");
                                c1++;
                            }

                        }
                        //availablePaths1.Add("left");  //remove this *************************************************

                        if (c1 == 2)
                        {
                            foreach (var path in availablePaths1)
                            {
                                lbcLastIndex = lastButtonClicked.Count - 1;
                                if (path == "down" && (lastButtonClicked[lbcLastIndex] != "up") && wrongPath != "down_btn")
                                {
                                    downButton();
                                    //wrongPath = "down";
                                    reversePath.Add("down_btn");
                                    iterator++;
                                    break;
                                }
                                else if ((path == "right") && (lastButtonClicked[lbcLastIndex] != "left"))
                                {
                                    rightButton();
                                    //wrongPath = "right";
                                    reversePath.Add("right_btn");
                                    iterator++;
                                    break;
                                }
                                else if (path == "left" && (lastButtonClicked[lbcLastIndex] != "right"))
                                {
                                    leftButton();
                                    //wrongPath = "left";
                                    reversePath.Add("left_btn");
                                    iterator++;
                                    break;
                                }
                                else if (path == "up" && (lastButtonClicked[lbcLastIndex] != "down"))
                                {
                                    upButton();
                                    //wrongPath = "up";
                                    reversePath.Add("up_btn");
                                    iterator++;
                                    break;
                                }


                            }

                        }

                        else if (c1 > 2)
                        {

                            foreach (var path in availablePaths1)
                            {
                                lbcLastIndex = lastButtonClicked.Count - 1;
                                if (path == "down" && (lastButtonClicked[lbcLastIndex] != "up"))
                                {
                                    downButton();
                                    //wrongPath = "down";
                                    reversePath.Add("down_btn");
                                    iterator++;
                                    break;
                                }
                                else if ((path == "right") && (lastButtonClicked[lbcLastIndex] != "left") && wrongPath != "right_btn")
                                {
                                    rightButton();
                                    //wrongPath = "right";
                                    reversePath.Add("right_btn");
                                    iterator++;
                                    break;
                                }
                                else if (path == "left" && (lastButtonClicked[lbcLastIndex] != "right"))
                                {
                                    leftButton();
                                    //wrongPath = "left";
                                    reversePath.Add("left_btn");
                                    iterator++;
                                    break;
                                }
                                else if (path == "up" && (lastButtonClicked[lbcLastIndex] != "down"))
                                {
                                    upButton();
                                    //wrongPath = "up";
                                    reversePath.Add("up_btn");
                                    iterator++;
                                    break;
                                }


                            }
                            loopCounter++;


                        }
                        else if (c1 > 2 && loopCounter > 1)
                        {
                            //break;

                        }
                        else if (c1 == 1)
                        {
                            //dead end
                            deadEnd = true;
                            wrongPath = reversePath[0];
                            for (int i1 = (reversePath.Count - 1); i1 >= 0; i1--)
                            {
                                if (reversePath[i1] == "right_btn")
                                {
                                    leftButton_check();
                                }
                                else if (reversePath[i1] == "left_btn")
                                {
                                    rightButton_check();
                                }
                                else if (reversePath[i1] == "down_btn")
                                {
                                    upButton_check();
                                }
                                else if (reversePath[i1] == "up_btn")
                                {
                                    downButton_check();
                                }
                            }
                            reversePath.Clear();
                        }
                        //else if (c1 == 3)
                        //{
                        //    loopTerminate = flase;

                        //}



                    } while (deadEnd == false && loopTerminate == false);
                }
                else if (c == 2)
                {
                    //it is not a junction
                    foreach (var path in availablePaths)
                    {

                        lbcLastIndex = lastButtonClicked.Count - 1;
                        if ((path == "right") && (lastButtonClicked[lbcLastIndex] != "left"))
                        {
                            rightButton();
                            break;
                        }

                        else if (path == "left" && (lastButtonClicked[lbcLastIndex] != "right"))
                        {
                            leftButton();
                            break;
                        }

                        else if (path == "up" && (lastButtonClicked[lbcLastIndex] != "down"))
                        {
                            upButton();
                            break;
                        }
                        else if (path == "down" && (lastButtonClicked[lbcLastIndex] != "up"))
                        {
                            downButton();
                            break;
                        }

                    }
                }
                else if (c == 1)
                {
                    //finish point
                    finish = true;
                }
            } while (finish == false);


            //do
            //{
            //    rightButton();
            //    if (!checkpoint.Equals(currentCell))
            //    {
            //        waysAvailable();
            //        if (ways[0] == true && ways[2]==false && ways[3]==false)
            //        {
            //            rightButton();
            //            waysAvailable();
            //        }
            //        else if (ways[0] == true && (ways[2] == true || ways[3] == true))
            //        {
            //            //this is a junction

            //        }

            //    }

            //    if (checkpoint.Equals(currentCell))
            //    {

            //    }
            //    else
            //    {

            //    }

            //    if (Rcount!=0)
            //    {
            //        savePoint = currentCell;
            //    }

            //} while (Rcount == 0);

            Thread.Sleep(100);
        }

        public void testing()
        {
            Driver.driver = new ChromeDriver();
            Driver.driver.Manage().Window.Maximize();
            Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //global declarations
            int clmNum;
            int rwNum;


            Driver.driver.Navigate().GoToUrl("http://127.0.0.1:8080/");
            string cell = ".currentCell";
            var availableWays = new List<bool>();
            Driver.driver.FindElement(By.XPath("//button[text()='Right']")).Click();

            //Driver.driver.FindElement(By.CssSelector(cell));
            //string temp = Driver.driver.FindElement(By.CssSelector(cell)).Text;
            //string temp2 = Driver.driver.FindElement(By.CssSelector(cell)).GetAttribute("class");
            //var temp3 = temp2.Split("currentCell");
            //Thread.Sleep(1);

            List<bool> available_directions()
            {
                availableWays.Clear();
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
                availableWays.Add(right);
                availableWays.Add(left);
                availableWays.Add(up);
                availableWays.Add(down);

                return availableWays;

            }

            available_directions();
            Console.WriteLine(availableWays);

            available_directions();
            Console.WriteLine(availableWays);

            available_directions();
            Console.WriteLine(availableWays);

            available_directions();
            Console.WriteLine(availableWays);

            available_directions();
            Console.WriteLine(availableWays);

            available_directions();
            Console.WriteLine(availableWays);

            available_directions();
            Console.WriteLine(availableWays);





        }

        public void quickMaze()
        {
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

            //copied Golbal declarations

            //var currentCell = "";
            //var checkpoint = "";
            //var savePoint = "";
            int tempi = 0;
            int c = 0;
            int Rcount = 0;
            bool finish = false;
            bool loopTerminate = false;
            var availablePaths = new List<string>();
            var lastButtonClicked = new List<string>();
            lastButtonClicked.Add("right");
            int lbcLastIndex = 0;
            var wrongPath = "";
            int iterator = 1;
            int junctionCounter = 1;
            int loopCounter = 1;



            Driver.driver.Navigate().GoToUrl("http://127.0.0.1:8080/");
            string cell = ".currentCell";
            var ways = new List<bool>();
            Driver.driver.FindElement(By.XPath("//button[text()='Right']")).Click();

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



            //Copy Paste started
            try
            {
                do
                {
                    c = 0;
                    iterator = 1;

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
                    if (c > 2)
                    {
                        junctionCounter++;
                        int c1;
                        var availablePaths1 = new List<string>();
                        bool deadEnd = false;
                        var reversePath = new List<string>();
                        reversePath.Clear();
                        //it is a junction
                        do
                        {

                            c1 = 0;

                            //if (iterator > 1)
                            //{
                            //    loopTerminate = true;
                            //    break;

                            //}
                            available_directions();
                            availablePaths1.Clear();
                            //loopCounter = 619;


                            for (int i2 = 0; i2 < ways.Count; i2++)
                            {

                                if (ways[i2] == true)
                                {

                                    if (i2 == 0) availablePaths1.Add("right");
                                    else if (i2 == 1) availablePaths1.Add("left");
                                    else if (i2 == 2) availablePaths1.Add("up");
                                    else if (i2 == 3) availablePaths1.Add("down");
                                    c1++;
                                }

                            }
                            //availablePaths1.Add("left");  //remove this *************************************************

                            if (c1 == 2)
                            {
                                foreach (var path in availablePaths1)
                                {
                                    lbcLastIndex = lastButtonClicked.Count - 1;
                                    if (path == "down" && (lastButtonClicked[lbcLastIndex] != "up"))
                                    {
                                        down();
                                        //wrongPath = "down";
                                        reversePath.Add("down_btn");
                                        iterator++;
                                        break;
                                    }
                                    else if ((path == "right") && (lastButtonClicked[lbcLastIndex] != "left"))
                                    {
                                        right();
                                        //wrongPath = "right";
                                        reversePath.Add("right_btn");
                                        iterator++;
                                        break;
                                    }
                                    else if (path == "left" && (lastButtonClicked[lbcLastIndex] != "right"))
                                    {
                                        left();
                                        //wrongPath = "left";
                                        reversePath.Add("left_btn");
                                        iterator++;
                                        break;
                                    }
                                    else if (path == "up" && (lastButtonClicked[lbcLastIndex] != "down"))
                                    {
                                        up();
                                        //wrongPath = "up";
                                        reversePath.Add("up_btn");
                                        iterator++;
                                        break;
                                    }


                                }

                            }

                            else if (c1 > 2 && loopCounter == 501)
                            {
                                loopCounter = 201;
                                break;

                            }

                            else if (c1 > 2)
                            {

                                foreach (var path in availablePaths1)
                                {
                                    lbcLastIndex = lastButtonClicked.Count - 1;
                                    if (path == "down" && (lastButtonClicked[lbcLastIndex] != "up") && (wrongDown++ != 401))
                                    {

                                        down();
                                        reversePath.Add("down_btn");
                                        iterator++;
                                        break;
                                    }
                                    else if ((path == "right") && (lastButtonClicked[lbcLastIndex] != "left") && (wrongRight++ != 401))
                                    {
                                        right();
                                        reversePath.Add("right_btn");
                                        iterator++;
                                        break;
                                    }
                                    else if (path == "left" && (lastButtonClicked[lbcLastIndex] != "right") && (wrongLeft++ != 401))
                                    {
                                        left();
                                        reversePath.Add("left_btn");
                                        iterator++;
                                        break;
                                    }
                                    else if (path == "up" && (lastButtonClicked[lbcLastIndex] != "down") && (wrongDown++ != 401))
                                    {
                                        up();
                                        reversePath.Add("up_btn");
                                        iterator++;
                                        break;
                                    }

                                }
                                loopCounter = 501;


                            }

                            else if (c1 == 1)
                            {
                                //dead end
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
                                    //else if (wrongPath == "right_btn") wrongRight = 1;
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
                                loopCounter = 201;
                            }
                            //else if (c1 == 3)
                            //{
                            //    loopTerminate = flase;

                            //}



                        } while (deadEnd == false && loopTerminate == false);
                    }
                    else if (c == 2)
                    {
                        //it is not a junction
                        foreach (var path in availablePaths)
                        {

                            lbcLastIndex = lastButtonClicked.Count - 1;
                            if ((path == "right") && (lastButtonClicked[lbcLastIndex] != "left"))
                            {
                                right();

                                break;
                            }

                            else if (path == "left" && (lastButtonClicked[lbcLastIndex] != "right"))
                            {
                                left();
                                break;
                            }

                            else if (path == "up" && (lastButtonClicked[lbcLastIndex] != "down"))
                            {
                                up();
                                break;
                            }
                            else if (path == "down" && (lastButtonClicked[lbcLastIndex] != "up"))
                            {
                                down();
                                break;
                            }

                        }
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
            //copy Paste ended




        }

        public void quickMaze2()
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

            void goInAvailablePaths()
            {
                foreach (var path in availablePaths)
                {

                    lbcLastIndex = lastButtonClicked.Count - 1;
                    if ((path == "right") && (lastButtonClicked[lbcLastIndex] != "left"))
                    {
                        right();

                        break;
                    }

                    else if (path == "left" && (lastButtonClicked[lbcLastIndex] != "right"))
                    {
                        left();
                        break;
                    }

                    else if (path == "up" && (lastButtonClicked[lbcLastIndex] != "down"))
                    {
                        up();
                        break;
                    }
                    else if (path == "down" && (lastButtonClicked[lbcLastIndex] != "up"))
                    {
                        down();
                        break;
                    }

                }
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
                        reversePath.Clear();

                        //it is a junction
                        do
                        {
                            obtainAvailablePaths();

                            if (c == 2)
                            {
                                keepTrackAndGoInAvailablePaths();

                            }

                            else if (c > 2 && loopCounter == 501)
                            {
                                loopCounter = 201;
                                break;

                            }

                            else if (c > 2)
                            {
                                keepTrackAndGoInAvailablePaths();
                                loopCounter = 501;

                            }

                            else if (c == 1)
                            {
                                //dead end

                                deadEndFound();
                                loopCounter = 201;
                            }

                        } while (deadEnd == false );
                    }
                    else if (c == 2)
                    {
                        //it is not a junction
                        goInAvailablePaths();
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
