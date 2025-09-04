namespace AutomationAssessment.Tests.Utils
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
            }
            return testCases;
        }

        public static string GetUniqueEmail(string baseEmail)
        {
            long timestamp = DateTime.Now.Ticks;
            return baseEmail.Replace("@", $"_{timestamp}@");
        }
    }
}
