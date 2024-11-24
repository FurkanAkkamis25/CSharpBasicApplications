using System;

class SatrancTahtasi
{
    private string[,] tahtadakiTaslar = new string[8, 8];

    public string this[int satir, int sutun]
    {
        get
        {
            if (satir < 0 || satir >= 8 || sutun < 0 || sutun >= 8)
            {
                return "Hata: Geçersiz kare!";
            }
            return tahtadakiTaslar[satir, sutun] ?? "Boş";
        }
        set
        {
            if (satir < 0 || satir >= 8 || sutun < 0 || sutun >= 8)
            {
                Console.WriteLine("Hata: Geçersiz kare!");
            }
            else
            {
                tahtadakiTaslar[satir, sutun] = value;
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        SatrancTahtasi tahta = new SatrancTahtasi();
        tahta[0, 0] = "Kale";
        tahta[7, 7] = "Şah";

        Console.WriteLine(tahta[0, 0]); // Kale
        Console.WriteLine(tahta[1, 1]); // Boş
        Console.WriteLine(tahta[8, 8]); // Hata: Geçersiz kare!
    }
}