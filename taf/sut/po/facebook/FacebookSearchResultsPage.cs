using mentoring_taf.taf.po.facebook.fragments;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace mentoring_taf.taf.core.po.facebook
{
    class FacebookSearchResultsPage : BasePage
    {
        private HeaderFragment headerFragment = new HeaderFragment();

        [FindsBy(How = How.XPath, Using = "//*[@id='BrowseResultsContainer']")]
        public IWebElement SearchResultsContainer { get; set; }

        public HeaderFragment GetHeaderFragment()
        {
            return headerFragment;
        }


    }
}
