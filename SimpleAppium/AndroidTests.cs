using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;

namespace SimpleAppium
{
    [TestClass]
    public class AndroidTests
    {
        //Test buid in android calculator
        [TestMethod]
        public void TestMethod1()
        {
                AppiumDriver<AndroidElement> driver;
                DesiredCapabilities cap = new DesiredCapabilities();
                cap.SetCapability("deviceName", "donatello");
                cap.SetCapability(AndroidMobileCapabilityType.AppPackage, "com.android.calculator2");
                cap.SetCapability(AndroidMobileCapabilityType.AppActivity, "Calculator");
                driver = new AndroidDriver<AndroidElement>(new Uri("http://127.0.0.1:4723/wd/hub"), cap);

                //check if we get the application loaded
                Assert.IsNotNull(driver.Context);

                //do the UI operation
                driver.FindElementById("digit5").Click();
                driver.FindElementById("plus").Click();
                driver.FindElementById("digit2").Click();
                driver.FindElementById("equal").Click();
                Assert.AreEqual("7", driver.FindElementByClassName("android.widget.EditText").Text, "Values dint match");
                driver.CloseApp();
        }

        //Testing google website from android browser
        [TestMethod]
        public void TestMethod2()
        {
            AppiumDriver<AndroidElement> driver;
            DesiredCapabilities cap = new DesiredCapabilities();
            cap.SetCapability("deviceName", "donatello");
            cap.SetCapability(AndroidMobileCapabilityType.AppPackage, "com.android.calculator2");
            cap.SetCapability(MobileCapabilityType.BrowserName, "Browser");
            driver = new AndroidDriver<AndroidElement>(new Uri("http://127.0.0.1:4723/wd/hub"), cap);

            //check if we get the application loaded
            Assert.IsNotNull(driver.Context);

            driver.Url = "http://www.google.com";

            //do the UI operation of search in google
            AppiumWebElement txtsearch = driver.FindElementByName("q");
            txtsearch.SendKeys("naveen tirumalasetty");
            driver.FindElementByName("btnG").Click();
            driver.CloseApp();
        }

        //Test USER NATIVE ANDROID APPLICATION
        [TestMethod]
        public void TestMethod3()
        {
            AppiumDriver<AndroidElement> driver;
            DesiredCapabilities cap = new DesiredCapabilities();
            cap.SetCapability("deviceName", "donatello");
            cap.SetCapability(AndroidMobileCapabilityType.AppPackage, "com.example.tirumalasettyn.myapplication");
            cap.SetCapability(AndroidMobileCapabilityType.AppActivity, "MainActivity");
            driver = new AndroidDriver<AndroidElement>(new Uri("http://127.0.0.1:4723/wd/hub"), cap);

            //check if we get the application loaded
            Assert.IsNotNull(driver.Context);

            //do the UI operation
            //driver.FindElementById("button").Click();
            
            driver.FindElementById("editText2").SendKeys("My Name is Naveen Tirumalasetty");
            //Assert.AreEqual("Hello World!", driver.FindElementByClassName("android.widget.TextView").Text, "Text dint match");            
            driver.CloseApp();
        }

    }
}
