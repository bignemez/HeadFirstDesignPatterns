namespace Observer_Pattern
{
    public interface ISubject
    {
        public void RegisterObserver(IWeatherDataObserver observer);
        public void RemoveObserver(IWeatherDataObserver   observer);
        public void NotifyObserver();
    }
}