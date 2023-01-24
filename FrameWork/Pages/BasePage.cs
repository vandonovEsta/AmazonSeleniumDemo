using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Reflection;
using AmazonDemo.Pages.SubPages.HeaderSubPages;
using AmazonDemo.Pages.ResultsPages;
using AmazonDemo.helpers;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Interactions;

namespace AmazonDemo.Pages
{
    public abstract class BasePage
    {
        protected WebDriverHelper _driverHelper;
        protected Header header;

        protected const int EXPLICID_WAIT_TIME = 15;


        public BasePage() 
        { 
            
            this._driverHelper = WebDriverHelper.Instance;
            //TODO: Fix this!!!
            this._driverHelper.GetDriver().Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);

            header = new Header(this._driverHelper);

        }



        public void  Close()
        { 
           
            _driverHelper.GetDriver().Close();
        
        }

        public void Quit()
        {

            _driverHelper.Quit();

        }

        public String GetTitle()
        {
            return _driverHelper.GetDriver().Title;
        }

        public void Type(IWebElement element, String message)
        {
            element.SendKeys(message);
        }

        public ResultsPage SearchFor(String searchTest)
        {
            header.SearchFor(searchTest);
            return new ResultsPage();
        }

        public Header FromHeader()
        {
            return header;
        }
    }
}
