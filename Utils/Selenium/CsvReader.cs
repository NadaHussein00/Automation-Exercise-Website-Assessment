namespace AutomationAssessment.Tests.Utils.Selenium
{
    public class CsvReader
    {
        public static IEnumerable<TestCaseData> GetLoginData()
        {
            var testCases = new List<TestCaseData>();
            var loginLines = File.ReadAllLines("TestData/invalidLoginData.csv");
            for (int i = 1; i < loginLines.Length; i++)
            {
                var values = loginLines[i].Split(',');
                var testCase = new TestCaseData(values[0], values[1]);
                testCase.SetName($"Invalid Login Attempts With Email:{values[0]} and Password:{values[1]}");
                testCases.Add(testCase);
            }
            return testCases;
        }
        
    }
}
