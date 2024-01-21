using DependencyInversionPrinciple.Interfaces;
using System;

namespace DependencyInversionPrinciple.Implementations
{
    public class Heater : IDevice
    {
        public void Engage()
        {
            Console.WriteLine("Heater engaging...");
        }

        public void Disengage()
        {
            Console.WriteLine("Heater disengaging...");
        }
    }
}
