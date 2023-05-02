using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace TestProject5
{
    public class Tests
    {
       // IWebDriver driver = new ChromeDriver();
        [SetUp]
        public void Initialize()
        {
            PropertiesCollection.driver = new ChromeDriver();
            PropertiesCollection.driver.Manage().Window.Maximize();
            Thread.Sleep(1000);

            // Navigate to the page 
            PropertiesCollection.driver.Navigate().GoToUrl("https://demosite.executeautomation.com/Login.html"); 
           
            Console.WriteLine("Opned URL");
        }
        
        [Test]
        public void ExecuteTest()
        {

             LoginPageObject pageLogin = new LoginPageObject();
            // Login Page
             PageObject page = pageLogin.Login("New TESTER", "RGI GROUP");
            // User Page
             page.FillUserForm("Mr.", "execute test", "OTAI", "Lotfi");
            
        }


        [TearDown]
        public void ClearUp()
        {
            //driver.Close();
            Console.WriteLine("Closed Browser");
        }
    }
}