using AmazonDemo.Pages.ResultsPages;
using NUnit.Framework;
using AmazonDemo.Pages.HomePages;
using AmazonDemo.Utils;
using AmazonDemo.Pages.ResultsPages.ResultPojo;
using AmazonDemo.Pages.ProductPages;
using AmazonDemo.Pages.CartPages;
using AmazonDemo.TestFramework;
using AmazonDemo.Pages.DealsPages;

namespace AmazonDemo
{
    [TestFixture]
    public class AmazonTests : BaseTests
    {
        
        private HomePage amazonPage;

        [SetUp]
        public void SetUp() 
        {
            amazonPage = new HomePage(true);
            amazonPage.NavigateTo();
        }

        [Test]
        public void NavigateToAmazonTest()
        {
            
            Assert.IsTrue(amazonPage.GetTitle().Contains("Amazon.com"));
        }

        [Test]
        public void SearchForPotatoesTest()
        {
            
            ResultsPage resultsPage = amazonPage.SearchFor("potatoes");

            Assert.IsTrue(resultsPage.GetResults().Count() > 0);
        }

        [Test]
        public void GoToProductPageTest()
        {
            
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
            
            ResultsPage resultsPage = amazonPage.SearchFor("smart watches for men");
            List<Result> results = resultsPage.GetResults();
            int productIndex = 1;
            ProductPage productPage = resultsPage.GoToProduct(productIndex);


            productPage.AddToCart();

            Assert.AreEqual(1, productPage.FromHeader().GetCartItemsCount());
        }

        [Test]
        public void GoToEmptyCart()
        {
            
            CartPage cartPage = amazonPage.FromHeader().GoToCard();

            Assert.IsTrue(cartPage.IsCartEmpty());
        }

        [Test]
        public void GoToFullCart()
        {
            ResultsPage resultsPage = amazonPage.SearchFor("smart watches for men");
            List<Result> results = resultsPage.GetResults();
            int productIndex = 1;
            ProductPage productPage = resultsPage.GoToProduct(productIndex);

            productPage.AddToCart();

            CartPage cartPage = amazonPage.FromHeader().GoToCard();
            Assert.IsFalse(cartPage.IsCartEmpty());
        }

        [Test]
        public void GoToTodaysDealsTesT()
        {
            DealsPage dealsPage = amazonPage.GoToTodaysDeals();
            Assert.IsTrue(dealsPage.GetDealsPageHeader().Displayed);
        }

       

    }
}
