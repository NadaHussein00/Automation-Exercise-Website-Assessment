using AutomationAssessment.Tests.Pages;

namespace AutomationAssessment.Tests.Tests
{
    public class HomePageTests : BaseTests
    {
        [Test]
        [Category("UI")]
        public void Homepage_Title_Is_Displayed()
        {
            var homePage = new HomePage(driver);

            homePage.GoToHomePage();
            string title = driver.Title;

            Assert.That(title, Does.Contain("Automation Exercise"),"Title isn't displayed");
            
        }

        [Test]
        [Category("UI")]
        public void Website_Logo_Is_Displayed()
        {
            var homePage = new HomePage(driver);

            homePage.GoToHomePage();
            Assert.That(homePage.IsLogoDisplayed(), Is.True,"Logo isn't displayed");
            
        }

        [Test]
        [Category("UI")]
        public void Home_Button_Is_Displayed()
        {
            var homePage = new HomePage(driver);

            homePage.GoToHomePage();
            Assert.That(homePage.IsHomeBtnDisplayed(), Is.True,"Home button isn't displayed");
            
        }

        [Test]
        [Category("UI")]
        public void Home_Button_Text_Is_Displayed()
        {
            var homePage = new HomePage(driver);

            homePage.GoToHomePage();
            Assert.That(homePage.HomeText(), Is.EqualTo("Home"),"Home text isn't displayed");
            
        }

        [Test]
        [Category("UI")]
        public void Cart_Button_Is_Displayed()
        {
            var homePage = new HomePage(driver);

            homePage.GoToHomePage();
            Assert.That(homePage.IsCartBtnDisplayed(), Is.True,"Cart button isn't displayed");
            
        }

        [Test]
        [Category("UI")]
        public void Cart_Button_Text_Is_Displayed()
        {
            var homePage = new HomePage(driver);

            homePage.GoToHomePage();
            Assert.That(homePage.CartText(), Is.EqualTo("Cart"),"Cart text isn't displayed");
            
        }

        
        [Test]
        [Category("UI")]
        public void Signup_Button_Is_Displayed()
        {
            var homePage = new HomePage(driver);

            homePage.GoToHomePage();
            Assert.That(homePage.IsSignupBtnDisplayed(), Is.True,"Signup button isn't displayed");
            
        }

        [Test]
        [Category("UI")]
        public void Signup_Button_Text_Is_Displayed()
        {
            var homePage = new HomePage(driver);

            homePage.GoToHomePage();
            Assert.That(homePage.SignupText(), Is.EqualTo("Signup / Login"),"Signup / Login text isn't displayed");
            
        }
    }
}
