using System;
using System.Collections.Generic;

namespace MagazaYonetimSistemi
{
    // 1. Soyut Urun Sınıfı
    public abstract class Urun
    {
        public string Ad { get; set; }
        public decimal Fiyat { get; set; }

        public abstract decimal HesaplaOdeme();

        public virtual void BilgiYazdir()
        {
            Console.WriteLine($"Ürün: {Ad}, Fiyat: {Fiyat:C}");
        }
    }

    // 2. Kitap Sınıfı
    public class Kitap : Urun
    {
        public override decimal HesaplaOdeme()
        {
            return Fiyat * 1.10m; // %10 vergi ekleniyor
        }

        public override void BilgiYazdir()
        {
            Console.WriteLine($"Kitap: {Ad}, Ana Fiyat: {Fiyat:C}, Toplam Ödeme: {HesaplaOdeme():C}");
        }
    }

    // 2. Elektronik Sınıfı
    public class Elektronik : Urun
    {
        public override decimal HesaplaOdeme()
        {
            return Fiyat * 1.25m; // %25 vergi ekleniyor
        }

        public override void BilgiYazdir()
        {
            Console.WriteLine($"Elektronik: {Ad}, Ana Fiyat: {Fiyat:C}, Toplam Ödeme: {HesaplaOdeme():C}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 4. List<Urun> Koleksiyonu Oluşturma
            List<Urun> urunler = new List<Urun>
            {
                new Kitap { Ad = "C# Programlama", Fiyat = 150 },
                new Elektronik { Ad = "Laptop", Fiyat = 5000 },
                new Kitap { Ad = "Algoritmalar", Fiyat = 200 },
                new Elektronik { Ad = "Telefon", Fiyat = 3000 }
            };

            // Ürün bilgilerini ekrana yazdırma
            Console.WriteLine("Ürün Listesi ve Ödemeler:\n");
            foreach (Urun urun in urunler)
            {
                urun.BilgiYazdir();
            }
        }
    }
}