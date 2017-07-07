using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    public class SeleniumGetMethods
    {
        public static string GetText(IWebDriver driver, string element, string elementType)
        {
            if (elementType == "Id")
            {
                return driver.FindElement(By.Id(element)).GetAttribute("value");
            }
            else if (elementType == "Name")
            {
                return driver.FindElement(By.Name(element)).GetAttribute("value");
            }
            else
            { 
                return string.Empty;
            }
        }

        public static string GetTextFromDropdown(IWebDriver driver, string element, string elementType)
        {
            if (elementType == "Id")
            {
                //to know about linq  go to url http://executeautomation.com/blog/?s=linq
                return new SelectElement(driver.FindElement(By.Id(element))).SelectedOption.Text;
            }
            else if (elementType == "Name")
            {
                return new SelectElement(driver.FindElement(By.Name(element))).SelectedOption.Text;
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
