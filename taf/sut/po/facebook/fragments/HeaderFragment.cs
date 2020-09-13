using mentoring_taf.taf.core.po.facebook;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace mentoring_taf.taf.po.facebook.fragments
{
    public class HeaderFragment : BasePage
    {
        public HeaderFragment()
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//a[contains(@title, 'Profile')]")]
        private IWebElement myProfileButton;

        public IWebElement GetMyProfileButton()
        {
            return myProfileButton;
        }
    }
}
