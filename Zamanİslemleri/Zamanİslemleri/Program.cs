using System;

struct Zaman
{
    public int Saat { get; private set; }
    public int Dakika { get; private set; }

    public Zaman(int saat, int dakika)
    {
        if (saat < 0 || saat > 23 || dakika < 0 || dakika > 59)
        {
            Saat = 0;
            Dakika = 0;
        }
        else
        {
            Saat = saat;
            Dakika = dakika;
        }
    }

    public int ToplamDakika()
    {
        return Saat * 60 + Dakika;
    }

    public static int Fark(Zaman z1, Zaman z2)
    {
        return Math.Abs(z1.ToplamDakika() - z2.ToplamDakika());
    }

    public override string ToString()
    {
        return $"{Saat:D2}:{Dakika:D2}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Zaman z1 = new Zaman(14, 30);
        Zaman z2 = new Zaman(10, 15);

        Console.WriteLine($"Zaman 1: {z1}");
        Console.WriteLine($"Zaman 2: {z2}");
        Console.WriteLine($"Toplam Dakika Farkı: {Zaman.Fark(z1, z2)}");
    }
}