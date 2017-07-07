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

        [SetUp]
        public void Initialize()
        {
        }

        [Test]
        public void ExecuteTest3()
        {
            var IEoptions = new InternetExplorerOptions()
            {
                InitialBrowserUrl = URL,
                IntroduceInstabilityByIgnoringProtectedModeSettings = true
            };
            var driver = new InternetExplorerDriver(IE_DRIVER_PATH, IEoptions);
            driver.Navigate();

            Console.WriteLine("Opened Test site");

            //setting values for dropdown, text box and clicking button
            SeleniumSetMethods.SelectDropDown(driver, "TitleId", "Mr.", "Id");
            SeleniumSetMethods.EnterText(driver, "Initial", "Naveen", "Name");
            SeleniumSetMethods.Click(driver, "Save", "Name");

            //getting values set previously for dropdown and text box
            Console.WriteLine("Value selected for Selected dropdown is " + SeleniumGetMethods.GetTextFromDropdown(driver, "TitleId", "Id"));

            Console.WriteLine("Value entered for initial text box is " + SeleniumGetMethods.GetText(driver, "Initial", "Name"));

            driver.Close();
            driver.Quit();
            Console.WriteLine("Closed chrome driver");
        }

        [TearDown]
        public void CleanUp()
        {

        }
    }
}
