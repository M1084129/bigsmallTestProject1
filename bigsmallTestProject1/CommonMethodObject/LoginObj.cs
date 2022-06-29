using FinalAssessment.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalAssessment.CommonMethodObject
{
    class LoginObj
    {
        public void VerifyHome()
        {
            System.Threading.Thread.Sleep(3000);
            IWebElement home;
            home = BaseClass.driver.FindElement(By.XPath("//div[@class='h1 site-header__logo']"));
            bool visible = home.Displayed;
            Assert.That(visible, Is.EqualTo(true));
        }

        public void SignInButton()
        {
            IWebElement signbtn;
            signbtn = BaseClass.driver.FindElement(By.XPath("//i[@class='fa fa-user']"));
            signbtn.Click();
        }

        public void EnterEmailAndPassword(string user,string pas)
        {
            IWebElement email;
            email = BaseClass.driver.FindElement(By.Id("CustomerEmail"));
            email.SendKeys(user);
            IWebElement pass;
            pass = BaseClass.driver.FindElement(By.Id("CustomerPassword"));
            pass.SendKeys(pas);
        }

        public void LoginButton()
        {
            IWebElement loginbtn;
            loginbtn = BaseClass.driver.FindElement(By.XPath("//input[@value='Sign In']"));
            loginbtn.Click();

        }
    }
}
