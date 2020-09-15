using mentoring_taf.taf.core.driver;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;

namespace mentoring_taf.taf.core.elements
{
    public class ElementCollectionAsserter
    {
        private readonly List<IWebElement> elements;

        public ElementCollectionAsserter(IList<IWebElement> elements)
        {
            this.elements = new List<IWebElement>(elements);
        }

        public ElementCollectionAsserter HaveSize(int expectedSize)
        {
            Assert.AreEqual(expectedSize, elements.Count, "Element list does not have expected size");
            return this;
        }

        public ElementCollectionAsserter AllAreVisible()
        {
            List<IWebElement> visibleElements = elements.FindAll(element => element.Displayed);

            Assert.AreEqual(elements.Count, visibleElements.Count, "Not all elements are visible");
            return this;
        }
    }
}
