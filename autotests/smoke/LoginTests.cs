using mentoring_taf.taf.actions;
using mentoring_taf.taf.asserts;
using mentoring_taf.taf.core.pool;
using mentoring_taf.taf.core.readers;
using mentoring_taf.taf.sut.models;
using mentoring_taf.taf.utils;
using NUnit.Framework;

namespace mentoring_taf.autotests
{
    public class LoginTests : UiTestBase
    {

        [Test]
        public void LoginToFacebookPositiveTestCase()
        {
            User user = UserPool.getOne();
            NavigationUtils.GoToFacebookLoginPage();
            new LoginAction().LogIn(user);
            new LoginAsserts().AssertUserIsLoggedIn(user.UserId);
        }
        
        [Test]
        public void LoginToFacebookNegativeTestCase()
        {
            User user = UserPool.getOne();
            user.Password = "Invalid pass";
            NavigationUtils.GoToFacebookLoginPage();
            new LoginAction().LogIn(user);
            new LoginAsserts().AssertUserIsNotLoggedIn(user.FirstName);
        }
    }
}