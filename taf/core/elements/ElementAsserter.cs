using NUnit.Framework;
using NUnit.Framework.Constraints;
using OpenQA.Selenium;
using System;

namespace mentoring_taf.taf.core.elements
{
    public class ElementAsserter
    {
        private readonly IWebElement element;

        public ElementAsserter(IWebElement element)
        {
            this.element = element;
        }
        public ElementAsserter IsVisible()
        {
            this.HasVisibility(true);
            return this;
        }

        public ElementAsserter HasVisibility(bool shouldBeVisible)
        {
            bool actual;
            try
            {
                actual = element.Displayed;
            }
            catch (Exception e)
            {
                actual = false;
            }

            Assert.AreEqual(shouldBeVisible, actual, "Element should have condition [visible]=" + shouldBeVisible);
            return this;
        }

        public ElementAsserter TextContainsIgnoringCase(String expectedText)
        {
            String actual = element.Text.ToLower();
            Assert.IsTrue(expectedText.ToLower().Contains(actual), "Element does not contain text (ignoring case):" + expectedText);

            return this;
        }

        // binding method
        public ElementAsserter And()
        {
            return this;
        }
    }
}
