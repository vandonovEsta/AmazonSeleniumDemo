using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonDemo.Pages.DealsPages
{
    public partial class DealsPage
    {
        [FindsBy(How = How.XPath, Using = "//div[@id='slot-2']//h1")]
        private IWebElement TodaysDealsHeader { get; set; }
    }
}
