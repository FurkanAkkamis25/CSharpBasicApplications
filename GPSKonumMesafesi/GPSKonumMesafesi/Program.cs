using System;

struct GPS
{
    public double Enlem { get; set; }
    public double Boylam { get; set; }

    public GPS(double enlem, double boylam)
    {
        Enlem = enlem;
        Boylam = boylam;
    }

    public double Mesafe(GPS diger)
    {
        const double R = 6371; // Dünya yarıçapı (km)
        double enlemRadyan1 = Enlem * Math.PI / 180;
        double enlemRadyan2 = diger.Enlem * Math.PI / 180;
        double deltaEnlem = (diger.Enlem - Enlem) * Math.PI / 180;
        double deltaBoylam = (diger.Boylam - Boylam) * Math.PI / 180;

        double a = Math.Sin(deltaEnlem / 2) * Math.Sin(deltaEnlem / 2) +
                   Math.Cos(enlemRadyan1) * Math.Cos(enlemRadyan2) *
                   Math.Sin(deltaBoylam / 2) * Math.Sin(deltaBoylam / 2);
        double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

        return R * c;
    }

    public override string ToString()
    {
        return $"({Enlem}, {Boylam})";
    }
}

class Program
{
    static void Main(string[] args)
    {
        GPS konum1 = new GPS(41.0082, 28.9784); // İstanbul
        GPS konum2 = new GPS(39.9208, 32.8541); // Ankara

        Console.WriteLine($"Konum 1: {konum1}");
        Console.WriteLine($"Konum 2: {konum2}");
        Console.WriteLine($"Mesafe: {konum1.Mesafe(konum2):F2} km");
    }
}