// See https://aka.ms/new-console-template for more information
using Observer.WeatherStation;

Console.WriteLine("WellCome to observer weather station pattern");

var weatherStation = new WeatherStation();

weatherStation.SetTemperature(10);

var wallTV = new WallTV();

weatherStation.Add(wallTV);

weatherStation.SetTemperature(20);

weatherStation.Add(new TVRoom());

weatherStation.SetTemperature(30);

weatherStation.Remove(wallTV);

weatherStation.SetTemperature(60);