using System;
using System.Collections.Generic;
using System.Linq;

namespace Observer_Pattern
{
    public class AveragedTemperatureDisplay : IWeatherDataObserver, IDisplayElement
    {
        private WeatherData _weatherData;
        private List<float> _temperature;
        private float       _humidity;

        public AveragedTemperatureDisplay(WeatherData weatherData)
        {
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);
            _temperature = new List<float>();
        }

        public void Update()
        {
            _temperature.Add(_weatherData.Temperature);
            _humidity = _weatherData.Humidity;
            Display();
        }

        public void Display()
        {
            _temperature.Sort();
            var tempMin = _temperature.FirstOrDefault();
            _temperature.Reverse();
            var tempMax = _temperature.FirstOrDefault();
            var avgTemp = _temperature.Sum() / _temperature.Count;

            Console.WriteLine($"Min {tempMin} Max {tempMax} Avg {avgTemp}");
        }
    }
}