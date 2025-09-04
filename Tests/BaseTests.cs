using AutomationAssessment.Tests.Drivers;

namespace AutomationAssessment.Tests.Tests
{
    public class BaseTests
    {
        protected IWebDriver driver;
        // protected WebDriverWait Wait = default!;
        private DriverSetup driverSetup;

        [SetUp]
        public void SetUp()
        {
            driverSetup = new DriverSetup();       // Create a DriverFactory
            driver = driverSetup.InitDriver();       // Start Chrome browser
            // driver.Navigate().GoToUrl("https://automationexercise.com/"); // Go to homepage
        }

        [TearDown]
        public void TearDown()
        {
            driverSetup.QuitDriver(); 
            driver.Dispose();
        }
    }
}
