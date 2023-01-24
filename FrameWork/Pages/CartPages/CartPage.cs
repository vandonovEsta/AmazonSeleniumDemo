using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonDemo.Pages.CartPages
{
    public partial class CartPage: BasePage
    {
        public CartPage(): base() 
        { 
            
        }

        public bool IsCartEmpty()
        {
            bool isEmpty = false;
            try
            {
                if (cartHeader.Displayed)
                {
                    isEmpty = false;
                }
                

            } catch(NoSuchElementException e)
            {
                if (cartIsEmptyHeader.Displayed)
                {
                    isEmpty = true;
                }

            }
            return isEmpty;

        }
    }
}
