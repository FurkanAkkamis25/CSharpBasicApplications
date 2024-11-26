using System;

enum TrafficLight
{
    Red,
    Yellow,
    Green
}

class TrafficSignal
{
    public static string GetAction(TrafficLight light)
    {
        switch (light)
        {
            case TrafficLight.Red:
                return "Dur!";
            case TrafficLight.Yellow:
                return "Hazır ol!";
            case TrafficLight.Green:
                return "Geç!";
            default:
                return "Geçersiz trafik ışığı.";
        }
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine(TrafficSignal.GetAction(TrafficLight.Red));
        Console.WriteLine(TrafficSignal.GetAction(TrafficLight.Yellow));
        Console.WriteLine(TrafficSignal.GetAction(TrafficLight.Green));
    }
}