using System;

public class Urun
{
    // Özellikler
    public string Ad { get; set; }
    public decimal Fiyat { get; set; }
    private decimal _indirim;

    // İndirim için get/set metodları
    public decimal Indirim
    {
        get { return _indirim; }
        set
        {
            // İndirimi 0-50% arasında sınırlıyoruz
            if (value >= 0 && value <= 50)
            {
                _indirim = value;
            }
            else
            {
                Console.WriteLine("İndirim %0 ile %50 arasında olmalıdır.");
            }
        }
    }

    // Yapıcı Metot
    public Urun(string ad, decimal fiyat)
    {
        Ad = ad;
        Fiyat = fiyat;
        _indirim = 0; // Başlangıçta indirim yok
    }

    // İndirimli fiyatı hesaplayan metot
    public decimal IndirimliFiyat()
    {
        return Fiyat * (1 - _indirim / 100);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Ürün oluşturma
        Urun urun = new Urun("Laptop", 5000);

        // Ürünün bilgilerini görüntüleme
        Console.WriteLine($"Ürün Adı: {urun.Ad}");
        Console.WriteLine($"Ürün Fiyatı: {urun.Fiyat} TL");

        // İndirim uygulama
        urun.Indirim = 30; // %30 indirim

        // İndirimli fiyatı hesaplayıp görüntüleme
        Console.WriteLine($"İndirimli Fiyat: {urun.IndirimliFiyat()} TL");

        // Geçersiz indirim değeri
        urun.Indirim = 60; // Geçersiz indirim, 50'nin üstü
    }
}