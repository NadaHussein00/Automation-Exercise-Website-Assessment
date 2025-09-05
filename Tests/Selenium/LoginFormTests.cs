using AutomationAssessment.Tests.Utils.Selenium;
using AutomationAssessment.Tests.Pages;

namespace AutomationAssessment.Tests.Tests.Selenium
{
    [AllureEpic("Login")]
    public class LoginFormTests : BaseTests
    {
        [Test]
        [Category("Login"), Category("Navigation"), Category("Positive")]
        public void LoginWithValidCredentils()
        {
            var authPage = new AuthPage(driver);
            authPage.GoToAuthPage();

            string email = "nada@example.com";
            string password = "Password12@";
            authPage.FillEmailLoginField(email);
            authPage.FillPasswordLoginField(password);
            authPage.ClickLoginBtn();

            Assert.That(authPage.IsLogoutBtnDisplayed(), Is.True, "Logout button isn't displayed");
            Assert.That(authPage.LogoutBtnText, Does.Contain("Logout"),"Logout text isn't displayed");

            authPage.ClickLogoutBtn();
        }

        [Test]
        [Category("Login"), Category("Error Handeling"), Category("Negative")]
        [TestCaseSource(typeof(CsvReader), nameof(CsvReader.GetLoginData))]
        public void LoginWithInvalidCredentials(string email, string password)
        {
            var authPage = new AuthPage(driver);
            authPage.GoToAuthPage();

            if (authPage.IsLogoutBtnDisplayed())
            {
                authPage.ClickLogoutBtn();
                authPage.GoToAuthPage(); 
            }

            authPage.FillEmailLoginField(email);
            authPage.FillPasswordLoginField(password);
            authPage.ClickLoginBtn();

            Assert.That(authPage.IsErrorMsgDisplayed(), Is.True, $"Error message not displayed for this attempt email: '{email}' and password: '{password}'");
        }
    }
}