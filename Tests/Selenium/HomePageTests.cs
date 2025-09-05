using AutomationAssessment.Tests.Pages;

namespace AutomationAssessment.Tests.Tests.Selenium
{
    [AllureEpic("Homepage")]
    public class HomePageTests : BaseTests
    {
        [Test]
        [Category("UI")]
        public void Homepage_Title_Is_Displayed()
        {
            var homePage = new HomePage(Driver);

            homePage.GoToHomePage();
            string title = Driver.Title;

            Assert.That(title, Does.Contain("Automation Exercise"),"Title isn't displayed");
            
        }

        [Test]
        [Category("UI")]
        public void Website_Logo_Is_Displayed()
        {
            var homePage = new HomePage(Driver);

            homePage.GoToHomePage();
            Assert.That(homePage.IsLogoDisplayed(), Is.True,"Logo isn't displayed");
            
        }

        [Test]
        [Category("UI")]
        public void Home_Button_Is_Displayed()
        {
            var homePage = new HomePage(Driver);

            homePage.GoToHomePage();
            Assert.That(homePage.IsHomeBtnDisplayed(), Is.True,"Home button isn't displayed");
            
        }

        [Test]
        [Category("UI")]
        public void Home_Button_Is_Clickable()
        {
            var homePage = new HomePage(Driver);

            homePage.GoToHomePage();
            Assert.That(homePage.IsHomeBtnClickable(), Is.True,"Home button isn't clickable");
            
        }

        [Test]
        [Category("UI")]
        public void Home_Button_Text_Is_Displayed()
        {
            var homePage = new HomePage(Driver);

            homePage.GoToHomePage();
            Assert.That(homePage.HomeText(), Is.EqualTo("Home"),"Home text isn't displayed");
            
        }

        [Test]
        [Category("UI")]
        public void Cart_Button_Is_Displayed()
        {
            var homePage = new HomePage(Driver);

            homePage.GoToHomePage();
            Assert.That(homePage.IsCartBtnDisplayed(), Is.True,"Cart button isn't displayed");
            
        }

        [Test]
        [Category("UI")]
        public void Cart_Button_Text_Is_Displayed()
        {
            var homePage = new HomePage(Driver);

            homePage.GoToHomePage();
            Assert.That(homePage.CartText(), Is.EqualTo("Cart"),"Cart text isn't displayed");
            
        }

        [Test]
        [Category("UI")]
        public void Cart_Button_Is_Clickable()
        {
            var homePage = new HomePage(Driver);

            homePage.GoToHomePage();
            Assert.That(homePage.IsCartBtnClickable(), Is.True,"cart button isn't clickable");
            
        }

        
        [Test]
        [Category("UI")]
        public void Signup_Button_Is_Displayed()
        {
            var homePage = new HomePage(Driver);

            homePage.GoToHomePage();
            Assert.That(homePage.IsSignupBtnDisplayed(), Is.True,"Signup button isn't displayed");
            
        }

        [Test]
        [Category("UI")]
        public void Signup_Button_Is_Clickable()
        {
            var homePage = new HomePage(Driver);

            homePage.GoToHomePage();
            Assert.That(homePage.IsSignupBtnClickable(), Is.True,"Signup/Login button isn't clickable");
            
        }

        [Test]
        [Category("UI")]
        public void Signup_Button_Text_Is_Displayed()
        {
            var homePage = new HomePage(Driver);

            homePage.GoToHomePage();
            Assert.That(homePage.SignupText(), Is.EqualTo("Signup / Login"),"Signup / Login text isn't displayed");
            
        }

        
        [Test]
        [Category("UI")]
        public void Contact_Us_Button_Is_Displayed()
        {
            var homePage = new HomePage(Driver);

            homePage.GoToHomePage();
            Assert.That(homePage.IsContactUsBtnDisplayed(), Is.True,"Contact us button isn't displayed");
            
        }

        [Test]
        [Category("UI")]
        public void Contact_Us_Button_Is_Clickable()
        {
            var homePage = new HomePage(Driver);

            homePage.GoToHomePage();
            Assert.That(homePage.IsContactUsBtnClickable(), Is.True,"Contact us button isn't clickable");
            
        }

        [Test]
        [Category("UI")]
        public void Contact_Us_Button_Text_Is_Displayed()
        {
            var homePage = new HomePage(Driver);

            homePage.GoToHomePage();
            Assert.That(homePage.ContactUsText(), Is.EqualTo("Contact us"),"Contact us text isn't displayed");
            
        }

        [Test]
        [Category("UI")]
        public void Women_Category_Button_Is_Displayed()
        {
            var homePage = new HomePage(Driver);

            homePage.GoToHomePage();
            Assert.That(homePage.IsWomenCategoryBtnDisplayed(), Is.True,"Women category button in category list isn't displayed");
            
        }

        [Test]
        [Category("UI")]
        public void Women_Category_Button_Is_Clickable()
        {
            var homePage = new HomePage(Driver);

            homePage.GoToHomePage();
            Assert.That(homePage.IsWomenCategoryBtnClickable(), Is.True,"Women category button in category list isn't clickable");
            
        }

        [Test]
        [Category("UI")]
        public void Women_Category_Button_Text_Is_Displayed()
        {
            var homePage = new HomePage(Driver);

            homePage.GoToHomePage();
            Assert.That(homePage.WomenCategoryText(), Is.EqualTo("WOMEN"),"Women category text in category list isn't displayed");
            
        }
    }
}
