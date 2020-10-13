using NUnit.Framework;
using RestSharp;
using System;
using System.Net;

namespace mentoring_taf.taf.core.api.asserter
{
    public class AssertThat
    {
        private IRestResponse target;


        public static AssertThat Response(IRestResponse response)
        {
            return new AssertThat(response);
        }

        private AssertThat(IRestResponse response)
        {
            this.target = response;
        }

        public AssertThat StatusIs(HttpStatusCode expectedStatusCode)
        {
            Assert.AreEqual(expectedStatusCode, target.StatusCode, "Status codes don't match");
            return this;
        }

        public AssertThat BodyContains(String expectedString)
        {
            Assert.IsTrue(target.Content.Contains(expectedString),
                "Response content does not contain expected str: " + expectedString);
            return this;
        }

        public AssertThat And()
        {
            // just a binding method
            return this;
        }
    }
}
