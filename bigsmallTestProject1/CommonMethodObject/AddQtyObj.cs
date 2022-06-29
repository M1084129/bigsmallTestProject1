using FinalAssessment.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalAssessment.CommonMethodObject
{
    class AddQtyObj
    {
        public void PersonalizedGift()
        {
            IWebElement webElement;
            webElement = BaseClass.driver.FindElement(By.XPath("//a[@title='Personalized']"));
            webElement.Click();
        }
        public void ClickOnItem()
        {
            IWebElement webElement;
            webElement = BaseClass.driver.FindElement(By.XPath("//a[@data-product-id='7186117689542']"));
            webElement.Click();
        }
        public void AddQty()
        {
            BaseClass.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            IWebElement element;
            element = BaseClass.driver.FindElement(By.XPath("//span[@class='js--qty-adjuster js--add']"));
            element.Click();
        }
    }
}
