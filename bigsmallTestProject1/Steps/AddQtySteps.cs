using FinalAssessment.CommonMethodObject;
using System;
using TechTalk.SpecFlow;

namespace FinalAssessment.FeatureFiles
{
    [Binding]
    public class AddQtySteps
    {
        AddQtyObj obj = new AddQtyObj();
        [When(@"user click on PersonalizedGift")]
        public void WhenUserClickOnPersonalizedGift()
        {
            obj.PersonalizedGift();
            Serilog.Log.Debug("user click on personalized gift");

        }

        [When(@"user click on item")]
        public void WhenUserClickOnItem()
        {
            obj.ClickOnItem();
            Serilog.Log.Debug("user click on items");

        }

        [When(@"user click on Add Qty")]
        public void WhenUserClickOnAddQty()
        {
            obj.AddQty();
            Serilog.Log.Debug("user click on Add Qty");

        }

    }
}
