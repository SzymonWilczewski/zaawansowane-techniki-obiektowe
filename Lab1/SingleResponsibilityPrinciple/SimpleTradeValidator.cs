namespace SingleResponsibilityPrinciple
{
    public class SimpleTradeValidator : ITradeValidator
    {
        private readonly ILogger logger;

        public SimpleTradeValidator(ILogger logger)
        {
            this.logger = logger;
        }

        public bool Validate(string[] fields, int lineCount)
        {
            if (fields.Length != 3)
            {
                logger.LogWarning("Line {0} malformed. Only {1} field(s) found.", lineCount, fields.Length);
                return false;
            }

            if (fields[0].Length != 6)
            {
                logger.LogWarning("Trade currencies on line {0} malformed: '{1}'", lineCount, fields[0]);
                return false;
            }

            if (!int.TryParse(fields[1], out int tradeAmount))
            {
                logger.LogWarning("Trade amount on line {0} not a valid integer: '{1}'", lineCount, fields[1]);
                return false;
            }

            if (!decimal.TryParse(fields[2], out decimal tradePrice))
            {
                logger.LogWarning("Trade price on line {0} not a valid decimal: '{1}'", lineCount, fields[2]);
                return false;
            }

            return true;
        }
    }
}
