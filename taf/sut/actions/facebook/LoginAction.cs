using mentoring_taf.taf.core.po.facebook;
using mentoring_taf.taf.sut.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace mentoring_taf.taf.actions
{
    public class LoginAction
    {
        private FacebookLoginPage loginPage = new FacebookLoginPage();

        public void LogIn(User user)
        {
            loginPage.FillEmail(user.Login);
            loginPage.FillPassword(user.Password);
            loginPage.SubmitLoginForm();
        }
    }
}
