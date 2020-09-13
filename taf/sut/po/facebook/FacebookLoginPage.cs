using mentoring_taf.taf.utils;
using NUnit.Framework.Constraints;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;

namespace mentoring_taf.taf.core.po.facebook
{
    public class FacebookLoginPage : BasePage
    {
        public FacebookLoginPage()
        {
            PageFactory.InitElements(driver, this);
        }


        [FindsBy(How = How.XPath, Using = "//*[@data-testid='royal_email']")]
        private IWebElement emailInput;

        [FindsBy(How = How.XPath, Using = "//*[@data-testid='royal_pass']")]
        private IWebElement passwordInput;

        public void FillEmail(String inputData)
        {
            emailInput.SendKeys(inputData);
        }

        public void FillPassword(String pass)
        {
            passwordInput.SendKeys(pass);            
        }

        public void SubmitLoginForm()
        {
            passwordInput.Submit();
            Wait.UntilPageLoaded();
        }
    }
}
