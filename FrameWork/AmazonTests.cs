using AmazonDemo.Pages.ResultsPages;
using NUnit.Framework;
using AmazonDemo.Pages.HomePages;
using OpenQA.Selenium;
using AmazonDemo.Utils;
using AmazonDemo.Utils;
using AmazonDemo.Pages.ResultsPages.ResultPojo;
using AmazonDemo.Pages.ProductPages;
using AmazonDemo.Pages.CartPages;
using AmazonDemo.TestFramework;

namespace AmazonDemo
{
    [TestFixture]
    public class AmazonTests : BaseTests
    {
        
        private HomePage amazonPage;
        [SetUp]
        public void SetUp() 
        {
            amazonPage = new HomePage();
        }

        [Test]
        public void NavigateToAmazonTest()
        {
            amazonPage.NavigateTo();
            Assert.IsTrue(amazonPage.GetTitle().Contains("Amazon.com"));
        }

        [Test]
        public void SearchForPotatoesTest()
        {
            amazonPage.NavigateTo();
            ResultsPage resultsPage = amazonPage.SearchFor("potatoes");
            Assert.IsTrue(resultsPage.GetResults().Count() > 0);
        }

        [Test]
        public void GoToProductPageTest()
        {
            amazonPage.NavigateTo();
            ResultsPage resultsPage = amazonPage.SearchFor("potatoes");
            List<Result> results = resultsPage.GetResults();
            int productIndex = RandomizerHelper.Instance.getRandomIndexFromList(results);
            String productName = results[productIndex].GetResultName();
            ProductPage productPage = resultsPage.GoToProduct(productIndex);
            Assert.AreEqual(productName, productPage.GetTitle());
        }

        [Test]
        public void AddToCardTest()
        {
            amazonPage.NavigateTo();
            ResultsPage resultsPage = amazonPage.SearchFor("smart watches for men");
            List<Result> results = resultsPage.GetResults();
            int productIndex = 1;
            ProductPage productPage = resultsPage.GoToProduct(productIndex);
            productPage.AddToCart();

            int cartItems = productPage.FromHeader().GetCartItemsCount();

            Assert.AreEqual(1, cartItems);
        }

        [Test]
        public void GoToEmptyCart()
        {
            amazonPage.NavigateTo();
            CartPage cartPage = amazonPage.FromHeader().GoToCard();
            Assert.IsTrue(cartPage.IsCartEmpty());
        }

        [Test]
        public void GoToFullCart()
        {
            amazonPage.NavigateTo();
            ResultsPage resultsPage = amazonPage.SearchFor("smart watches for men");
            List<Result> results = resultsPage.GetResults();
            int productIndex = 1;
            ProductPage productPage = resultsPage.GoToProduct(productIndex);
            productPage.AddToCart();
            CartPage cartPage = amazonPage.FromHeader().GoToCard();
            Assert.IsFalse(cartPage.IsCartEmpty());
        }


       

    }
}
