namespace AutomationAssessment.Tests.Pages
{
    public class SignUpInfoPage{
        private readonly IWebDriver _driver;

        public SignUpInfoPage(IWebDriver driver)
        {
            _driver = driver;
        }

        private readonly By _mrTitleRadioBtn = By.CssSelector("#id_gender1");
        private readonly By _mrsTitleRadioBtn = By.CssSelector("#id_gender2");
        private readonly By _nameField = By.CssSelector("form #name");
        private readonly By _emailField = By.CssSelector("form #email");
        private readonly By _passwordField = By.CssSelector("form #password");
        private readonly By _dayOfBirth = By.CssSelector("form #days");
        private readonly By _monthOfBirth = By.CssSelector("form #months");
        private readonly By _yearOfBirth = By.CssSelector("form #years");
        private readonly By _newsletterCheckbox = By.CssSelector("form #newsletter");
        private readonly By _receiveOffersCheckbox = By.CssSelector("form #optin");
        private readonly By _firstNameField = By.CssSelector("form input[data-qa='first_name']");
        private readonly By _lastNameField = By.CssSelector("form input[data-qa='last_name']");
        private readonly By _companyField = By.CssSelector("form input[data-qa='company']");
        private readonly By _firstAddressField = By.CssSelector("form #address1");
        private readonly By _secondAddressField = By.CssSelector("form #address2");
        private readonly By _countryDropdown = By.CssSelector("form #country");
        private readonly By _stateField = By.CssSelector("form #state");
        private readonly By _cityField = By.CssSelector("form #city");
        private readonly By _zipCodeField = By.CssSelector("form #zipcode");
        private readonly By _mobileNumberField = By.CssSelector("form #mobile_number");
        private readonly By _createAccountBtn = By.CssSelector("form button[type='submit']");
        private readonly By _accountCreatedMsg = By.CssSelector("h2[data-qa='account-created']");

        public bool IsMrTitleDisplayed() => _driver.FindElement(_mrTitleRadioBtn).Displayed;
        public bool IsMrsTitleDisplayed() => _driver.FindElement(_mrsTitleRadioBtn).Displayed;
        public bool IsNameFieldDisplayed() => _driver.FindElement(_nameField).Displayed;
        public bool IsEmailFieldDisplayed() => _driver.FindElement(_emailField).Displayed;
        public bool IsPasswordFieldDisplayed() => _driver.FindElement(_passwordField).Displayed;
        public bool IsDayOfBirthDisplayed() => _driver.FindElement(_dayOfBirth).Displayed;
        public bool IsMonthOfBirthDisplayed() => _driver.FindElement(_monthOfBirth).Displayed;
        public bool IsYearOfBirthDisplayed() => _driver.FindElement(_yearOfBirth).Displayed;
        public bool IsNewsletterCheckboxDisplayed() => _driver.FindElement(_newsletterCheckbox).Displayed;
        public bool IsReceiveOffersCheckboxDisplayed() => _driver.FindElement(_receiveOffersCheckbox).Displayed;
        public bool IsFirstNameDisplayed() => _driver.FindElement(_firstNameField).Displayed;
        public bool IsLastNameDisplayed() => _driver.FindElement(_lastNameField).Displayed;
        public bool IsCompanyDisplayed() => _driver.FindElement(_companyField).Displayed;
        public bool IsAddress1Displayed() => _driver.FindElement(_firstAddressField).Displayed;
        public bool IsAddress2Displayed() => _driver.FindElement(_secondAddressField).Displayed;
        public bool IsCountryDisplayed() => _driver.FindElement(_countryDropdown).Displayed;
        public bool IsStateDisplayed() => _driver.FindElement(_stateField).Displayed;
        public bool IsCityDisplayed() => _driver.FindElement(_cityField).Displayed;
        public bool IsZipCodeDisplayed() => _driver.FindElement(_zipCodeField).Displayed;
        public bool IsMobileNumberDisplayed() => _driver.FindElement(_mobileNumberField).Displayed;
        public bool IsCreateAccountBtnDisplayed() => _driver.FindElement(_createAccountBtn).Displayed;

        public void SelectTitle(string title)
        {
            if (title.Equals("Mr", StringComparison.OrdinalIgnoreCase))
                _driver.FindElement(_mrTitleRadioBtn).Click();
            else
                _driver.FindElement(_mrsTitleRadioBtn).Click();
        }

        public void FillNameField(string name) => _driver.FindElement(_nameField).SendKeys(name);
        public void FillPasswordField(string password) => _driver.FindElement(_passwordField).SendKeys(password);

        public void SelectDateOfBirth(string day, string month, string year)
        {
            new SelectElement(_driver.FindElement(_dayOfBirth)).SelectByText(day);
            new SelectElement(_driver.FindElement(_monthOfBirth)).SelectByText(month);
            new SelectElement(_driver.FindElement(_yearOfBirth)).SelectByText(year);
        }

        public void CheckNewsletter() => _driver.FindElement(_newsletterCheckbox).Click();

        public void CheckReceiveOffers() => _driver.FindElement(_receiveOffersCheckbox).Click();

        public void FillFirstNameField(string firstName) => _driver.FindElement(_firstNameField).SendKeys(firstName);
        public void FillLastNameField(string lastName) => _driver.FindElement(_lastNameField).SendKeys(lastName);
        public void FillCompanyField(string company) => _driver.FindElement(_companyField).SendKeys(company);
        public void FillAddress1Field(string address1) => _driver.FindElement(_firstAddressField).SendKeys(address1);
        public void FillAddress2Field(string address2) => _driver.FindElement(_secondAddressField).SendKeys(address2);
        public void SelectCountry(string country) => new SelectElement(_driver.FindElement(_countryDropdown)).SelectByText(country);
        public void FillStateField(string state) => _driver.FindElement(_stateField).SendKeys(state);
        public void FillCityField(string city) => _driver.FindElement(_cityField).SendKeys(city);
        public void FillZipCodeField(string zip) => _driver.FindElement(_zipCodeField).SendKeys(zip);
        public void FillMobileNumberField(string mobile) => _driver.FindElement(_mobileNumberField).SendKeys(mobile);

        public void ClickCreateAccountBtn() => _driver.FindElement(_createAccountBtn).Click();

        public bool IsAccountCreated() => _driver.FindElement(_accountCreatedMsg).Displayed;
        public string AccountCreatedText() => _driver.FindElement(_accountCreatedMsg).Text.Trim();

    }
}