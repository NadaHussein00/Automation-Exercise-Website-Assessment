namespace AutomationAssessment.Tests.Utils.API
{
    [AllureNUnit]  
    public class ApiTestSetup
    {
        private RestClient _client;
        private const string BaseUrl = "https://automationexercise.com/api/";

        public ApiTestSetup()
        {
            _client = new RestClient(BaseUrl);
        }


        public async Task<RestResponse> CreateAccount(string name, string email, string password, string title,
                                      string birthDate, string birthMonth, string birthYear,
                                      string firstName, string lastName, string company,
                                      string address1, string address2, string country,
                                      string zipcode, string state, string city, string mobileNumber)
    {
        var request = new RestRequest("createAccount", RestSharp.Method.Post);
        request.AddJsonBody(new
        {
            name,
            email,
            password,
            title,
            birth_date = birthDate,
            birth_month = birthMonth,
            birth_year = birthYear,
            firstname = firstName,
            lastname = lastName,
            company,
            address1,
            address2,
            country,
            zipcode,
            state,
            city,
            mobile_number = mobileNumber
        });

        var response = await _client.ExecuteAsync(request);
        return response;
    }
    }
}
