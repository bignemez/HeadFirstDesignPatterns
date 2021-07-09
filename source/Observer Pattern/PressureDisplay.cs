using System;

namespace Observer_Pattern
{
    public class PressureDisplay : IWeatherDataObserver, IDisplayElement
    {
        private float       _pressure;
        private WeatherData _weatherData;

        public PressureDisplay(WeatherData weatherData)
        {
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            _pressure = pressure;
            Display();
        }

        public void Display()
        {
            Console.WriteLine(_pressure);
        }
    }
}