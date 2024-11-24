using System;

class Kitaplik
{
    private string[] kitaplar;

    public Kitaplik(int kapasite)
    {
        kitaplar = new string[kapasite];
    }

    public string this[int indeks]
    {
        get
        {
            if (indeks < 0 || indeks >= kitaplar.Length)
            {
                return "Hata: Geçersiz indeks!";
            }
            return kitaplar[indeks] ?? "Boş yer.";
        }
        set
        {
            if (indeks < 0 || indeks >= kitaplar.Length)
            {
                Console.WriteLine("Hata: Geçersiz indeks!");
            }
            else
            {
                kitaplar[indeks] = value;
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Kitaplik kitaplik = new Kitaplik(5);
        kitaplik[0] = "Savaş ve Barış";
        kitaplik[1] = "1984";

        Console.WriteLine(kitaplik[0]); // Savaş ve Barış
        Console.WriteLine(kitaplik[3]); // Boş yer.
        Console.WriteLine(kitaplik[5]); // Hata: Geçersiz indeks!
    }
}