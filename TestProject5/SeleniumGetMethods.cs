using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TestProject5
{
    internal class SeleniumGetMethods
    {
        public static string GetText(IWebElement element)
        {
            string user = element.GetAttribute("value");
            Console.WriteLine(user);
            return user;
        }
        public static string GetTextFromDDL(IWebElement element)
        {
                return new SelectElement(element).AllSelectedOptions.SingleOrDefault().Text;

        }
        public static string FetchTitle(IWebElement element , string ExpectedTitle)
        {
            string CurrentTitle = element.Text;
            Assert.AreEqual(ExpectedTitle, CurrentTitle);
            Console.WriteLine(CurrentTitle);
            return CurrentTitle;
            
        }

        public static bool IsDisplayed( IWebElement element)
        {
            bool result;
            try
            {
                result = element.Displayed;
                Console.WriteLine("element is displayed");
            }
            catch (Exception)
            {
                result = false;
                Console.WriteLine("element is not displayed");
            }
            return result;
        }

    }
}
