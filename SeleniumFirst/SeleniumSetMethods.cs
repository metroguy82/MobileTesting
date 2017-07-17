using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    public static class SeleniumSetMethods
    {
        ////Enter text inside text box
        //public static void EnterText(string element, string value, PropertyType elementType)
        //{
        //    if (elementType == PropertyType.Id)
        //    {
        //        PropertiesCollection.driver.FindElement(By.Id(element)).SendKeys(value);
        //    }
        //    else if (elementType == PropertyType.Name)
        //    {
        //        PropertiesCollection.driver.FindElement(By.Name(element)).SendKeys(value);
        //    }

        //}

        ////Click Button , Checkbox, Option etc
        //public static void Click(string element, PropertyType elementType)
        //{
        //    if (elementType == PropertyType.Id)
        //    {
        //        PropertiesCollection.driver.FindElement(By.Id(element)).Click();
        //    }
        //    else if (elementType == PropertyType.Name)
        //    {
        //        PropertiesCollection.driver.FindElement(By.Name(element)).Click();
        //    }
        //}

        ////Selecting a Dropdown control
        //public static void SelectDropDown(string element, string value, PropertyType elementType)
        //{

        //    if (elementType == PropertyType.Id)
        //    {
        //        new SelectElement(PropertiesCollection.driver.FindElement(By.Id(element))).SelectByText(value);
        //    }
        //    else if (elementType == PropertyType.Name)
        //    {
        //        new SelectElement(PropertiesCollection.driver.FindElement(By.Name(element))).SelectByText(value);
        //    }

        //}
        ////SECOND REFACTOR
        ////Refactore above methods
        //public static void EnterTextLatest(IWebElement element, string value)
        //{
        //    element.SendKeys(value);
        //}


        ////Click Button , Checkbox, Option etc
        //public static void ClickLatest(IWebElement element)
        //{
        //    element.Click();
        //}

        ////Selecting a Dropdown control
        //public static void SelectDropDownLatest(IWebElement element, string value)
        //{
        //    new SelectElement(element).SelectByText(value);
        //}

        //THIRD REFACTOR using EXTENDED METHOD.
        //Refactore above methods
        public static void EnterText(this IWebElement element, string value)
        {
            element.SendKeys(value);
        }


        //Click Button , Checkbox, Option etc
        public static void Click(this IWebElement element)
        {
            element.Click();
        }

        //Selecting a Dropdown control
        public static void SelectDropDown(this IWebElement element, string value)
        {
            new SelectElement(element).SelectByText(value);
        }

    }
}

