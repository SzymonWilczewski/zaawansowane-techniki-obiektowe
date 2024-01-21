using DependencyInversionPrinciple.Interfaces;
using System.Threading;

// Extract low-level abstractions from Regulator class and inverse dependency following the dependency inversion principle based on:
// https://pierresimondelaplace.gitlab.io/wsb-zaawansowane-techniki-obiektowe/WSB_ZaawansowaneTechnikiObiektowe.pdf

namespace DependencyInversionPrinciple
{
    public class Regulator
    {
        private readonly ISensor sensor;
        private readonly IDevice device;

        public Regulator(ISensor sensor, IDevice device)
        {
            this.sensor = sensor;
            this.device = device;
        }

        public void Regulate(double minTemp, double maxTemp)
        {
            for (;;)
            {
                while (sensor.Read() > minTemp)
                {
                    Thread.Sleep(1000);
                }
                device.Engage();
                while (sensor.Read() < maxTemp)
                {
                    Thread.Sleep(1000);
                }
                device.Disengage();
            }
        }
    }
}
