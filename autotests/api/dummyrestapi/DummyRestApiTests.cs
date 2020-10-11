using mentoring_taf.taf.core.api.client;
using NUnit.Allure.Core;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace mentoring_taf.autotests.api.dummyrestapi
{
    [AllureNUnit]
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    class DummyRestApiTests
    {
        [Test]
        public void GetDummyApiAllEmployees_PositiveTestCase()
        {
            RequestData requestData = new RequestData()
                .WithUrl("/employee")
                .WithQueryParam("all", "true");

            ApiClient.GetInstance()
                .WithRequestData(requestData)
                .DoGet();
        }
    }
}
