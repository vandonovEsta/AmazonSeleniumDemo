using OpenQA.Selenium;

namespace AmazonDemo.Pages.HomePages
{
    public partial class HomePage : BasePage
    {
 
        public HomePage() : base() { }
        public void NavigateTo()
        {
            this._driverHelper.GetDriver().Navigate().GoToUrl("https://www.amazon.com/");
        }

        
    }
}
