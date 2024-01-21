﻿namespace SingleResponsibilityPrinciple
{
    public interface ILogger
    {
        void LogWarning(string message, params object[] args);
        void LogInfo(string message, params object[] args);
        void LogError(string message, params object[] args);
    }
}
