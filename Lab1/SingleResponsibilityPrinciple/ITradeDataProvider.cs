using System.Collections.Generic;

namespace SingleResponsibilityPrinciple
{
    public interface ITradeDataProvider
    {
        IEnumerable<string> GetTradeData();
    }
}
