using System;

namespace Observer_Pattern
{
    public class HeatIndexDisplay : IWeatherDataObserver, IDisplayElement
    {
        private float       _temperature;
        private float       _pressure;
        private float       _humidity;
        private WeatherData _weatherData;

        public HeatIndexDisplay(WeatherData weatherData)
        {
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            _temperature = temperature;
            _humidity    = humidity;
            _pressure    = pressure;
            Display();
        }

        public void Display()
        {
            Console.WriteLine($"Heatindex is {_temperature+_humidity}");
        }
    }
}