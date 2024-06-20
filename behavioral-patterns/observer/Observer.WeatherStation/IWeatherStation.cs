using Observer.WeatherStation.Abstractions;

namespace Observer.WeatherStation;

public interface IWeatherStation : IObservable
{

    public void SetTemperature(int temperature);

    public int GetTemperature();
}
