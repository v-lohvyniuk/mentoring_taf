using System;
using System.Collections.Generic;
using System.Text;

namespace mentoring_taf.taf.core.driver
{
    class DriverUtils
    {

        public static readonly int DEFAULT_IMPLICIT_WAIT_SEC = 30;
        public static void TurnOffImplicitWait()
        {
            DriverProvider.GetDriver().Manage().Timeouts().ImplicitWait = new TimeSpan(0, 0, 0);
        }
        
        public static void TurnOnImplicitWait()
        {
            DriverProvider.GetDriver().Manage().Timeouts().ImplicitWait = new TimeSpan(0, 0, DEFAULT_IMPLICIT_WAIT_SEC);
        }
    }
}
