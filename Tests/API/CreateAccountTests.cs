using AutomationAssessment.Tests.Utils.API;
using AutomationAssessment.Tests.Utils.Selenium;

namespace AutomationAssessment.Tests.Tests.API
{
    [AllureEpic("API Tests")]
    [AllureSuite("API Account Creation Tests")]
    public class CreateAccountTests : ApiTestSetup
    {
        [Test]
        [Category("API"), Category("CreateAccount"), Category("Valid")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureSubSuite("Valid Account Creation Tests")]
        [AllureStory("Account Creation With Valid Information")]
        public async Task CreateAccount_WithValidData_ShouldReturn201()
        {
            string uniqueEmail = SharedMethods.GetUniqueEmail("testuser@example.com");
            var response = await CreateAccount
            (
                name: "TestUser",
                email: uniqueEmail,
                password: "Password12@",
                title: "Mr",
                birthDate: "1",
                birthMonth: "January",
                birthYear: "1990",
                firstName: "Test",
                lastName: "User",
                company: "Company",
                address1: "street1, state1, city1",
                address2: "street2, state2, city2",
                country: "India",
                zipcode: "90001",
                state: "state",
                city: "city",
                mobileNumber: "0123456789"
            );


            var json = JsonSerializer.Deserialize<Dictionary<string, object>>(response.Content!);

            Assert.Multiple(() => {Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK)); 
            Assert.That(json!["responseCode"], Is.EqualTo(201));              
            Assert.That(json!["message"].ToString(), Does.Contain("User created!"));
            });
}
    }
}