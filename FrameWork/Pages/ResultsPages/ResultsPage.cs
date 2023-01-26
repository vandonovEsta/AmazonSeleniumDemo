using AmazonDemo.Pages.ProductPages;
using AmazonDemo.Pages.ResultsPages.ResultPojo;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;

namespace AmazonDemo.Pages.ResultsPages
{
    public partial class ResultsPage : BasePage
    {
        
        public ResultsPage() : base() {
            results = new List<Result>();
            foreach(IWebElement searchResult in searchResults)
            {
                results.Add(new Result(searchResult, searchResult.Text));
            }
        }

        public List<Result> GetResults() 
        { 
            return results;
        }

        public ProductPage GoToProduct(int productNumber)
        {
            bool isNotClicked = true;
            do
            {   try
                {
                    IWebElement selection = results[productNumber].GetResult();

                    string selectionTest = selection.Text;
                    this._driverHelper.GetDriver().ExecuteJavaScript("var ele = arguments[0];ele.addEventListener('click', function() {ele.setAttribute('automationTrack','true');});", selection);

                    _driverHelper.GetActions().MoveToElement(selection).Click().Perform();
                    isNotClicked = Boolean.Parse(selection.GetAttribute("automationTrack"));
                } catch(StaleElementReferenceException e)
                {
                    break;
                }
            } while (isNotClicked);

            return new ProductPage();
        }

        public ProductPage GoToProduct(string productName)
        {
            bool isProductFound = false;
            foreach(Result result in results)
            {
                if(result.GetResultName().Contains(productName))
                {
                    
                    result.GetResult().Click();
           
                    isProductFound = true;
                    
                    break;
                }

            }
            if (!isProductFound)
            {
                throw new Exception($"Product with name {productName} is missing from the product list");
            }
            else
            {
                return new ProductPage();
            }
        }
    }
}
