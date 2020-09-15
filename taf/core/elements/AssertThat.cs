using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace mentoring_taf.taf.core.elements
{
    public class AssertThat
    {  
        public static ElementAsserter Element(IWebElement element)
        {
            return new ElementAsserter(element);
        }

        public static ElementCollectionAsserter Elements(IList<IWebElement> elements)
        {
            return new ElementCollectionAsserter(elements);
        }
    }
}
