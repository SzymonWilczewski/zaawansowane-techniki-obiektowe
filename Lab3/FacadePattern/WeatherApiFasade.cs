using FacadePattern.WeatherServices;

namespace FacadePattern
{
    public class WeatherApiFasade
    {
        private readonly ITemperatureService temperatureService;
        private readonly IHumidityService humidityService;
        private readonly IForecastService forecastService;

        public WeatherApiFasade(ITemperatureService temperatureService, IHumidityService humidityService, IForecastService forecastService)
        {
            this.temperatureService = temperatureService;
            this.humidityService = humidityService;
            this.forecastService = forecastService;
        }

        public Weather GetWeatherInformation()
        {
            return new Weather(
                temperatureService.GetTemperature(),
                humidityService.GetHumidity(),
                forecastService.GetForecast());
        }
    }
}
