using System;

namespace Observer_Pattern
{
    public class TemperatureDisplay : IWeatherDataObserver, IDisplayElement
    {
        private          float       _temperature;
        private readonly WeatherData _weatherData;

        public TemperatureDisplay(WeatherData weatherData)
        {
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine(_temperature);
        }

        public void Update()
        {
            _temperature = _weatherData.Temperature;
            Display();
        }
    }
}