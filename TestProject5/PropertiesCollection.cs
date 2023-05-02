using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject5
{

    enum PropertyType
    {
        Id,
        Name,
        LinkText,
        CssName,
        ClassName
    }
    internal class PropertiesCollection
    {
        // Auto-Imlementesd Properties

        public static IWebDriver driver{get; set;}
    }
}
