using OpenQA.Selenium;

namespace AmazonDemo.Pages.ProductPages
{
    public partial class ProductPage
    {
        private String productTitle => _driverHelper.FindElementById("productTitle").Text;
        private IWebElement addToCartButton => _driverHelper.FindElementById("add-to-cart-button");
        private IWebElement buyNotButton => _driverHelper.FindElementById("buy-now-button");
    }
}
