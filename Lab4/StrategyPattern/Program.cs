using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new Navigator(new RoadStrategy());
            context.Navigate();

            context.SetStrategy(new PublicTransportStrategy());
            context.Navigate();

            context.SetStrategy(new WalkingStrategy());
            context.Navigate();
        }
    }
}
