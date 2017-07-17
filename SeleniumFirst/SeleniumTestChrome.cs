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
        
        //IWebDriver driver;

        [SetUp]
        public void Initialize()
        {
            //For Chrome only
            PropertiesCollection.driver = new ChromeDriver();
            
            //To use Chrome browser
            //driver = new ChromeDriver();
            //driver.Navigate().GoToUrl("http://www.google.com");

            PropertiesCollection.driver.Navigate().GoToUrl("http://www.executeautomation.com/demosite/index.html#");
            Console.WriteLine("Opened Test site");

        }

        //for google.com site testing
        [Test]
        public void ChromeTest1()
        {
            IWebElement searchBox = PropertiesCollection.driver.FindElement(By.Name("q"));
            searchBox.SendKeys("naveen tirumalasetty");
            searchBox.SendKeys(Keys.Return);
            //IWebElement searchButton = driver.FindElement(By.Name("btnK"));
            //searchButton.Click();
            Console.WriteLine("Searched for Naveen Tirumalasetty");
        }

        //[Test]
        //public void ChromeTest2()
        //{
        //    //setting values for dropdown, text box and clicking button
        //    SeleniumSetMethods.SelectDropDown( "TitleId", "Mr.", PropertyType.Id);
        //    SeleniumSetMethods.EnterText("Initial", "Naveen", PropertyType.Name);
        //    SeleniumSetMethods.Click("Save", PropertyType.Name);

        //    //getting values set previously for dropdown and text box
        //    Console.WriteLine("Value selected for Selected dropdown is " + SeleniumGetMethods.GetTextFromDropdown("TitleId", PropertyType.Id));
        //    Console.WriteLine("Value entered for initial text box is " + SeleniumGetMethods.GetText("Initial", PropertyType.Name));
        //}

        [Test] //Page object Model (POM) test
        public void POM_ChromeTest3()
        {
            //Initialize the page by calling its reference
            PageObjectsEAsite page = new PageObjectsEAsite();
            page.txtInitial.SendKeys("Naveen");
            page.btnSave.Click();
        }
        //[Test] //POM type 2
        //public void POM_Test4()
        //{
        //    PageObjectsEAsite page1 = new PageObjectsEAsite();
        //    page1.EnterAllDetails("Tirumalasetty","Naveen","Prasad");

        //    //if we are navigating to next page we use SecondPageClass page2=page1.EnterAllDetails("naveen");
        //}

        [Test] //FINAL REFACTORED - Page Object Model test
        public void Chrome_Test5()
        {
            PageObjectsEAsite page1 = new PageObjectsEAsite();
            page1.EnterAllDetails("Ms.","Tirumalasetty", "Naveen", "Prasad");

            //if we are navigating to next page we use SecondPageClass page2=page1.EnterAllDetails("naveen");
        }

        [TearDown]
        public void CleanUp()
        {
            PropertiesCollection.driver.Close();
            Console.WriteLine("Closed chrome driver");
        }
    }
}
