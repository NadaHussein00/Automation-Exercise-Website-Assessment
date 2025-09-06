using AutomationAssessment.Tests.Utils.Selenium;
using AutomationAssessment.Tests.Pages;

namespace AutomationAssessment.Tests.Tests.Selenium
{
    [AllureEpic("Selenium Tests")]
    [AllureSuite("Login Tests")]
    public class LoginFormTests : BaseTests
    {
        [Test]
        [Category("Selenium"), Category("Login"), Category("Navigation"), Category("Valid")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureSubSuite("Valid Login Tests")]
        [AllureStory("Login With Valid Credentials")]
        public void Login_With_Valid_Credentils()
        {
            var authPage = new AuthPage(Driver);
            authPage.GoToAuthPage();

            string email = "nada@example.com";
            string password = "Password12@";
            authPage.FillEmailLoginField(email);
            authPage.FillPasswordLoginField(password);
            authPage.ClickLoginBtn();

            Assert.Multiple(() =>
            {
                Assert.That(authPage.IsLogoutBtnDisplayed(), Is.True, "Logout button isn't displayed");
                Assert.That(authPage.LogoutBtnText, Does.Contain("Logout"), "Logout text isn't displayed");
            });
            

            authPage.ClickLogoutBtn();
        }

        [Test]
        [Category("Selenium"), Category("Login"), Category("Error Handeling"), Category("Invalid")]
        [TestCaseSource(typeof(CsvReader), nameof(CsvReader.GetLoginData))]
        [AllureSeverity(SeverityLevel.normal)]
        [AllureSubSuite("Invalid Login Tests")]
        [AllureStory("Login With Invalid Credentials")]
        public void Login_With_Invalid_Credentials(string email, string password)
        {
            var authPage = new AuthPage(Driver);
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