﻿using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace mentoring_taf.taf.utils
{
    class Urls
    {
        public static readonly Urls FACEBOOK_LOGIN_URL = new Urls("https://www.facebook.com/");

        private readonly String url;

        public String GetUrl()
        {
            return this.url;
        }
        private Urls(String url)
        {
            this.url = url;
        }

    }
}
