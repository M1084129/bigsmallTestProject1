using FinalAssessment.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalAssessment.CommonMethodObject
{
    class GiftToWishlistObj
    {
        public void ClickOnGift()
        {
            IWebElement giftbtn;
            giftbtn = BaseClass.driver.FindElement(By.XPath("//i[@class='fa fa-gift']"));
            giftbtn.Click();
        }
        public void SelectGiftCard()
        {
            BaseClass.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            IWebElement giftcard;
            giftcard = BaseClass.driver.FindElement(By.XPath("//label[@for='ProductSelect-738195636312-option-title-Rs.+2000']"));
            giftcard.Click();
        }
        public void SelectQty() 
        {
            BaseClass.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            IWebElement qty;
            qty = BaseClass.driver.FindElement(By.XPath("//span[@class='js--qty-adjuster js--add']"));
            qty.Click();
        }
        




    }
}
