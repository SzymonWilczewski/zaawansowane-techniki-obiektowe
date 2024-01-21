using FacadePattern.Extensions;
using System;

namespace FacadePattern.WeatherServices
{
    public class HumidityService : IHumidityService
    {
        public double GetHumidity() => new Random().NextDouble(0, 100);
    }
}
