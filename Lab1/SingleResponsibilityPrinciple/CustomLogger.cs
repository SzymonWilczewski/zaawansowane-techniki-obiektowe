using System;

namespace SingleResponsibilityPrinciple
{
    public class CustomLogger : ILogger
    {
        public void LogError(string message, params object[] args) => Console.WriteLine("ERROR: " + message, args);
        public void LogInfo(string message, params object[] args) => Console.WriteLine("INFO: " + message, args);
        public void LogWarning(string message, params object[] args) => Console.WriteLine("WARN: " + message, args);
    }
}
