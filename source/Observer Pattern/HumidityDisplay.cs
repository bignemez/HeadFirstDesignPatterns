using System;

namespace Observer_Pattern
{
    public class HumidityDisplay : IWeatherDataObserver, IDisplayElement
    {
        private float       _humidity;
        private WeatherData _weatherData;

        public HumidityDisplay(WeatherData weatherData)
        {
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }

        public void Update()
        {
            _humidity =_weatherData.Humidity;
            Display();
        }

        public void Display()
        {
            Console.WriteLine(_humidity);
        }
    }
}