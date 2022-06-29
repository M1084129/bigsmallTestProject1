using FinalAssessment.CommonMethodObject;
using System;
using TechTalk.SpecFlow;

namespace FinalAssessment.FeatureFiles
{
    [Binding]
    public class GiftToWishlist
    {
        GiftToWishlistObj obj = new GiftToWishlistObj();
        [When(@"user click on Gift")]
        public void WhenUserClickOnGift()
        {
            obj.ClickOnGift();
            Serilog.Log.Debug("user click on gift");

        }

        [When(@"select Gift Card")]
        public void WhenSelectGiftCard()
        {
            obj.SelectGiftCard();
            Serilog.Log.Debug("user select gift card");

        }

        [When(@"select Qty")]
        public void WhenSelectQty()
        {
            obj.SelectQty();
            Serilog.Log.Debug("select Qty");

        }

        [When(@"Add to Wishlist")]
        public void WhenAddToWishlist()
        {
            
        }
    }
}
