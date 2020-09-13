using mentoring_taf.taf.core.driver;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace mentoring_taf.autotests
{
    public class UiTestBase
    {
        [TearDown]
        public void finalizeDriver()
        {
            DriverProvider.EndDriverSession();
        }
    }
}
