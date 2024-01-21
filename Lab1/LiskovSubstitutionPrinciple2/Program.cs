using System.Globalization;

namespace LiskovSubstitutionPrinciple2
{
    public class Program
    {
        public static void Main()
        {
            //ShippingStrategy shippingStrategyCustom = new ShippingStrategy();
            //ShippingStrategy shippingStrategyWorldWide = new WorldWideShippingStrategy();

            //var retA = shippingStrategyCustom.CalculateShippingCost(new Weight(10), new Size(10, 10), null);
            //var retB = shippingStrategyWorldWide.CalculateShippingCost(new Weight(10), new Size(10, 10), null);

            ShippingStrategy shippingStrategyWorldWide = new WorldWideShippingStrategy();

            var retC = shippingStrategyWorldWide.CalculateShippingCost(new Weight(10), new Size(10, 10), RegionInfo.CurrentRegion);
            (shippingStrategyWorldWide as WorldWideShippingStrategy).FlatRate = -20;
        }
    }
}
