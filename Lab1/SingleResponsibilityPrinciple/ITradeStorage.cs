using System.Collections.Generic;

namespace SingleResponsibilityPrinciple
{
    public interface ITradeStorage
    {
        void Persist(IEnumerable<TradeRecord> trades);
    }
}
