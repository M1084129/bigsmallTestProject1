using FinalAssessment.CommonMethodObject;
using System;
using TechTalk.SpecFlow;

namespace FinalAssessment.FeatureFiles
{
    [Binding]
    public class AddCartSteps
    {
        addToCartObj obj = new addToCartObj();
        [When(@"user click on sale")]
        public void WhenUserClickOnSale()
        {
            obj.ClickOnSale();
            Serilog.Log.Debug("user click on sale");
        }

        [When(@"user click on Item")]
        public void WhenUserClickOnItem()
        {
            obj.ClickOnItem();
            Serilog.Log.Debug("user click on item");

        }



        [When(@"user Add Qty")]
        public void WhenUserAddQty()
        {
            obj.AddQty();
            Serilog.Log.Debug("user Add to Qty");

        }

        [When(@"user click on Add to Cart")]
        public void WhenUserClickOnAddToCart()
        {
            obj.AddToCart();
            Serilog.Log.Debug("user click on Add to Cart");

        }

        [When(@"user click on Checkout")]
        public void WhenUserClickOnCheckout()
        {
            obj.ChechOut();
            Serilog.Log.Debug("user click on Checkout");

        }

        [Then(@"Continue Shopping")]
        public void ThenContinueShopping()
        {
            obj.ContinueShoping();
            Serilog.Log.Debug("user click on continue shopping");

        }


    }
}
