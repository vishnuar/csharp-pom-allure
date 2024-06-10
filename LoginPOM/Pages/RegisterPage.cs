using OpenQA.Selenium;

namespace NoteappPOM.Pages
{
    public class RegisterPage : BasePage
    {

        private readonly By _firstname = By.Id("first_name");
        private readonly By _lastname = By.Id("last_name");
        private readonly By _username = By.Id("username");
        private readonly By _emailid= By.Id("email");
        private readonly By _password = By.Id("pwd");
        private readonly By _cnfpassword = By.Id("confirm_pwd");
        private readonly By _submitbtn = By.Id("register");
        private const string ExpectedTitle = "MyNotes";
        private const string regstertxt = "noteapp";
        private readonly string _registerurl = "https://vishnuar.pythonanywhere.com/register/";
        private readonly By _regmessage = By.CssSelector(".alert.alert-success");

        public RegisterPage(IWebDriver driver) : base(driver)
        {
        }
        public bool NavigateToRegisterPage()
        {
            Driver.Navigate().GoToUrl(_registerurl);
            string actualTitle = Driver.Title;
            return string.Equals(actualTitle, ExpectedTitle, StringComparison.OrdinalIgnoreCase);
        }
        public void EnterFirstname(string firstname)
        {
            WaitForElement(_firstname).SendKeys(firstname);
        }
        public void EnterLastname(string lastname)
        {
            WaitForElement(_lastname).SendKeys(lastname);
        }
        public void EnterUsername(string username)
        {
            WaitForElement(_username).SendKeys(username);
        }
        public void EnterEmail(string email)
        {
            WaitForElement(_emailid).SendKeys(email);
        }
        public void EnterPassword(string password)
        {
            WaitForElement(_password).SendKeys(password);
        }
        public void EnterConfirmPassword(string confirm_password)
        {
            WaitForElement(_cnfpassword).SendKeys(confirm_password);
        }
        public void ClickRegisterButton()
        {
            WaitForElement(_submitbtn).Click();
        }
        public bool VerifySuccessMessage(string expectedMessage)
        {
            string actualMessage = WaitForElement(_regmessage).Text;
            return string.Equals(actualMessage, expectedMessage, StringComparison.OrdinalIgnoreCase);
        }

    }
}
