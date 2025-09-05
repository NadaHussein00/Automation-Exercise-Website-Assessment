namespace AutomationAssessment.Tests.Utils.Selenium
{
    public class SharedMethods{
        public static string GetUniqueEmail(string baseEmail)
        {
            long timestamp = DateTime.Now.Ticks;
            return baseEmail.Replace("@", $"_{timestamp}@");
        }
    }
}