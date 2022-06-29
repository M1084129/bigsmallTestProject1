using FinalAssessment.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalAssessment.CommonMethodObject
{
    class CreateAccountObj
    {
       public void OnCreateAccount()
        {
            
            IWebElement element;
            element = BaseClass.driver.FindElement(By.XPath("//a[@id ='customer_register_link']"));
            element.Click();

        }

        public void AccountDetail(string fname, string lname, string em, string pass)
        {
            IWebElement name;
            name = BaseClass.driver.FindElement(By.Id("FirstName"));
            name.SendKeys(fname);
            IWebElement name1;
            name1 = BaseClass.driver.FindElement(By.Id("LastName"));
            name1.SendKeys(lname);
            IWebElement Email;
            Email = BaseClass.driver.FindElement(By.Id("Email"));
            Email.SendKeys(em);
            IWebElement password;
            password = BaseClass.driver.FindElement(By.Id("CreatePassword"));
            password.SendKeys(pass);

        }

        public void OnCreateButton()
        {
            IWebElement createbtn;
            createbtn = BaseClass.driver.FindElement(By.XPath("//input[@value='Create']"));
            createbtn.Click();
        }
    }
}
