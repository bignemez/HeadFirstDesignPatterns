using System;

namespace Observer_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var weatherData        = new WeatherData();
            var temperatureDisplay = new TemperatureDisplay(weatherData);
            var humidityDisplay    = new HumidityDisplay(weatherData);
            var pressureDisplay    = new PressureDisplay(weatherData);
            var heatIndexDisplay   = new HeatIndexDisplay(weatherData);
            weatherData.SetMeasurements(23,78,1002);

        }
    }
}