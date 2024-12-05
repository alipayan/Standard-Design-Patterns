namespace Observer.WeatherStation.Abstractions;

public interface IObservable
{
    protected void Add(IObserver observer);
    protected void Remove(IObserver observer);
    protected void Notify();
}
