// Split the following class so that it meets the priciple of single responsibility principle based on:
// https://pierresimondelaplace.gitlab.io/wsb-zaawansowane-techniki-obiektowe/WSB_ZaawansowaneTechnikiObiektowe.pdf

namespace SingleResponsibilityPrinciple
{
    public class TradeProcessor
    {
        private readonly ITradeDataProvider tradeDataProvider;
        private readonly ITradeParser tradeParser;
        private readonly ITradeStorage tradeStorage;

        public TradeProcessor(ITradeDataProvider tradeDataProvider, ITradeParser tradeParser, ITradeStorage tradeStorage)
        {
            this.tradeDataProvider = tradeDataProvider;
            this.tradeParser = tradeParser;
            this.tradeStorage = tradeStorage;
        }

        public void ProcessTrades()
        {
            var lines = tradeDataProvider.GetTradeData();
            var trades = tradeParser.Parse(lines);
            tradeStorage.Persist(trades);
        }
    }
}
