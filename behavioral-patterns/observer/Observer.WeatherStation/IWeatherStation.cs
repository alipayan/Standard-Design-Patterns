namespace Observer.WeatherStation;

public interface IWeatherStation
{

    public void SetTemperature(int temperature);

    public int GetTemperature();
}
