using System;

namespace Observer_Pattern
{
    public class HeatIndexDisplay : IWeatherDataObserver, IDisplayElement
    {
        private float       _temperature;
        private float       _humidity;
        private WeatherData _weatherData;

        public HeatIndexDisplay(WeatherData weatherData)
        {
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }

        public void Update()
        {
            _temperature = _weatherData.Temperature;
            _humidity    = _weatherData.Humidity;
            Display();
        }

        public void Display()
        {
            Console.WriteLine($"Heatindex is {_temperature+_humidity}");
        }
    }
}