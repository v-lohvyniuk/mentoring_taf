using mentoring_taf.taf.core.driver;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace mentoring_taf.taf.core.elements
{
    public class ElementAsserter
    {
        private readonly IWebElement element;
        private static readonly TimeSpan DEFAULT_VISIBILITY_TIMEOUT = new TimeSpan(0, 0, 10);

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
            DriverUtils.TurnOffImplicitWait();

            try
            {
                WebDriverWait wait = new WebDriverWait(DriverProvider.GetDriver(), DEFAULT_VISIBILITY_TIMEOUT);
                wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
                wait.Until(driver => element.Displayed == shouldBeVisible);

            }
            catch (WebDriverTimeoutException e)
            {
                if (shouldBeVisible)
                {
                    Assert.Fail("Element should have condition [visible]=" + shouldBeVisible + "\n" + e);
                }
            }
            finally
            {
                DriverUtils.TurnOnImplicitWait();
            }

            return this;
        }

        public ElementAsserter TextContainsIgnoringCase(String expectedText)
        {
            String actual = element.Text.ToLower();
            Assert.IsTrue(expectedText.ToLower().Contains(actual), "Element does not contain text (ignoring case):" + expectedText);

            return this;
        }

        public ElementAsserter AttributeContains(String attrName, String attrContainingValue)
        {
            String actual = element.GetAttribute(attrName);

            Assert.IsTrue(actual.ToLower().Contains(attrContainingValue),
                "Attribute " + attrName + " should contain value " + attrContainingValue);
            
            return this;
        }

        // binding method
        public ElementAsserter And()
        {
            return this;
        }
    }
}
