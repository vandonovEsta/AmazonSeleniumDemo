using AmazonDemo.Pages.DealsPages;
using OpenQA.Selenium;

namespace AmazonDemo.Pages.HomePages
{
    public partial class HomePage : BasePage
    {
 
        public HomePage() : base() { }
        
        public HomePage(bool maximize): base(maximize) { }
        public bool RemovePopUps()
        {
            bool popUpRemoved = false;

            try
            {
                _driverHelper.WaitUntilExistsByXpath(glowToasterPopUpXpath, 5);
                dontChangeLocationButton.Click();
                popUpRemoved = true;
            } catch(WebDriverTimeoutException ex) { 
                popUpRemoved = true;
            }
            return popUpRemoved;

        }

        public DealsPage GoToTodaysDeals()
        {
            RemovePopUps();
            return FromHeader().GoToTodaysDeals();
        }

        
    }
}
