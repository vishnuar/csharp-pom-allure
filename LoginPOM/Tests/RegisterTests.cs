using NUnit.Framework;
using NoteappPOM.Pages;
using Allure.NUnit.Attributes;
using Allure.NUnit;

namespace NoteappPOM.Tests
{
    [AllureNUnit]
    [AllureSuite("RegisterTests")]
    public class RegisterTests : BaseTest
    {
        [Test]
        [AllureName("Register Title")]
        [AllureStep("Validating the title of the user registration page")]
        public void TestRegisterTitle()
        {
            RegisterPage regPage = new RegisterPage(Driver);
            Assert.That(regPage.NavigateToRegisterPage());
        }
        [Test]
        [AllureName("User Registration")]
        [AllureStep("Validating the user registration")]
        public void TestValdRegistration()
        {
            RegisterPage regPage = new RegisterPage(Driver);
            regPage.NavigateToRegisterPage();
            regPage.EnterFirstname("first1101012");
            regPage.EnterLastname("last1101012");
            regPage.EnterUsername("user1101012");
            regPage.EnterEmail("user1101012@email.com");
            regPage.EnterPassword("123456");
            regPage.EnterConfirmPassword("123456");
            regPage.ClickRegisterButton();

            Assert.That(regPage.VerifySuccessMessage("Registration successful! Please login."));
        }
    }
}
