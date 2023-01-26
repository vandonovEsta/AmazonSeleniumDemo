using OpenQA.Selenium;

namespace AmazonDemo.TestFramework.helpers
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
