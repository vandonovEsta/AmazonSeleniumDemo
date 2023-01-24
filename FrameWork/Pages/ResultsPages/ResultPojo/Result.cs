using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V106.DOM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
