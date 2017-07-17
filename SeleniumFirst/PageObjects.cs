using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    class PageObjectsEAsite
    {
        public PageObjectsEAsite()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }
        
        //page UI elements for website http://www.executeautomation.com/demosite/index.html#
        [FindsBy(How=How.Id,Using ="TitleId")]
        public IWebElement ddlTitleId { get; set; }

        [FindsBy(How = How.Name, Using = "Initial")]
        public IWebElement txtInitial { get; set; }


        [FindsBy(How = How.Name, Using = "FirstName")]
        public IWebElement txtFirstName { get; set; }


        [FindsBy(How = How.Name, Using = "MiddleName")]
        public IWebElement txtMiddleName { get; set; }


        [FindsBy(How = How.Name, Using = "Save")]
        public IWebElement btnSave { get; set; }

        ////Common function that Fill out all the details on the selected page by calling into one method that does fill all the given field values
        //public PageObjectsEAsite EnterAllDetails(string Initial, string FirstName, string MiddleName)
        //{
        //    //Type in Initial text and click Save button
        //    txtInitial.SendKeys(Initial);
        //    txtFirstName.SendKeys(FirstName);
        //    txtMiddleName.SendKeys(MiddleName);

        //    //click Save button
        //    btnSave.Click();
        //    return new PageObjectsEAsite();
        //}

        ////SECOND REFACTOR: Common function that Fill out all the details on the selected page by calling into one method that does fill all the given field values
        //public PageObjectsEAsite EnterAllDetailsLatest(string Initial, string FirstName, string MiddleName)
        //{
        //    //Type in Initial text and click Save button
        //    SeleniumSetMethods.EnterTextLatest(txtInitial,Initial);
        //    SeleniumSetMethods.EnterTextLatest(txtFirstName,FirstName);
        //    SeleniumSetMethods.EnterTextLatest(txtMiddleName,MiddleName);

        //    //click Save button
        //    SeleniumSetMethods.ClickLatest(btnSave);
        //    return new PageObjectsEAsite();
        //}

        //Common function that Fill out all the details on the selected page by calling into one method that does fill all the given field values
        public PageObjectsEAsite EnterAllDetails(string title, string Initial, string FirstName, string MiddleName)
        {
            //Select Ms. from title dropdown box
            ddlTitleId.SelectDropDown(title);
            
            //Type in Initial text and click Save button
            txtInitial.EnterText(Initial);
            txtFirstName.EnterText(FirstName);
            txtMiddleName.EnterText(MiddleName);
            
            //click Save button
            btnSave.Click();
            return new PageObjectsEAsite();
        }
    }
}
