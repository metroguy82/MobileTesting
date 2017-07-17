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
        public static string GetText(string element, PropertyType elementType)
        {
            if (elementType == PropertyType.Id)
            {
                return PropertiesCollection.driver.FindElement(By.Id(element)).GetAttribute("value");
            }
            else if (elementType == PropertyType.Name)
            {
                return PropertiesCollection.driver.FindElement(By.Name(element)).GetAttribute("value");
            }
            else
            {
                return string.Empty;
            }
        }

        public static string GetTextFromDropdown(string element, PropertyType elementType)
        {
            if (elementType == PropertyType.Id)
            {
                //to know about linq  go to url http://executeautomation.com/blog/?s=linq
                return new SelectElement(PropertiesCollection.driver.FindElement(By.Id(element))).SelectedOption.Text;
            }
            else if (elementType == PropertyType.Name)
            {
                return new SelectElement(PropertiesCollection.driver.FindElement(By.Name(element))).SelectedOption.Text;
            }
            else
            {
                return string.Empty;
            }
        }

        //Refactored above methods
        public static string GetTextLatest(IWebElement element)
        {
            return element.GetAttribute("value");
        }

        public static string GetTextFromDropdownLatest(IWebElement element)
        {
            return new SelectElement(element).SelectedOption.Text;
        }
    }
}
