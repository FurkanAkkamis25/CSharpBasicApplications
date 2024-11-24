using System;

class Program
{
    //Karenin alanı
    static double Alan(double kenar)
    {
        return kenar * kenar;
    }

    //Dikdörtgenin alanı
    static double Alan(double uzunKenar, double kisaKenar)
    {
        return uzunKenar * kisaKenar;
    }

    // Dairenin alanı
    static double Alan(double yaricap, bool daire)
    {
        if (daire) // Dairenin alanı için ek parametre kontrolü
            return Math.PI * yaricap * yaricap;
        return 0;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Karenin Alanı: " + Alan(4)); 
        Console.WriteLine("Dikdörtgenin Alanı: " + Alan(5, 3));
        Console.WriteLine("Dairenin Alanı: " + Alan(3, true)); 
    }
}