using FinalAssessment.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalAssessment.CommonMethodObject
{
    class addToCartObj
    {
       public void ClickOnSale()
        {
            BaseClass.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            
            IWebElement mainMenu;
            mainMenu = BaseClass.driver.FindElement(By.XPath("//a[@data-dropdown-rel='sale']"));
            mainMenu.Click();
            
        }

        public void ClickOnItem()
        {
            BaseClass.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);


            IWebElement element;
            element = BaseClass.driver.FindElement(By.XPath("//div[@data-id='2114990145624']"));
            element.Click();

        }
        public void AddQty()
        {
            BaseClass.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            IWebElement element;
            element = BaseClass.driver.FindElement(By.XPath("//span[@class='js--qty-adjuster js--add']"));
            element.Click();
        }
        public void AddToCart()
        {
            BaseClass.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            IWebElement element;
            element = BaseClass.driver.FindElement(By.XPath("//span[@data-default-text='Add to cart']"));
            element.Click();
        }

        public void ChechOut()
        {
            IWebElement checkout;
            checkout = BaseClass.driver.FindElement(By.XPath("//button[@name='checkout']"));
            checkout.Click();
        }

        public void ContinueShoping()
        {

            BaseClass.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            IWebElement continueshop;
            continueshop = BaseClass.driver.FindElement(By.XPath("//button[@id='continue_button']"));
            continueshop.Click();
        }


    }
}
