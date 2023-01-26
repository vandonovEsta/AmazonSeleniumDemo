using OpenQA.Selenium;

namespace AmazonDemo.Pages.HomePages
{
    public partial class HomePage
    {
        string glowToasterPopUpXpath = "//div[@class = 'glow-toaster-content']";
        IWebElement dontChangeLocationButton => _driverHelper.FindElementByXpath("//div[contains(@class, 'glow-toaster-footer')]//input[@data-action-type='DISMISS']");

        IWebElement ChangeLocationButton => _driverHelper.FindElementByXpath("//div[contains(@class, 'glow-toaster-footer')]//input[@data-action-type='SELECT_LOCATION']");
    }
}
