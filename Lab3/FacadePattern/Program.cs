using FacadePattern.WeatherServices;

namespace FacadePattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            WeatherApiFasade weatherApiFasade = new WeatherApiFasade(
                new TemperatureService(),
                new HumidityService(),
                new ForecastService());

            Application.Run(weatherApiFasade);
        }
    }
}
