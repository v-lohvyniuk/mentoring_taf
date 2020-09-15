using mentoring_taf.taf.core.elements;
using mentoring_taf.taf.core.po.facebook;
using System;
using System.Collections.Generic;
using System.Text;

namespace mentoring_taf.taf.sut.asserts
{
    class SearchAsserts
    {

        private FacebookSearchResultsPage SearchResultsPage = new FacebookSearchResultsPage();
        public void AssertSearchResultPresent(String accountId)
        {
            AssertThat
                .Element(SearchResultsPage.SearchResultsContainer)
                .AttributeContains("innerHTML", accountId);
        }
    }
}
