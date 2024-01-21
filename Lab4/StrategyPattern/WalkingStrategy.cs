using System;

namespace StrategyPattern
{
    public class WalkingStrategy : IRouteStrategy
    {
        public void BuildRoute() => Console.WriteLine("Walking strategy has been used for travel time estimation.");
    }
}
