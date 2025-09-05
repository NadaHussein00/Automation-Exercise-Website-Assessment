namespace AutomationAssessment.Tests.Utils.Selenium
{
    public class CsvReader
    {
        public static IEnumerable<TestCaseData> GetLoginData()
        {
            var testCases = new List<TestCaseData>();
            var loginLines = File.ReadAllLines("TestData/loginData.csv"); 
            for (int i = 1; i < loginLines.Length; i++) 
            {
                var values = loginLines[i].Split(','); 
                testCases.Add(new TestCaseData(values[0], values[1]));
                var testCase = new TestCaseData(values[0], values[1])
                    .SetName($"Invalid Login Attempts With Email:{values[0]} and Password:{values[1]}");
            }
            return testCases;
        }

        public static IEnumerable<TestCaseData> GetSignUpData()
        {
            var testCases = new List<TestCaseData>();
            var signUpLines = File.ReadAllLines("TestData/signUpData.csv"); 
            for (int i = 1; i < signUpLines.Length; i++) 
            {
                var values = signUpLines[i].Split(','); 
                testCases.Add(new TestCaseData(values[0], values[1]));
            }
            return testCases;
        }
        
    }
}
