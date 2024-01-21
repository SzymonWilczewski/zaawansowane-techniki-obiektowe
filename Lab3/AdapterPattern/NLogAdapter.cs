namespace AdapterPattern
{
    public class NLogAdapter : ILogger
    {
        private readonly NLog.Logger logger;
        public NLogAdapter(NLog.Logger logger) => this.logger = logger;

        public void LogTrace(string message) => this.logger.Trace(message);
        public void LogDebug(string message) => this.logger.Debug(message);
        public void LogInformation(string message) => this.logger.Info(message);
        public void LogWarning(string message) => this.logger.Warn(message);
        public void LogError(string message) => this.logger.Error(message);
        public void LogCritical(string message) => this.logger.Fatal(message);
    }
}
