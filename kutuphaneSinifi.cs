using System;
using System.Collections.Generic;

public class Kitap
{
    // Kitap özellikleri
    public string Ad { get; set; }
    public string Yazar { get; set; }
    public string ISBN { get; set; }

    // Yapıcı metot
    public Kitap(string ad, string yazar, string isbn)
    {
        Ad = ad;
        Yazar = yazar;
        ISBN = isbn;
    }

    // Kitap bilgisini döndüren metod
    public override string ToString()
    {
        return $"Kitap Adı: {Ad}, Yazar: {Yazar}, ISBN: {ISBN}";
    }
}

public class Kutuphane
{
    // Kitap listesi
    public List<Kitap> Kitaplar { get; private set; }

    // Yapıcı metot
    public Kutuphane()
    {
        Kitaplar = new List<Kitap>();  // Kitap listesi başlangıçta boş
    }

    // Kitap ekleme metodu
    public void KitapEkle(Kitap yeniKitap)
    {
        // Kitap ekleme işlemi
        Kitaplar.Add(yeniKitap);
        Console.WriteLine($"'{yeniKitap.Ad}' adlı kitap kütüphaneye eklendi.");
    }

    // Kitapları listeleme metodu
    public void KitaplariListele()
    {
        Console.WriteLine("Kütüphanedeki Kitaplar:");
        foreach (var kitap in Kitaplar)
        {
            // Kitap bilgilerini ekrana yazdırma
            Console.WriteLine(kitap.ToString());
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Kütüphane oluşturma
        Kutuphane kutuphane = new Kutuphane();

        // Kitaplar oluşturma
        Kitap kitap1 = new Kitap("C# Programlama", "John Doe", "1234567890");
        Kitap kitap2 = new Kitap("Veritabanı Yönetimi", "Jane Smith", "0987654321");

        // Kitapları kütüphaneye ekleme
        kutuphane.KitapEkle(kitap1);
        kutuphane.KitapEkle(kitap2);

        // Kitapları listeleme
        kutuphane.KitaplariListele();
    }
}