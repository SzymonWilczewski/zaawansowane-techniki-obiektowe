namespace SingleResponsibilityPrinciple
{
    public interface ITradeValidator
    {
        bool Validate(string[] fields, int lineCount);
    }
}
