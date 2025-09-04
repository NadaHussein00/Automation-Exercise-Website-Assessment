using AutomationAssessment.Tests.Utils;

namespace AutomationAssessment.Tests.Pages
{
    public class AuthPage
    {
        private readonly IWebDriver _driver;
        private readonly WebDriverWait _wait;
        private const string AuthPageUrl = "https://automationexercise.com/login";

        public AuthPage(IWebDriver driver)
        {
            _driver = driver;
            _wait=new WebDriverWait(_driver,TimeSpan.FromSeconds(5));
        }

        public void GoToAuthPage()
        {
            _driver.Navigate().GoToUrl(AuthPageUrl);
        }

        private readonly By _nameSignUpField = By.CssSelector(".signup-form form input[placeholder='Name']");
        private readonly By _emailSignUpField = By.CssSelector(".signup-form form input[placeholder='Email Address']");
        private readonly By _signUpBtn = By.CssSelector(".signup-form form button[type='submit']");
        private readonly By _accountInfoTitle = By.CssSelector(".login-form h2 b");

        public void FillNameSignUpField(string name) => _driver.FindElement(_nameSignUpField).SendKeys(name);

        public void FillEmailSignUpField(string email) =>  _driver.FindElement(_emailSignUpField).SendKeys(email);

        public void ClickSignupBtn() => _driver.FindElement(_signUpBtn).Click();

        public SignUpInfoPage SignUpWithBasicInfo(string name, string email)
        {
            FillNameSignUpField(name);
            FillEmailSignUpField(SharedMethods.GetUniqueEmail(email));
            ClickSignupBtn();
            return ContinueToAccountInfoPage();
        }

        public bool IsUserNavigatedToSignUpPage(){
            try
            {
                _wait.Until(ExpectedConditions.UrlContains("/signup"));
                return _driver.Url.Contains("/signup");
            }
            catch (WebDriverTimeoutException)
            {
                return false;
            }
        }

        public SignUpInfoPage ContinueToAccountInfoPage() => new SignUpInfoPage(_driver);

        private readonly By _emailLoginField = By.CssSelector("input[data-qa='login-email']");
        private readonly By _passwordLoginField = By.CssSelector("input[data-qa='login-password']");
        private readonly By _loginBtn = By.CssSelector("button[data-qa='login-button']");
        private readonly By _logoutBtn = By.CssSelector("a[href='/logout']");
        private readonly By _invalidLoginAttemptErrorMsg = By.CssSelector("form[action='/login'] p");
        
        public void FillEmailLoginField(string email) => _driver.FindElement(_emailLoginField).SendKeys(email);

        public void FillPasswordLoginField(string password) => _driver.FindElement(_passwordLoginField).SendKeys(password);

        public void ClickLoginBtn() => _driver.FindElement(_loginBtn).Click();

        public bool IsLogoutBtnDisplayed(){
            try{
                return _driver.FindElement(_logoutBtn).Displayed;
            }
            catch(NoSuchElementException){
                return false;
            }
        }
        public string LogoutBtnText() => _driver.FindElement(_logoutBtn).Text.Trim();
        public void ClickLogoutBtn() => _driver.FindElement(_logoutBtn).Click();

        public bool IsErrorMsgDisplayed(){
            try{
                _wait.Until(ExpectedConditions.ElementIsVisible(_invalidLoginAttemptErrorMsg));
                return true;
            }
            catch(WebDriverTimeoutException){
                return false;
            }
        }
        public string ErrorMsgText(){
            try{
                return _wait.Until(ExpectedConditions.ElementIsVisible(_invalidLoginAttemptErrorMsg)).Text.Trim();
            }
            catch(WebDriverTimeoutException){
                return string.Empty;
            }
        }

    }
}
