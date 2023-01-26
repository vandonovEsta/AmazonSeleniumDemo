using OpenQA.Selenium;

namespace AmazonDemo.Pages.SubPages.HeaderSubPages
{
    public partial class Header
    {
        private IWebElement searchBar => _driverHelper.FindElementById("twotabsearchtextbox");
        private IWebElement searchButton => _driverHelper.FindElementById("nav-search-submit-button");
        private IWebElement goToCartLink => _driverHelper.FindElementById("nav-cart");
        private IWebElement cartItemsCount => _driverHelper.FindElementById("nav-cart-count");
        private string cartPreviewBoxId = "ewc-content";
        private IWebElement cartPreviewBox => _driverHelper.FindElementById(cartPreviewBoxId);

        private IWebElement todaysDealsLink => _driverHelper.FindElementByXpath("//a[contains(text(), 'Today') and contains(text(), 'Deals')]");
    }
}
