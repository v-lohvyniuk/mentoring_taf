using mentoring_taf.taf.sut.po.ecommshop;

namespace mentoring_taf.taf.sut.actions.ecommshop
{
    class LandingActions
    {

        private ShopHomePage HomePage = new ShopHomePage();

        public void ClickOnAnyTopSellersProduct()
        {
            HomePage.PopularProductCards[0].Click();
        }
    }
}
