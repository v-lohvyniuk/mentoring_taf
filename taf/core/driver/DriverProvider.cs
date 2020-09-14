using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace mentoring_taf.taf.core.driver
{
    class DriverProvider
    {

        private static ThreadLocal<IWebDriver> driverPool = new ThreadLocal<IWebDriver>();

        static DriverProvider()
        {
                new DriverManager().SetUpDriver(new ChromeConfig());

        }

        public static IWebDriver GetDriver()
        {
            if (driverPool.Value == null)
            {
                driverPool.Value = new ChromeDriver(GetDefaultChromeOptions());
                
                driverPool.Value.Manage().Window.Maximize();
                driverPool.Value.Manage().Timeouts().ImplicitWait = new TimeSpan(0, 0, DriverUtils.DEFAULT_IMPLICIT_WAIT_SEC);
            }
            return driverPool.Value;
        }

        public static void EndDriverSession() 
        {
            if (driverPool.Value != null)
            {
                driverPool.Value.Quit();
                driverPool.Value = null;
            }
        }

        private static ChromeOptions GetDefaultChromeOptions()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--disable-extensions"); // to disable extension
            options.AddArguments("--disable-notifications"); // to disable notification
            options.AddArguments("--disable-application-cache");

            return options;
        }
    }
}
