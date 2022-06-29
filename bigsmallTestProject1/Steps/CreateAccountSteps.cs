using FinalAssessment.CommonMethodObject;
using System;
using TechTalk.SpecFlow;

namespace FinalAssessment.FeatureFiles
{
    [Binding]
    public class CreateAccountSteps
    {
        CreateAccountObj obj = new CreateAccountObj();
        [When(@"click on create account")]
        public void WhenClickOnCreateAccount()
        {
            obj.OnCreateAccount();
        }

        [When(@"User Enter test(.*),user(.*),testuser_(.*),Test@(.*)")]
        public void WhenUserEnterTestUserTestuser_Test(string firstname, string lastname, string email,string password)
        {
            obj.AccountDetail(firstname, lastname, email, password);
            Serilog.Log.Debug("user enter {0},{0},{0},{0}",firstname,lastname,email,password);

        }


        [When(@"user enter on click on create button")]
        public void WhenUserEnterOnClickOnCreateButton()
        {
            obj.OnCreateButton();
            Serilog.Log.Debug("user click on create button");

        }
    }
}
