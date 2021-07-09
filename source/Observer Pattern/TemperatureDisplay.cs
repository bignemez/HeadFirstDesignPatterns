using System;

namespace Observer_Pattern
{
    public class TemperatureDisplay : IWeatherDataObserver, IDisplayElement
    {
        private float       _temperature;
        private WeatherData _weatherData;

        public TemperatureDisplay(WeatherData weatherData)
        {
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            _temperature = temperature;
            Display();
        }

        public void Display()
        {
            Console.WriteLine(_temperature);
        }
    }
}