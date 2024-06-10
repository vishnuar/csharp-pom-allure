using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using Allure.Net.Commons;

namespace NoteappPOM.Tests
{
    public class BaseTest
    {
        protected IWebDriver Driver;

        [SetUp]
        public void SetUp()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            Driver = new ChromeDriver(); // Or initialize your preferred WebDriver
        }

        [TearDown]
        public void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome.Status == NUnit.Framework.Interfaces.TestStatus.Failed)
            {
                var screenshot = ((ITakesScreenshot)Driver).GetScreenshot();
                string screenshotPath = Path.Combine(TestContext.CurrentContext.WorkDirectory, $"{TestContext.CurrentContext.Test.Name}.png");

                // Save the screenshot using correct method
                screenshot.SaveAsFile(screenshotPath);
                AllureApi.AddAttachment("Screenshot", "image/png", screenshotPath);
            }
            Driver.Quit();
        }
    }
}
