using mentoring_taf.taf.core.driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace mentoring_taf.taf.utils
{
    class NavigationUtils
    {
        private NavigationUtils() { }
        public static void NavigateToUrl(String url)
        {
            DriverProvider.GetDriver().Navigate().GoToUrl(url);
        }

        public static void NavigateToUrl(Urls url)
        {
            DriverProvider.GetDriver().Navigate().GoToUrl(url.GetUrl());
        }

        public static void GoToFacebookLoginPage()
        {
            NavigateToUrl(Urls.FACEBOOK_LOGIN_URL);
        }
    }
}
