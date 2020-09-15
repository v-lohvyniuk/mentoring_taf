using mentoring_taf.taf.core.driver;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace mentoring_taf.taf.core.po.facebook
{
    public class BasePage
    {
        protected IWebDriver driver;

        public BasePage()
        {
         driver = DriverProvider.GetDriver();
         PageFactory.InitElements(driver, this);
        }
    }
}
