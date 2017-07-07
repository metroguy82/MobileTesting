/*
//for simulator for IOS
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumHelloWorld
{
    class Simulator
    {
        public IWebDriver driver;

        [TestFixtureSetUp]
        public void Class1()
        {
            //Setting Capabilities
            DesiredCapabilities capabilities = new DesiredCapabilities();
            capabilities.SetCapability("platformName", "iOS");
            capabilities.SetCapability("platformVersion", "8.1");
            capabilities.SetCapability("platform", "Mac");
            capabilities.SetCapability("deviceName", "iPhone 6");
            capabilities.SetCapability("app", "/Users/ADMIN/Desktop/CAMobileApp.app");
            //Connecting to Appium Server
            driver = new RemoteWebDriver(new Uri("http://172.xx.xx.169:4723/wd/hub"), capabilities);
        }

        [Test()]
        public void VerifyMenuSimulator()
        {
            //Test to login into app
            driver.FindElement(By.XPath("//UIATextField[1]")).SendKeys("username");
            driver.FindElement(By.XPath("///UIASecureTextField[1]")).SendKeys("password");
            driver.FindElement(By.XPath("///UIAButton[1]")).Click();
        }

        [TestFixtureTearDown]
        public void End()
        {
            driver.Quit();
        }
    }
}

// For real IOS device
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace SeleniumHelloWorld
{
    class IOSDevice
    {
        public IWebDriver driver;

        [TestFixtureSetUp]
        public void Class1()
        {
            //Setting Capabilities
            DesiredCapabilities capabilities = new DesiredCapabilities();
            capabilities.SetCapability("platformName", "iOS");
            capabilities.SetCapability("platformVersion", "8.1");
            capabilities.SetCapability("platform", "Mac");
            capabilities.SetCapability("deviceName", "Company’s iPhone");
            capabilities.SetCapability("udid", "512a44173579311b509c115b3b7651e04c75698c");
            capabilities.SetCapability("bundleId", "com.ca.projectpocket");
            capabilities.SetCapability("app", "/Users/ADMIN/Desktop/CAMobileApp.app");
            //Connecting to Appium Server
            driver = new RemoteWebDriver(new Uri("http://172.xx.xx.169:4723/wd/hub"), capabilities);
        }


        [Test()]
        public void VerifyMenuDevice()
        {
            //Test to enter loginname & Password on login page
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(2));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//UIAButton[1]")));
            driver.FindElement(By.XPath("//UIATextField[1]")).SendKeys("username");
            driver.FindElement(By.XPath("//UIASecureTextField[1]")).SendKeys("password");
            driver.FindElement(By.XPath("//UIAButton[1]")).Click();
        }

        [TestFixtureTearDown]
        public void End()
        {
            driver.Quit();
        }
    }
}
*/