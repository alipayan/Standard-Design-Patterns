using Observer.WeatherStation.Abstractions;

namespace Observer.WeatherStation;

public class TVRoom : IObserver
{
    public void Update(IObservable observable)
    {
        if (observable is WeatherStation weatherStation)
        {
            Console.WriteLine($"Weather temperature is {weatherStation.GetTemperature()} from {nameof(TVRoom)}");
        }
    }
}
