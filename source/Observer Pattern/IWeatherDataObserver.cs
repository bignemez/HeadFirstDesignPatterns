namespace Observer_Pattern
{
    public interface IWeatherDataObserver
    {
        public void Update(float temperature, float humidity, float pressure);
    }
}