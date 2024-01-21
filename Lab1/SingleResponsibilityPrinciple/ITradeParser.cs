using System.Collections.Generic;

namespace SingleResponsibilityPrinciple
{
    public interface ITradeParser
    {
        IEnumerable<TradeRecord> Parse(IEnumerable<string> lines);
    }
}
