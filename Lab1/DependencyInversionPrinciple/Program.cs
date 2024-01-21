using DependencyInversionPrinciple.Implementations;
using DependencyInversionPrinciple.Interfaces;

namespace DependencyInversionPrinciple
{
    public class Program
    {
        public static void Main()
        {
            ISensor thermometer = new Thermometer();
            IDevice heater = new Heater();

            Regulator regulator = new Regulator(thermometer, heater);
            regulator.Regulate(20.0, 25.0);
        }
    }
}
