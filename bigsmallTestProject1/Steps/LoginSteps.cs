using FinalAssessment.CommonMethodObject;
using System;
using TechTalk.SpecFlow;

namespace FinalAssessment.FeatureFiles
{
    [Binding]
    public class LoginSteps
    {
        LoginObj obj = new LoginObj();

        [Given(@"home page of the website")]
        public void GivenHomePageOfTheWebsite()
        {
            obj.VerifyHome();
            Serilog.Log.Debug("user is on home page");

        }

        [When(@"user click on sign in")]
        public void WhenUserClickOnSignIn()
        {
            obj.SignInButton();
            Serilog.Log.Debug("user click on- sign in ");

        }

        [When(@"User enter testuser_(.*) and Test@(.*)")]
        public void WhenUserEnterTestuser_AndTest(string username, string password)
        {
            obj.EnterEmailAndPassword(username, password);
            Serilog.Log.Debug("user enter {0},{0}",username,password);

        }



        [When(@"user enter on click on login button")]
        public void WhenUserEnterOnClickOnLoginButton()
        {
            obj.LoginButton();
        }
        
        [Then(@"the result")]
        public void ThenTheResult()
        {
            
        }
    }
}
