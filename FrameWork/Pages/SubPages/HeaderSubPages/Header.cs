using AmazonDemo.helpers;
using AmazonDemo.Pages.CartPages;
using OpenQA.Selenium;
using System.Reflection.Metadata.Ecma335;

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
    }
}
