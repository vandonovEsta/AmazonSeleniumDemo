namespace AmazonDemo.Pages.ProductPages
{
    public partial class ProductPage: BasePage
    {
        public ProductPage() : base()
        {
        }

        public new string GetTitle()
        {
            return productTitle;
        }

        public void AddToCart()
        {
            addToCartButton.Click();
            header.WaitUntilCartPopUp(EXPLICID_WAIT_TIME);
        }

        //TODO: change return type to LoginPage!!!
        public void BuyNow()
        {
            buyNotButton.Click();
        }
    }
}
