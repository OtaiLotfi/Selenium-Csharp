
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace TestProject5
{
    
    internal class PageObject
    {
        public PageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver,this);
        }

        [FindsBy(How=How.Id, Using ="TitleId")]
       public IWebElement ddlTitleID { get; set; }

        [FindsBy(How = How.Name, Using = "Initial")]
        public IWebElement txtinitial { get; set; }

        [FindsBy(How = How.Id, Using = "FirstName")]
        public IWebElement txtFirstName { get; set; }

        [FindsBy(How = How.Name, Using = "MiddleName")]
        public IWebElement textMiddleName { get; set; }

        [FindsBy(How = How.Name, Using = "Save")]
        public IWebElement btnSave { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#details > h2")] 
        public IWebElement CheckexistingUser { get; set; }
         
       
        public void FillUserForm(string titleId,string initial, string middleName, string firstName)
        {
            
            SeleniumGetMethods.FetchTitle(CheckexistingUser, "User Form");
            SeleniumSetMethods.SelectDropDown(ddlTitleID, titleId);
            SeleniumGetMethods.IsDisplayed(ddlTitleID);
            SeleniumSetMethods.EnterText(txtinitial, initial);
            SeleniumSetMethods.EnterText(txtFirstName, firstName);
            SeleniumSetMethods.EnterText(textMiddleName, middleName);
            SeleniumSetMethods.Click(btnSave);
            
        }
    }
}
