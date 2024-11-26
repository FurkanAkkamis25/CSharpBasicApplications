using System;

enum Weather
{
    Sunny,
    Rainy,
    Cloudy,
    Stormy
}

class WeatherAdvice
{
    public static string GetAdvice(Weather weather)
    {
        switch (weather)
        {
            case Weather.Sunny:
                return "Güneş kremi sür!";
            case Weather.Rainy:
                return "Şemsiyeni al!";
            case Weather.Cloudy:
                return "Hava serin olabilir, dikkat et.";
            case Weather.Stormy:
                return "Dışarı çıkma, güvende kal.";
            default:
                return "Geçersiz hava durumu.";
        }
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine(WeatherAdvice.GetAdvice(Weather.Sunny));
        Console.WriteLine(WeatherAdvice.GetAdvice(Weather.Rainy));
        Console.WriteLine(WeatherAdvice.GetAdvice(Weather.Cloudy));
        Console.WriteLine(WeatherAdvice.GetAdvice(Weather.Stormy));
    }
}