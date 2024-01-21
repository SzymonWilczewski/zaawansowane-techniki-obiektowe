using System;
using System.Globalization;

namespace LiskovSubstitutionPrinciple2
{
    public class WorldWideShippingStrategy : ShippingStrategy
    {
        // LSP violation
        public new decimal FlatRate { get; set; }

        public override decimal CalculateShippingCost(Weight packageWeightInKilograms, Size packageDimensionInInches, RegionInfo destination)
        {
            decimal shippingCost;

            // LSP violation
            if (destination == null)
            {
                throw new ArgumentNullException(nameof(destination), "Destination can not be null or empty");
            }

            shippingCost = 10.0m;

            // Postconditions LSP violation
            if (destination == RegionInfo.CurrentRegion)
            {
                shippingCost = decimal.Zero;
            }

            return shippingCost;
        }
    }
}
