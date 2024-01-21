namespace StrategyPattern
{
    public class Navigator
    {
        public IRouteStrategy routeStrategy;

        public Navigator(IRouteStrategy strategy)
        {
            this.routeStrategy = strategy;
        }

        public void SetStrategy(IRouteStrategy strategy)
        {
            this.routeStrategy = strategy;
        }

        public void Navigate() => this.routeStrategy.BuildRoute();
    }
}
