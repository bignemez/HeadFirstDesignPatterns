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

        public void Update()
        {
            _pressure = _weatherData.Pressure;
            Display();
        }

        public void Display()
        {
            Console.WriteLine(_pressure);
        }
    }
}