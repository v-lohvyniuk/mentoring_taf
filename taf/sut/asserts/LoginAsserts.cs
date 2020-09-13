using mentoring_taf.taf.core.elements;
using mentoring_taf.taf.core.po.facebook;
using System;

namespace mentoring_taf.taf.asserts
{
    public class LoginAsserts
    {
        private FacebookHomePage homePage = new FacebookHomePage();

        public void AssertUserIsLoggedIn(String firstName)
        {
            AssertThat
                .Element(homePage.GetHeaderFragment().GetMyProfileButton())
                .IsVisible()
                .And()
                .TextContainsIgnoringCase(firstName);
        }
        
        public void AssertUserIsNotLoggedIn(String firstName)
        {
            AssertThat
                .Element(homePage.GetHeaderFragment().GetMyProfileButton())
                .HasVisibility(false);
        }
    }
}
