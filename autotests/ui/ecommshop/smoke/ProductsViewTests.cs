using mentoring_taf.taf.sut.actions.ecommshop;
using mentoring_taf.taf.sut.asserts.ecommshop;
using mentoring_taf.taf.utils;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace mentoring_taf.autotests.ecommshop.smoke
{
    class ProductsViewTests : UiTestBase
    {
        [Test]
        public void ViewTopSellersProduct_PositiveTestCase()
        {
            LandingAsserts landingAsserts = new LandingAsserts();
            LandingActions landingActions = new LandingActions();
            ProductDetailsAsserts productDetailsAsserts = new ProductDetailsAsserts();
             
            // When
            NavigationUtils.GoToEcommerceShopHomePage();
            // Then
            landingAsserts.AssertTopSellersDisplayedCorrectly();
            // When
            landingActions.ClickOnAnyTopSellersProduct();
            // Then
            productDetailsAsserts.AssertDetailsPageIsOpened();
        }
    }
}
