using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumFirst;


namespace SeleniumFirst
{
    [TestFixture]
    class Program
    {
        IWebDriver driver;
        static void Main(string[] args)
        {
        }

        [SetUp]
        public void Initialize()
        {
            driver = new ChromeDriver();
            //driver.Navigate().GoToUrl("http://www.google.com");
            driver.Navigate().GoToUrl("http://www.executeautomation.com/demosite/index.html#");
            Console.WriteLine("Opened Test site");
        }

        [Test]
        public void ExecuteTest()
        {
            IWebElement searchBox = driver.FindElement(By.Name("q"));
            searchBox.SendKeys("naveen tirumalasetty");
            searchBox.SendKeys(Keys.Return);
            //IWebElement searchButton = driver.FindElement(By.Name("btnK"));
            //searchButton.Click();
            Console.WriteLine("Searched for Naveen Tirumalasetty");
        }

        [Test]
        public void ExecuteTest1()
        {
            SeleniumSetMethods.SelectDropDown(driver, "TitleId", "Mr.", "Id");
            SeleniumSetMethods.EnterText(driver, "Initial", "Naveen", "Name");
            SeleniumSetMethods.Click(driver, "Save", "Name");
        }

        [TearDown]
        public void CleanUp()
        {
            driver.Close();
            Console.WriteLine("Closed chrome driver");
        }
    }
}
