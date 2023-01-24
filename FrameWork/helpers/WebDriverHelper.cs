using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AmazonDemo.helpers
{
    public sealed class WebDriverHelper
    {
        private static WebDriverHelper instance;
        private static IWebDriver driver;
        private static WebDriverWait wait;
        private static Actions actions;
        private static bool isDisposed = false;
        private WebDriverHelper() {
            driver = new ChromeDriver();
            
        }

        public static WebDriverHelper Instance { 
            get 
            { 
                if(instance == null)
                {
                    instance = new WebDriverHelper();
                }
                return instance; 
            } 
        }

        public  IWebDriver GetDriver()
        {
            //This may be redundant
            if(isDisposed)
            {
               driver = new ChromeDriver();
                isDisposed = false;
            }
            return driver; 
        }
        public void Close()
        {
            driver.Close();
        }
        public void Quit()
        {
            driver.Quit();
            isDisposed = true; 
            
        }

        public Actions GetActions()
        {
            actions = new Actions(GetDriver());
            return actions;
        }

       

        public IWebElement FindElementById(string id)
        {
            return driver.FindElement(By.Id(id));
        }

        public List<IWebElement> FindElementsById(string id)
        {
            return driver.FindElements(By.Id(id)).ToList();
        }

        public IWebElement FindElementByXpath(string xpath)
        {
            return driver.FindElement(By.XPath(xpath));
        }

        public List<IWebElement> FindElementsByXpath(string xpath)
        {
            return driver.FindElements(By.XPath(xpath)).ToList(); 
        }

        public void WaitUntilById(string id, int timeOutInSeconds)
        {
            wait = new WebDriverWait(GetDriver(), TimeSpan.FromSeconds(timeOutInSeconds));
            wait.Until(ExpectedConditions.ElementExists(By.Id(id)));
        }

    }
}
