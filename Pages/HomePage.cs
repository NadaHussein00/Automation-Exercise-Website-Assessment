namespace AutomationAssessment.Tests.Pages
{
    public class HomePage
    {
        private readonly IWebDriver _driver;
        private const string HomePageUrl = "https://automationexercise.com/";

        public HomePage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void GoToHomePage()
        {
            _driver.Navigate().GoToUrl(HomePageUrl);
        }

        // Example element
        private readonly By _logoImage = By.CssSelector("img[alt='Website for automation practice']");
        private readonly By _homeBtn = By.CssSelector("#header ul li:first-child a");  
        private readonly By _cartBtn = By.CssSelector("#header ul li:nth-child(3) a");
        private readonly By _signupBtn = By.CssSelector("#header ul li:nth-child(4) a");

        public bool IsLogoDisplayed() => _driver.FindElement(_logoImage).Displayed;
        public bool IsHomeBtnDisplayed() => _driver.FindElement(_homeBtn).Displayed;
        public string HomeText() => _driver.FindElement(_homeBtn).Text.Trim();
        public bool IsCartBtnDisplayed() => _driver.FindElement(_cartBtn).Displayed;
        public string CartText() => _driver.FindElement(_cartBtn).Text.Trim();
        public bool IsSignupBtnDisplayed() => _driver.FindElement(_signupBtn).Displayed;
        public string SignupText() => _driver.FindElement(_signupBtn).Text.Trim();
    
    }
}
