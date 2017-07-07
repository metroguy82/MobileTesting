using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    public class SeleniumSetMethods
    {
        //Enter text inside text box
        public static void EnterText(IWebDriver driver, string element, string value, string elementType)
        {
            if (elementType == "Id")
            {
                driver.FindElement(By.Id(element)).SendKeys(value);
            }
            else if (elementType == "Name")
            {
                driver.FindElement(By.Name(element)).SendKeys(value);
            }

        }

        //Click Button , Checkbox, Option etc
        public static void Click(IWebDriver driver, string element, string elementType)
        {
            if (elementType == "Id")
            {
                driver.FindElement(By.Id(element)).Click();
            }
            else if (elementType == "Name")
            {
                driver.FindElement(By.Name(element)).Click();
            }
        }

        //Selecting a Dropdown control
        public static void SelectDropDown(IWebDriver driver, string element, string value, string elementType)
        {

            if (elementType == "Id")
            {
                new SelectElement(driver.FindElement(By.Id(element))).SelectByText(value);
            }
            else if (elementType == "Name")
            {
                new SelectElement(driver.FindElement(By.Name(element))).SelectByText(value);
            }

        }
    }
}
