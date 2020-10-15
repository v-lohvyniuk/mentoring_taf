using mentoring_taf.taf.core.api.asserter;
using mentoring_taf.taf.core.api.client;
using mentoring_taf.taf.core.api.marshalling;
using mentoring_taf.taf.sut.dto;
using NUnit.Allure.Core;
using NUnit.Framework;
using RestSharp;
using System;
using System.Net;

namespace mentoring_taf.autotests.api.dummyrestapi
{
    [AllureNUnit]
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    class DummyRestApiTests
    {

        private ApiClient client = ApiClient.GetInstance();
        private Unmarshaller unmarshaller = new Unmarshaller();

        [Test]
        public void GetDummyApiAllEmployees_PositiveTestCase()
        {
            var getEmployeesRs = client.GET(client
                .Request()
                .Path("/employees")
                .QueryParam("all", "true")
                .Build());

            AssertThat.Response(getEmployeesRs)
                .StatusIs(HttpStatusCode.OK);
        }

        [Test]
        public void CreateNewEmployee_PositiveTestCase()
        {
            var newEmployee = CreateEmployeeDTO.Generated();

            var createEmployeeRs = client.POST(
                client.Request()
                .Path("/create")
                .Body(newEmployee)
                .Build()
                );

            AssertThat.Response(createEmployeeRs)
                .StatusIs(HttpStatusCode.OK)
                .And()
                .BodyContains("Successfully! Record has been added.");
        }

        [Test]
        public void GetCreatedEmployeeData_PositiveTestCase()
        {
            var newEmployee = CreateEmployeeDTO.Generated();

            var createEmployeeRs = client.POST(
                client.Request()
                .Path("/create")
                .Body(newEmployee)
                .Build()
                );

            AssertThat.Response(createEmployeeRs)
                .StatusIs(HttpStatusCode.OK);
            var createEmployeeRsDTO = unmarshaller.Unmarshal<CreateEmployeeRsDTO>(createEmployeeRs);

            var getEmployeeRs = client.GET(
                client.Request()
                .Path($"/employee/{createEmployeeRsDTO.data.id}")
                .Build()
                );

            AssertThat.Response(getEmployeeRs)
                .StatusIs(HttpStatusCode.OK)
                .And()
                .BodyContains("Successfully! Record has been fetched");
        }
    }
}
