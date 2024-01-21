using System;
using System.Globalization;

namespace LiskovSubstitutionPrinciple1
{
    public class ShippingStrategy
    {
        private decimal flatRate;
        public decimal FlatRate
        {
            get { return flatRate; }
            set
            {
                if (value <= decimal.Zero)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Flat rate must be positive and non zero");
                }
                flatRate = value;
            }
        }

        public decimal CalculateShippingCost(Weight packageWeightInKilograms, Size packageDimensionInInches, RegionInfo destination)
        {
            decimal shippingCost;

            shippingCost = 10.0m;

            if (shippingCost <= decimal.Zero)
            {
                throw new ArgumentOutOfRangeException(nameof(shippingCost), "Shipping cost is out of range");
            }

            return shippingCost;
        }
    }
}
