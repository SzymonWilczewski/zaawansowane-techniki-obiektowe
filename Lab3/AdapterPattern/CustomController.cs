namespace AdapterPattern
{
    public class CustomController
    {
        private readonly ILogger logger;
        public CustomController(ILogger logger) => this.logger = logger;
        public void Get() => logger.LogInformation("API request");
    }
}
