using AmazonDemo.helpers;
using AmazonDemo.TestFramework;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebElement = AmazonDemo.helpers.WebElement;

namespace AmazonDemo
{
    [TestFixture]
    internal class FrameworkUnitTests : BaseTests
    {
        private IWebDriver driver ;

        [SetUp] 
        public void SetUp() 
        {
            driver = WebDriverHelper.Instance.GetDriver();
        }

        [Test]
        public void testSingletonDriver()
        {
            driver.Navigate().GoToUrl("http://www.google.com");
        }

        [Test]
        public void test00()
        {
            //WebElement element = new helpers.WebElement(driver, By.Id("1234"));
            //Assert.AreEqual("", element.Locator);
            driver.Navigate().GoToUrl("http://www.abv.bg");
            //WebElement element = new WebElement(driver, By.Id("username"));
            //IWebElement webElement = driver.FindElement(By.Id("username"));
            //Assert.AreEqual("", element.ToStrin);
            WebDriverHelper.Instance.WaitUntilById("1654", 10);
        }
    }
}
