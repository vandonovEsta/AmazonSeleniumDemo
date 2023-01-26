
using AmazonDemo.TestFramework.helpers;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;


namespace AmazonDemo.Pages.DealsPages
{
    public partial class DealsPage : BasePage
    {
        public DealsPage() : base()
        {
            PageFactory.InitElements(WebDriverHelper.Instance.GetDriver(), this);
        }

        public IWebElement GetDealsPageHeader()
        {
            return TodaysDealsHeader;
        }
    }
}
