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

        private readonly By _nameSignUpField = By.CssSelector(".signup-form form input[placeholder='Name']");
        private readonly By _emailSignUpField = By.CssSelector(".signup-form form input[placeholder='Email Address']");
        private readonly By _signUpBtn = By.CssSelector(".signup-form form button[type='submit']");
        private readonly By _accountInfoTitle = By.CssSelector(".login-form h2 b");

        public void FillSignUpForm(string name, string email)
        {
            _driver.FindElement(_nameSignUpField).SendKeys(name);
            _driver.FindElement(_emailSignUpField).SendKeys(email);
        }

        public void ClickSignupBtn() => _driver.FindElement(_signUpBtn).Click();

        public bool IsUserNavigatedToSignUpPage(){
            try{
                return _driver.FindElement(_accountInfoTitle).Displayed;
            }
            catch(NoSuchElementException){
                return false;
            }
        }

        public SignUpInfoPage ContinueToAccountInfoPage() => new SignUpInfoPage(_driver);

    }
}
