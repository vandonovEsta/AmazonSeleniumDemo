using OpenQA.Selenium;
using AmazonDemo.Pages.SubPages.HeaderSubPages;
using AmazonDemo.Pages.ResultsPages;
using AmazonDemo.TestFramework.helpers;

namespace AmazonDemo.Pages
{
    public abstract class BasePage
    {
        protected WebDriverHelper _driverHelper;
        protected Header header;
        protected bool maximizePage = false;
        protected const int EXPLICID_WAIT_TIME = 15;


        public BasePage() 
        { 
            
            this._driverHelper = WebDriverHelper.Instance;
            //TODO: Fix this!!!
            this._driverHelper.GetDriver().Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);

            header = new Header(this._driverHelper);

        }

        public BasePage(bool maximizePage) :this()
        {
            this.maximizePage = maximizePage;
        }

        public void NavigateTo()
        {
            this._driverHelper.GetDriver().Navigate().GoToUrl("https://www.amazon.com/");

            if (maximizePage)
            {
                this._driverHelper.GetDriver().Manage().Window.Maximize();
            }
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
