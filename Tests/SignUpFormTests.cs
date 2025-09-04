using AutomationAssessment.Tests.Utils;
using AutomationAssessment.Tests.Pages;

namespace AutomationAssessment.Tests.Tests
{
    public class SignUpFormTests : BaseTests
    {
        [Test]
        [Category("SignUp"), Category("Navigation")]
        public void NavigationToSignUpPage()
        {
            var authPage = new AuthPage(driver);
            authPage.GoToAuthPage();

            string name = "TestUser";
            string email = CsvReader.GetUniqueEmail("testuser@example.com");
            authPage.FillSignUpForm(name, email);
            authPage.ClickSignupBtn();

            var signUpInfoPage = authPage.ContinueToAccountInfoPage();
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(d => d.Url.Contains("/signup"));

            Assert.That(driver.Url.Contains("/signup"), "User isn't navigated to signup info page");
        }


        [Test]
        [Category("SignUp"), Category("UI")]
        public void SignUpFormElementsDisplayed()
        {
            var authPage = new AuthPage(driver);
            authPage.GoToAuthPage();

            string name = "TestUser";
            string email = CsvReader.GetUniqueEmail("testuser@example.com"); 

            authPage.FillSignUpForm(name, email);
            authPage.ClickSignupBtn();

            var accountInfoPage = authPage.ContinueToAccountInfoPage();

          Assert.Multiple(() =>
            {
            Assert.That(accountInfoPage.IsMrTitleVisible(), Is.True, "Mr radio button isn't visible");
            Assert.That(accountInfoPage.IsMrsTitleVisible(), Is.True, "Mrs radio button isn't visible");
            Assert.That(accountInfoPage.IsNameFieldVisible(), Is.True, "Name field isn't visible");
            Assert.That(accountInfoPage.IsEmailFieldVisible(), Is.True, "Email field isn't visible");
            Assert.That(accountInfoPage.IsPasswordFieldVisible(), Is.True, "Password field isn't visible");
            Assert.That(accountInfoPage.IsDayOfBirthVisible(), Is.True, "Day dropdown isn't visible");
            Assert.That(accountInfoPage.IsMonthOfBirthVisible(), Is.True, "Month dropdown isn't visible");
            Assert.That(accountInfoPage.IsYearOfBirthVisible(), Is.True, "Year dropdown isn't visible");
            Assert.That(accountInfoPage.IsNewsletterCheckboxVisible(), Is.True, "Newsletter checkbox isn't visible");
            Assert.That(accountInfoPage.IsReceiveOffersCheckboxVisible(), Is.True, "Offers checkbox isn't visible");
            Assert.That(accountInfoPage.IsFirstNameVisible(), Is.True, "First name field isn't visible");
            Assert.That(accountInfoPage.IsLastNameVisible(), Is.True, "Last name field isn't visible");
            Assert.That(accountInfoPage.IsCompanyVisible(), Is.True, "Company field isn't visible");
            Assert.That(accountInfoPage.IsAddress1Visible(), Is.True, "Address1 field isn't visible");
            Assert.That(accountInfoPage.IsAddress2Visible(), Is.True, "Address2 field isn't visible");
            Assert.That(accountInfoPage.IsCountryVisible(), Is.True, "Country dropdown isn't visible");
            Assert.That(accountInfoPage.IsStateVisible(), Is.True, "State field isn't visible");
            Assert.That(accountInfoPage.IsCityVisible(), Is.True, "City field isn't visible");
            Assert.That(accountInfoPage.IsZipCodeVisible(), Is.True, "Zip code field isn't visible");
            Assert.That(accountInfoPage.IsMobileNumberVisible(), Is.True, "Mobile number field isn't visible");
            Assert.That(accountInfoPage.IsCreateAccountBtnVisible(), Is.True, "Create account button isn't visible");
       
          });
          }

          [Test]
        [Category("SignUp"), Category("Positive")]
        public void SuccessfulAccountCreationTest()
        {
            var authPage = new AuthPage(driver);
            authPage.GoToAuthPage();

            string name = "TestUser";
            string email = CsvReader.GetUniqueEmail("testuser@example.com");
            authPage.FillSignUpForm(name, email);
            authPage.ClickSignupBtn();

            var signUpInfoPage = authPage.ContinueToAccountInfoPage();

            signUpInfoPage.SelectTitle("Mr");
            signUpInfoPage.FillNameField("TestUser");
            signUpInfoPage.FillPasswordField("Password12@");
            signUpInfoPage.SelectDateOfBirth("1", "January", "1990");
            signUpInfoPage.CheckNewsletter();
            signUpInfoPage.CheckReceiveOffers();
            signUpInfoPage.FillFirstNameField("Test");
            signUpInfoPage.FillLastNameField("User");
            signUpInfoPage.FillCompanyField("Company");
            signUpInfoPage.FillAddress1Field("street, state, city");
            signUpInfoPage.SelectCountry("United States");
            signUpInfoPage.FillStateField("state");
            signUpInfoPage.FillCityField("city");
            signUpInfoPage.FillZipCodeField("90001");
            signUpInfoPage.FillMobileNumberField("0123456789");
            signUpInfoPage.ClickCreateAccountBtn();

            Assert.That(signUpInfoPage.IsAccountCreated(), Is.True, "Account was not created successfully");
            Assert.That(signUpInfoPage.AccountCreatedText, Does.Contain("ACCOUNT CREATED!"),"Success message isn't (account created!)");
        }
    }
    }
