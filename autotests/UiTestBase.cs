using mentoring_taf.taf.core.driver;
using NUnit.Allure.Core;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace mentoring_taf.autotests
{
    [AllureNUnit]
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class UiTestBase
    {
        [TearDown]
        public void finalizeDriver()
        {
            DriverProvider.EndDriverSession();
        }
    }
}
