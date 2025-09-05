using AutomationAssessment.Tests.Drivers;

namespace AutomationAssessment.Tests.Tests.Selenium
{
    [AllureNUnit]  
    public class BaseTests
    {
        private IWebDriver _driver;
        private DriverSetup driverSetup;
        protected IWebDriver Driver => _driver;

        [SetUp]
        public void SetUp()
        {
            driverSetup = new DriverSetup();       
            _driver = driverSetup.InitDriver();     
        }

        [TearDown]
        public void TearDown()
        {
            driverSetup.QuitDriver(); 
            _driver.Dispose();
        }
    }
}
