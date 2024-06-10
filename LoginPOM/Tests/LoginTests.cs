using NUnit.Framework;
using NoteappPOM.Pages;
using Allure.NUnit.Attributes;
using Allure.NUnit;

namespace NoteappPOM.Tests
{
    [AllureNUnit]
    [AllureSuite("LoginTests")]
    public class LoginTests : BaseTest
    {
        [Test]
        [AllureName("Login Title")]
        [AllureStep("Validating the title of the login page")]
        public void TestLoginTitle()
        {
            LoginPage loginPage = new LoginPage(Driver);
            Assert.That(loginPage.NavigateToLoginPage());
        }
        [Test]
        [AllureName("Valid Login")]
        [AllureStep("Validating valid login scenario")]
        public void TestValidLogin()
        {
            LoginPage loginPage = new LoginPage(Driver);
            loginPage.NavigateToLoginPage();
            loginPage.EnterUsername("sachin");
            loginPage.EnterPassword("123456");
            loginPage.ClickLoginButton();

            Assert.That(loginPage.IsLoggedIn());
        }
    }
}
