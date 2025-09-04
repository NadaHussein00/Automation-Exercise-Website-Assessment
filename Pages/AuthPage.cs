namespace AutomationAssessment.Tests.Pages
{
    public class AuthPage
    {
        private readonly IWebDriver _driver;
        private const string AuthPageUrl = "https://automationexercise.com/login";

        public AuthPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void GoToAuthPage()
        {
            _driver.Navigate().GoToUrl(AuthPageUrl);
        }
    }
}
