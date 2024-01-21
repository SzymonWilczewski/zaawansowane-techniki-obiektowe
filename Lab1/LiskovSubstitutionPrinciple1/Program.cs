using System;
using System.Globalization;

namespace LiskovSubstitutionPrinciple1
{
    public class Program
    {
        public static void Main()
        {
            ShippingStrategy shippingStrategy = new ShippingStrategy();

            try
            {
                var weight = new Weight(5);
                var size = new Size(10, 15);
                var destination = new RegionInfo("US");

                var shippingCost = shippingStrategy.CalculateShippingCost(weight, size, destination);

                Console.WriteLine($"Shipping cost is: {shippingCost}");
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Exception caught: {exception.Message}");
            }

            try
            {
                var weight = new Weight(-5);
                var size = new Size(10, 15);
                var destination = new RegionInfo("US");

                var shippingCost = shippingStrategy.CalculateShippingCost(weight, size, destination);

                Console.WriteLine($"Shipping cost is: {shippingCost}");
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Exception caught: {exception.Message}");
            }

            try
            {
                var weight = new Weight(5);
                var size = new Size(10, 15);
                var destination = new RegionInfo("US");
                shippingStrategy.FlatRate = -10.0m;

                var shippingCost = shippingStrategy.CalculateShippingCost(weight, size, destination);

                Console.WriteLine($"Shipping cost is: {shippingCost}");
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Exception caught: {exception.Message}");
            }
        }
    }
}
