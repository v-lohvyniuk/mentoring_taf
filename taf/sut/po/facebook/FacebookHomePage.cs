using mentoring_taf.taf.po.facebook.fragments;
using mentoring_taf.taf.utils;
using OpenQA.Selenium;
using System;

namespace mentoring_taf.taf.core.po.facebook
{
    class FacebookHomePage : BasePage
    {
        private HeaderFragment headerFragment = new HeaderFragment();

        public HeaderFragment GetHeaderFragment()
        {
            return headerFragment;
        }


    }
}
