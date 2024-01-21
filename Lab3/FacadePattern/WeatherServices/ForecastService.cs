using FacadePattern.Extensions;
using System;

namespace FacadePattern.WeatherServices
{
    public class ForecastService : IForecastService
    {
        public double GetForecast() => new Random().NextDouble(0, 100);
    }
}
