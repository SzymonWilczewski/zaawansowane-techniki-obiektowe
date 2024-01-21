using System;

namespace StrategyPattern
{
    public class RoadStrategy : IRouteStrategy
    {
        public void BuildRoute() => Console.WriteLine("Road strategy has been used for travel time estimation.");
    }
}
