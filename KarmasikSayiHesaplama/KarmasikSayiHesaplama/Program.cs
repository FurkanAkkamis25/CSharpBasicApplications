using System;

struct KarmaşıkSayı
{
    public double Gerçek { get; set; }
    public double Sanal { get; set; }

    public KarmaşıkSayı(double gerçek, double sanal)
    {
        Gerçek = gerçek;
        Sanal = sanal;
    }

    public KarmaşıkSayı Topla(KarmaşıkSayı diger)
    {
        return new KarmaşıkSayı(Gerçek + diger.Gerçek, Sanal + diger.Sanal);
    }

    public KarmaşıkSayı Çıkar(KarmaşıkSayı diger)
    {
        return new KarmaşıkSayı(Gerçek - diger.Gerçek, Sanal - diger.Sanal);
    }

    public override string ToString()
    {
        return $"{Gerçek} + {Sanal}i";
    }
}

class Program
{
    static void Main(string[] args)
    {
        KarmaşıkSayı s1 = new KarmaşıkSayı(3, 4);
        KarmaşıkSayı s2 = new KarmaşıkSayı(1, 2);

        Console.WriteLine($"Sayı 1: {s1}");
        Console.WriteLine($"Sayı 2: {s2}");
        Console.WriteLine($"Toplam: {s1.Topla(s2)}");
        Console.WriteLine($"Fark: {s1.Çıkar(s2)}");
    }
}
