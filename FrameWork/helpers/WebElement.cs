using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonDemo.helpers
{
    internal class WebElement
    {
        public IWebElement Element { get; set; }
        public By LocateBy { get; set; }
        public string Locator { get; set; }

        public WebElement(IWebDriver driver, By locateBy)
        {
            LocateBy = locateBy;
            Locator = locateBy.ToString();
        }

    }

}
