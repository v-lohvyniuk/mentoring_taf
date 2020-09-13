using mentoring_taf.taf.core.driver;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace mentoring_taf.taf.utils
{
    public class Wait
    {
        public static void UntilPageLoaded(int timeoutSec = 15)
        {
            IWebDriver driver = DriverProvider.GetDriver();
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, timeoutSec));
            wait.Until(wd => js.ExecuteScript("return document.readyState").ToString() == "complete");
        }
    }
}
