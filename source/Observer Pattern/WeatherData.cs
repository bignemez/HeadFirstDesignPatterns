using System.Collections.Generic;
using System.Data;

namespace Observer_Pattern
{
    public class WeatherData : ISubject
    {
        public float Humidity    { get; set; }
        public float Pressure    { get; set; }
        public float Temperature { get; set; }

        private List<IWeatherDataObserver> _weatherDataObservers;

        public WeatherData()
        {
            _weatherDataObservers = new List<IWeatherDataObserver>();
        }

        private void MeasurementsChanged()
        {
            NotifyObserver();
        }

        public void RegisterObserver(IWeatherDataObserver observer)
        {
            _weatherDataObservers.Add(observer);
        }

        public void RemoveObserver(IWeatherDataObserver observer)
        {
            _weatherDataObservers.Remove(observer);
        }

        public void NotifyObserver()
        {
            _weatherDataObservers?.ForEach(observer => observer.Update());
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            Temperature = temperature;
            Humidity    = humidity;
            Pressure    = pressure;
            MeasurementsChanged();
        }
    }
}