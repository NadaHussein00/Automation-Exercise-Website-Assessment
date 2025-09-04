namespace AutomationAssessment.Tests.Drivers
{
    public class DriverSetup
    {
        private IWebDriver? _driver; 

        public IWebDriver InitDriver()
        {
            _driver = new ChromeDriver(); 
            _driver.Manage().Window.Maximize(); 
            return _driver; 
        }

        public void QuitDriver()
        {
            if (_driver != null)
            {
                _driver.Quit(); 
                _driver = null; 
            }
        }
    }
}
