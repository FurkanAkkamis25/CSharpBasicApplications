using System;

public class BankaHesabi
{
    // Özellikler
    public string HesapNumarasi { get; private set; }
    private decimal Bakiye { get; set; }

    // Yapıcı Metot
    public BankaHesabi(string hesapNumarasi, decimal ilkBakiye)
    {
        HesapNumarasi = hesapNumarasi;
        Bakiye = ilkBakiye;
    }

    // Bakiye'yi görüntülemek için bir metot
    public decimal BakiyeGoster()
    {
        return Bakiye;
    }

    // Para Yatırma Metodu
    public void ParaYatir(decimal miktar)
    {
        if (miktar > 0)
        {
            Bakiye += miktar;
            Console.WriteLine($"{miktar} TL yatırıldı. Güncel bakiye: {Bakiye} TL");
        }
        else
        {
            Console.WriteLine("Yatırılacak miktar pozitif olmalıdır.");
        }
    }

    // Para Çekme Metodu
    public void ParaCek(decimal miktar)
    {
        if (miktar > 0 && miktar <= Bakiye)
        {
            Bakiye -= miktar;
            Console.WriteLine($"{miktar} TL çekildi. Güncel bakiye: {Bakiye} TL");
        }
        else if (miktar > Bakiye)
        {
            Console.WriteLine("Yetersiz bakiye.");
        }
        else
        {
            Console.WriteLine("Çekilecek miktar pozitif olmalıdır.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Banka hesabı oluşturma
        BankaHesabi hesap = new BankaHesabi("1234567890", 1000);

        // Hesap bilgilerini görüntüleme
        Console.WriteLine($"Hesap Numarası: {hesap.HesapNumarasi}");
        Console.WriteLine($"Başlangıç bakiyesi: {hesap.BakiyeGoster()} TL");

        // Para yatırma işlemi
        hesap.ParaYatir(500);

        // Para çekme işlemi
        hesap.ParaCek(200);

        // Yetersiz bakiye durumu
        hesap.ParaCek(1500);
    }
}