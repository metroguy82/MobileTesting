using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumFirst;
using OpenQA.Selenium.IE;

namespace SeleniumFirst
{
    [TestFixture]
    class Program
    {
        //For Chrome only
        IWebDriver driver;

        [SetUp]
        public void Initialize()
        {
            //To use Chrome browser
            driver = new ChromeDriver();
            //driver.Navigate().GoToUrl("http://www.google.com");
            driver.Navigate().GoToUrl("http://www.executeautomation.com/demosite/index.html#");
            Console.WriteLine("Opened Test site");

        }

        //for google.com site testing
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
            //setting values for dropdown, text box and clicking button
            SeleniumSetMethods.SelectDropDown(driver, "TitleId", "Mr.", "Id");
            SeleniumSetMethods.EnterText(driver, "Initial", "Naveen", "Name");
            SeleniumSetMethods.Click(driver, "Save", "Name");

            //getting values set previously for dropdown and text box
            Console.WriteLine("Value selected for Selected dropdown is " + SeleniumGetMethods.GetTextFromDropdown(driver, "TitleId", "Id"));

            Console.WriteLine("Value entered for initial text box is " + SeleniumGetMethods.GetText(driver, "Initial", "Name"));


        }

        [TearDown]
        public void CleanUp()
        {
            driver.Close();
            Console.WriteLine("Closed chrome driver");
        }
    }
}
