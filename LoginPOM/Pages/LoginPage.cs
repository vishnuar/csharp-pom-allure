using OpenQA.Selenium;

namespace NoteappPOM.Pages
{
    public class LoginPage : BasePage
    {
        private readonly By _usernameField = By.Id("username");
        private readonly By _passwordField = By.Id("password");
        private readonly By _loginButton = By.Id("loginbtn");
        private const string ExpectedTitle = "MyNotes";
        private const string Logintext = "noteapp";
        private readonly string _loginPageUrl = "https://vishnuar.pythonanywhere.com/login/";

        public LoginPage(IWebDriver driver) : base(driver)
        {
        }
        public bool NavigateToLoginPage()
        {
            Driver.Navigate().GoToUrl(_loginPageUrl);
            string actualTitle = Driver.Title;
            return string.Equals(actualTitle, ExpectedTitle, StringComparison.OrdinalIgnoreCase);

        }
        public void EnterUsername(string username)
        {
            WaitForElement(_usernameField).SendKeys(username);
        }
        public void EnterPassword(string password)
        {
            WaitForElement(_passwordField).SendKeys(password);
        }
        public void ClickLoginButton()
        {
            WaitForElement(_loginButton).Click();
        }
        public bool IsLoggedIn()
        {   
            return Driver.Url.Contains(Logintext);
        }
    }
}
