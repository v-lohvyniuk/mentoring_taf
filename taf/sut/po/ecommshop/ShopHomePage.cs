using mentoring_taf.taf.core.po.facebook;
using SeleniumExtras.PageObjects;
using System.Collections.Generic;

namespace mentoring_taf.taf.sut.po.ecommshop
{
    class ShopHomePage : BasePage
    {
        public ShopHomePage ()
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='homefeatured']//div[@class='product-container']")]
        public IList<OpenQA.Selenium.IWebElement> PopularProductCards { get; set; }



    }
}
