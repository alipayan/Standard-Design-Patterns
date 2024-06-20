using Observer.WeatherStation.Abstractions;

namespace Observer.WeatherStation;

public class WeatherStation : IWeatherStation
{
    private int _temperature;
    private readonly IList<IObserver> observers;


    public WeatherStation()
    {
        observers = new List<IObserver>();
    }

    public void SetTemperature(int temperature)
    {
        _temperature = temperature;
        Notify();
        Console.WriteLine("------------");
    }

    public int GetTemperature()
    {
        return _temperature;
    }

    public void Add(IObserver observer)
    {
        observers.Add(observer);
    }

    public void Remove(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void Notify()
    {
        foreach (var observer in observers)
        {
            observer.Update(this);
        }
    }
}
