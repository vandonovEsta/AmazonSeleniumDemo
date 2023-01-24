using AmazonDemo.Pages.ResultsPages.ResultPojo;
using OpenQA.Selenium;

namespace AmazonDemo.Pages.ResultsPages
{
    public partial class ResultsPage
    {
        private List<IWebElement> searchResults =>
            _driverHelper.FindElementsByXpath(
                    "//div[contains(@class, 's-main-slot') and contains(@class, 's-result-list')]//div[contains(@class, 'a-section')]/h2/a");

        private List<Result> results;
    }


}
