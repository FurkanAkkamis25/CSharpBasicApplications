using System;

class Otopark
{
    private string[,] katlar;

    public Otopark(int katSayisi, int parkYeriSayisi)
    {
        katlar = new string[katSayisi, parkYeriSayisi];
    }

    public string this[int kat, int parkYeri]
    {
        get
        {
            if (kat < 0 || kat >= katlar.GetLength(0) || parkYeri < 0 || parkYeri >= katlar.GetLength(1))
            {
                return "Hata: Geçersiz park yeri!";
            }
            return katlar[kat, parkYeri] ?? "Empty";
        }
        set
        {
            if (kat < 0 || kat >= katlar.GetLength(0) || parkYeri < 0 || parkYeri >= katlar.GetLength(1))
            {
                Console.WriteLine("Hata: Geçersiz park yeri!");
            }
            else
            {
                katlar[kat, parkYeri] = value;
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Otopark otopark = new Otopark(3, 5);
        otopark[0, 0] = "34ABC123";
        otopark[2, 4] = "16XYZ789";

        Console.WriteLine(otopark[0, 0]); // 34ABC123
        Console.WriteLine(otopark[1, 1]); // Empty
        Console.WriteLine(otopark[3, 1]); // Hata: Geçersiz park yeri!
    }
}