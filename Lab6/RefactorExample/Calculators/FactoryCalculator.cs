using RefactorExample.DTOs;
using System;

namespace RefactorExample.Calculators
{
    internal class FactoryCalculator
    {
        public static IPerformanceCalculator Create(Play play)
        {
            switch (play.Type.ToLowerInvariant())
            {
                case "tragedia":
                    return new TragedyCalculator();
                case "komedia":
                    return new ComedyCalculator();
                default:
                    throw new ArgumentException($"Unknown type of play");
            }
        }
    }
}
