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
            string email = SharedMethods.GetUniqueEmail("testuser@example.com");
            var signUpInfoPage = authPage.SignUpWithBasicInfo(name, email);

            // var signUpInfoPage = authPage.ContinueToAccountInfoPage();
            Assert.That(authPage.IsUserNavigatedToSignUpPage(), Is.True,"User isn't navigated to signup info page");
        }


        [Test]
        [Category("SignUp"), Category("UI")]
        public void SignUpFormElementsDisplayed()
        {
            var authPage = new AuthPage(driver);
            authPage.GoToAuthPage();

            string name = "TestUser";
            string email = SharedMethods.GetUniqueEmail("testuser@example.com"); 

            var signUpInfoPage = authPage.SignUpWithBasicInfo(name, email);

            // var accountInfoPage = authPage.ContinueToAccountInfoPage();

          Assert.Multiple(() =>
            {
            Assert.That(signUpInfoPage.IsMrTitleDisplayed(), Is.True, "Mr radio button isn't displayed");
            Assert.That(signUpInfoPage.IsMrsTitleDisplayed(), Is.True, "Mrs radio button isn't displayed");
            Assert.That(signUpInfoPage.IsNameFieldDisplayed(), Is.True, "Name field isn't displayed");
            Assert.That(signUpInfoPage.IsEmailFieldDisplayed(), Is.True, "Email field isn't displayed");
            Assert.That(signUpInfoPage.IsPasswordFieldDisplayed(), Is.True, "Password field isn't displayed");
            Assert.That(signUpInfoPage.IsDayOfBirthDisplayed(), Is.True, "Day dropdown isn't displayed");
            Assert.That(signUpInfoPage.IsMonthOfBirthDisplayed(), Is.True, "Month dropdown isn't displayed");
            Assert.That(signUpInfoPage.IsYearOfBirthDisplayed(), Is.True, "Year dropdown isn't displayed");
            Assert.That(signUpInfoPage.IsNewsletterCheckboxDisplayed(), Is.True, "Newsletter checkbox isn't displayed");
            Assert.That(signUpInfoPage.IsReceiveOffersCheckboxDisplayed(), Is.True, "Offers checkbox isn't displayed");
            Assert.That(signUpInfoPage.IsFirstNameDisplayed(), Is.True, "First name field isn't displayed");
            Assert.That(signUpInfoPage.IsLastNameDisplayed(), Is.True, "Last name field isn't displayed");
            Assert.That(signUpInfoPage.IsCompanyDisplayed(), Is.True, "Company field isn't displayed");
            Assert.That(signUpInfoPage.IsAddress1Displayed(), Is.True, "Address1 field isn't displayed");
            Assert.That(signUpInfoPage.IsAddress2Displayed(), Is.True, "Address2 field isn't displayed");
            Assert.That(signUpInfoPage.IsCountryDisplayed(), Is.True, "Country dropdown isn't displayed");
            Assert.That(signUpInfoPage.IsStateDisplayed(), Is.True, "State field isn't displayed");
            Assert.That(signUpInfoPage.IsCityDisplayed(), Is.True, "City field isn't displayed");
            Assert.That(signUpInfoPage.IsZipCodeDisplayed(), Is.True, "Zip code field isn't displayed");
            Assert.That(signUpInfoPage.IsMobileNumberDisplayed(), Is.True, "Mobile number field isn't displayed");
            Assert.That(signUpInfoPage.IsCreateAccountBtnDisplayed(), Is.True, "Create account button isn't displayed");
       
          });
          }

          [Test]
        [Category("SignUp"), Category("Positive")]
        public void SuccessfulAccountCreationTest()
        {
            var authPage = new AuthPage(driver);
            authPage.GoToAuthPage();

            string name = "TestUser";
            string email = SharedMethods.GetUniqueEmail("testuser@example.com");
            var signUpInfoPage = authPage.SignUpWithBasicInfo(name, email);

            // var signUpInfoPage = authPage.ContinueToAccountInfoPage();

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
