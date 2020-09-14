using mentoring_taf.taf.core.po.facebook;
using mentoring_taf.taf.utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace mentoring_taf.taf.sut.actions
{
    class SearchAction
    {
        private FacebookHomePage homePage = new FacebookHomePage();
        
        private FacebookSearchResultsPage searchResultPage = new FacebookSearchResultsPage();

        public void Search(String query)
        {
            homePage.GetHeaderFragment().searchInput.SendKeys(query);
            homePage.GetHeaderFragment().searchInput.Submit();
        }
    }
}
