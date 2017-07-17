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
    class SeleniumTestsIE
    {
        //To use IE browser
        private const string URL = "http://www.executeautomation.com/demosite/index.html#";
        private const string IE_DRIVER_PATH = @"C:\Users\tirumalasettyn\Desktop\Naveen\SELENIUM\IEDriverServer_Win32_3.4.0";
        InternetExplorerOptions IEoptions;
        [SetUp]
        public void Initialize()
        {
            IEoptions = new InternetExplorerOptions()
            {
                InitialBrowserUrl = URL,
                IntroduceInstabilityByIgnoringProtectedModeSettings = true
            };
            PropertiesCollection.driver = new InternetExplorerDriver(IE_DRIVER_PATH, IEoptions);
            PropertiesCollection.driver.Navigate();
        }

        //[Test]
        //public void IE_Test1()
        //{

        //    Console.WriteLine("Opened Test site");

        //    //setting values for dropdown, text box and clicking button
        //    SeleniumSetMethods.SelectDropDown("TitleId", "Mr.", PropertyType.Id);
        //    SeleniumSetMethods.EnterText("Initial", "Naveen", PropertyType.Name);
        //    SeleniumSetMethods.Click("Save", PropertyType.Name);

        //    //getting values set previously for dropdown and text box
        //    Console.WriteLine("Value selected for Selected dropdown is " + SeleniumGetMethods.GetTextFromDropdown("TitleId", PropertyType.Id));

        //    Console.WriteLine("Value entered for initial text box is " + SeleniumGetMethods.GetText("Initial", PropertyType.Name));

        //    PropertiesCollection.driver.Close();
        //    PropertiesCollection.driver.Quit();
        //    Console.WriteLine("Closed chrome driver");
        //}

        [Test]
        public void IE_Test2()
        {
            Console.WriteLine("Opened Test site");
            PageObjectsEAsite page1 = new PageObjectsEAsite();
            page1.EnterAllDetails("Tirumalasetty", "Naveen", "Prasad");
        }


        [TearDown]
        public void CleanUp()
        {
            PropertiesCollection.driver.Close();
            Console.WriteLine("Closed chrome driver");
        }
    }
}
