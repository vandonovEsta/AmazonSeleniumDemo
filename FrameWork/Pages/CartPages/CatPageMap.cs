using AmazonDemo.helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonDemo.Pages.CartPages
{
    public partial class CartPage
    {
        private IWebElement cartHeader => _driverHelper.FindElementByXpath("//div[contains(@class, 'sc-cart-header')]//h1");
        private IWebElement cartIsEmptyHeader => _driverHelper.FindElementByXpath("//div[contains(@class, 'sc-your-amazon-cart-is-empty')]/h2");
    }
}
