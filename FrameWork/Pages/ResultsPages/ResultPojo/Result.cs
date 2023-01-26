using OpenQA.Selenium;

namespace AmazonDemo.Pages.ResultsPages.ResultPojo
{
    public class Result
    {
        public Result(IWebElement resultElement, String resultName) { 
            this.resultName = resultName;
            this.resultElement = resultElement;
        }
        private IWebElement resultElement;

        private String resultName;
        
        public IWebElement GetResult()
        {
            return resultElement;
        }
        public String GetResultName() 
        { 
            return resultName; 
        }
    }
}
