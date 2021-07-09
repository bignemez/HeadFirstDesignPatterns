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

        public void Update(float temperature, float humidity, float pressure)
        {
            _humidity = humidity;
            Display();
        }

        public void Display()
        {
            Console.WriteLine(_humidity);
        }
    }
}