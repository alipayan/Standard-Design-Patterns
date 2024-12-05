using Observer.WeatherStation.Abstractions;

namespace Observer.WeatherStation;

public class WallTV : IObserver
{
    public void Update(IObservable observable)
    {
        if (observable is WeatherStation weatherStation)
        {
            Console.WriteLine($"Weather Temperature is {weatherStation.GetTemperature()} from wall TV");
        }
    }
}
