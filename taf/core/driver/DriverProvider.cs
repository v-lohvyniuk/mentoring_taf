using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace mentoring_taf.taf.core.driver
{
    class DriverProvider
    {

        private static IWebDriver driver;

        public static IWebDriver GetDriver()
        {
            if (driver == null)
            {
                new DriverManager().SetUpDriver(new ChromeConfig());

                ChromeOptions options = new ChromeOptions();
                options.AddArguments("--disable-extensions"); // to disable extension
                options.AddArguments("--disable-notifications"); // to disable notification
                options.AddArguments("--disable-application-cache");
                driver = new ChromeDriver(options);
                driver.Manage().Window.Maximize();
                driver.Manage().Timeouts().ImplicitWait = new TimeSpan(30);
            }
            return driver;
        }

        public static void EndDriverSession() 
        {
            if (driver != null)
            {
                driver.Quit();
                driver = null;
            }
        }
    }
}
