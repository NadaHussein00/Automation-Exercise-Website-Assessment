namespace AutomationAssessment.Tests.Utils
{
    public static class SharedMethods{
        public static string GetUniqueEmail(string baseEmail)
        {
            long timestamp = DateTime.Now.Ticks;
            return baseEmail.Replace("@", $"_{timestamp}@");
        }
    }
}