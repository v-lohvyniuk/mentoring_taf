using mentoring_taf.taf.actions;
using mentoring_taf.taf.asserts;
using mentoring_taf.taf.sut.models;
using mentoring_taf.taf.utils;
using NUnit.Framework;

namespace mentoring_taf.autotests
{
    public class LoginTests : UiTestBase
    {

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void LoginToFacebookPositiveTestCase()
        {
            User user = new User("hmq49033@eoopy.com", "Qwerty123456", "Volodymyr", "Khomyshak");
            NavigationUtils.GoToFacebookLoginPage();
            new LoginAction().LogIn(user);
            new LoginAsserts().AssertUserIsLoggedIn(user.GetFirstName());
        }
        
        [Test]
        public void LoginToFacebookNegativeTestCase()
        {
            User user = new User("hmq49033@eoopy.com", "dfhakwje", "Volodymyr", "Khomyshak");
            NavigationUtils.GoToFacebookLoginPage();
            new LoginAction().LogIn(user);
            new LoginAsserts().AssertUserIsNotLoggedIn(user.GetFirstName());
        }
    }
}