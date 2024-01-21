using DependencyInversionPrinciple.Interfaces;
using System;

namespace DependencyInversionPrinciple.Implementations
{
    public class Thermometer : ISensor
    {
        public double Read()
        {
            Console.WriteLine("Thermometer reading...");
            return 15.0;
        }
    }
}
