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
    internal class LoginPageObject
    {
        public LoginPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.Name, Using = "UserName")]
        public IWebElement txtUserName { get; set; }

        [FindsBy(How = How.Name, Using = "Password")]
        public IWebElement txtPassword { get; set; }

        [FindsBy(How = How.Name, Using = "Login")]
        public IWebElement btnLogin { get; set; }

        [FindsBy(How = How.XPath, Using = "/ html / body / h1")]
        public IWebElement CheckTitlePageLogin { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/h2")]
        public IWebElement CheckExistingLogin { get; set; }

        

        public PageObject Login(string username, string password)
        {
            
            SeleniumGetMethods.FetchTitle(CheckTitlePageLogin, "Execute Automation Selenium Test Site");
            SeleniumGetMethods.FetchTitle(CheckExistingLogin, "Login");

            // UserName
            txtUserName.SendKeys(username);
            SeleniumGetMethods.GetText(txtUserName);
            
            // Password
            txtPassword.SendKeys(password);
            // Click button
            btnLogin.Submit();
            // Return the page object
            return new PageObject();
        }

    }

}
