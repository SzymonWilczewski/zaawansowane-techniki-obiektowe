﻿namespace SingleResponsibilityPrinciple
{
    public interface ITradeMapper
    {
        TradeRecord Map(string[] fields);
    }
}
