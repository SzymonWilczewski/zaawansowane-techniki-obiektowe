using FacadePattern.Extensions;
using System;

namespace FacadePattern.WeatherServices
{
    public class TemperatureService : ITemperatureService
    {
        public double GetTemperature() => new Random().NextDouble(-20, 40);
    }
}
