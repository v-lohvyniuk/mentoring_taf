using mentoring_taf.taf.core.elements;
using mentoring_taf.taf.sut.po.ecommshop;
using System;
using System.Collections.Generic;
using System.Text;

namespace mentoring_taf.taf.sut.asserts.ecommshop
{
    class LandingAsserts
    {
        private ShopHomePage HomePage = new ShopHomePage();

        public void AssertTopSellersDisplayedCorrectly()
        {
            AssertThat
                .Elements(HomePage.PopularProductCards)
                .HaveSize(7)
                .AllAreVisible();
        }
    }
}
