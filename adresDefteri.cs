using System;

public class Kisi
{
    // Özellikler
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public string TelefonNumarasi { get; set; }

    // Yapıcı Metot
    public Kisi(string ad, string soyad, string telefonNumarasi)
    {
        Ad = ad;
        Soyad = soyad;
        TelefonNumarasi = telefonNumarasi;
    }

    // Kisi Bilgisi Metodu
    public string KisiBilgisi()
    {
        return $"Ad: {Ad} {Soyad}, Telefon: {TelefonNumarasi}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Kisi oluşturma
        Kisi kisi1 = new Kisi("Furkan", "Akkamis", "0555 123 45 67");

        // Kişinin bilgilerini alma
        Console.WriteLine(kisi1.KisiBilgisi());
    }
}