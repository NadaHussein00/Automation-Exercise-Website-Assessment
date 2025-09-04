using AutomationAssessment.Tests.Drivers;

namespace AutomationAssessment.Tests.Tests
{
    [AllureNUnit]  
    public class BaseTests
    {
        protected IWebDriver driver;
        private DriverSetup driverSetup;

        [SetUp]
        public void SetUp()
        {
            driverSetup = new DriverSetup();       
            driver = driverSetup.InitDriver();     
        }

        [TearDown]
        public void TearDown()
        {
            driverSetup.QuitDriver(); 
            driver.Dispose();
        }
    }
}
