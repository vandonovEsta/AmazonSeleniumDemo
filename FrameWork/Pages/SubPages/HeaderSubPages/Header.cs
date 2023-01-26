using AmazonDemo.Pages.CartPages;
using AmazonDemo.Pages.DealsPages;
using AmazonDemo.TestFramework.helpers;
using OpenQA.Selenium;

namespace AmazonDemo.Pages.SubPages.HeaderSubPages

{
    public partial class Header
    {
        WebDriverHelper _driverHelper;

        public Header(WebDriverHelper helper) 
        { 
            _driverHelper = helper;
        }

        
        public void SearchFor(String searchTest)
        {
            searchBar.SendKeys(searchTest);
            searchButton.Click();
        }

        public CartPage GoToCard()
        {
            goToCartLink.Click();
            return new CartPage();
        }

        public int GetCartItemsCount()
        {
            return  Int32.Parse(cartItemsCount.Text);
        }

        public void WaitUntilCartPopUp(int waitTimeInSeconds)
        {
            _driverHelper.WaitUntilById(cartPreviewBoxId, waitTimeInSeconds);
        }

        public CartPage GoToCart()
        {
            goToCartLink.Click();
            return new CartPage();
        }

        public DealsPage GoToTodaysDeals()
        {
            
            todaysDealsLink.Click();
            return new DealsPage();
            
        }
    }
}
