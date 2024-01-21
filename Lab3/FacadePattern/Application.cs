using System;

namespace FacadePattern
{
    class Application
    {
        public static void Run(WeatherApiFasade weatherApiFasade)
        {
            Console.Write(weatherApiFasade.GetWeatherInformation());
        }
    }
}
