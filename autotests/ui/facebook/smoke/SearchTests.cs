using mentoring_taf.taf.actions;
using mentoring_taf.taf.core.pool;
using mentoring_taf.taf.core.readers;
using mentoring_taf.taf.sut.actions;
using mentoring_taf.taf.sut.asserts;
using mentoring_taf.taf.sut.models;
using mentoring_taf.taf.utils;
using NUnit.Framework;

namespace mentoring_taf.autotests
{
    public class SearchTests : UiTestBase
    {

        [Test]
        public void SearchAccountByUserName_PositiveTestCase()
        {
            User user = UserPool.getOne();
            NavigationUtils.GoToFacebookLoginPage();
            new LoginAction().LogIn(user);
            new SearchAction().Search("volodymyr lohvyniuk");
            new SearchAsserts().AssertSearchResultPresent("volodymyr.lohvyniuk");
        }
    }
}