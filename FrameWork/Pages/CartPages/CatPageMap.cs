using OpenQA.Selenium;

namespace AmazonDemo.Pages.CartPages
{
    public partial class CartPage
    {
        private IWebElement cartHeader => _driverHelper.FindElementByXpath("//div[contains(@class, 'sc-cart-header')]//h1");
        private IWebElement cartIsEmptyHeader => _driverHelper.FindElementByXpath("//div[contains(@class, 'sc-your-amazon-cart-is-empty')]/h2");
    }
}
