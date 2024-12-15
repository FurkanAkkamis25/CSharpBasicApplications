using System;

namespace CalisanYonetimSistemi
{
    // Temel Calisan sınıfı
    public class Calisan
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Pozisyon { get; set; }
        public decimal Maas { get; set; }

        public virtual string BilgiYazdir()
        {
            return $"{Ad} {Soyad} - Pozisyon: {Pozisyon}, Maaş: {Maas:C}";
        }
    }

    // Yazilimci sınıfı
    public class Yazilimci : Calisan
    {
        public string YazilimDili { get; set; }

        public override string BilgiYazdir()
        {
            return base.BilgiYazdir() + $", Yazılım Dili: {YazilimDili}";
        }
    }

    // Muhasebeci sınıfı
    public class Muhasebeci : Calisan
    {
        public string MuhasebeYazilimi { get; set; }

        public override string BilgiYazdir()
        {
            return base.BilgiYazdir() + $", Muhasebe Yazılımı: {MuhasebeYazilimi}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çalışan türünü seçin (1: Yazılımcı, 2: Muhasebeci): ");
            int calisanSecim = int.Parse(Console.ReadLine());

            Calisan calisan;

            if (calisanSecim == 1)
            {
                calisan = new Yazilimci
                {
                    Ad = "Ali",
                    Soyad = "Kaya",
                    Pozisyon = "Kıdemli Yazılımcı",
                    Maas = 15000,
                    YazilimDili = "C#"
                };
            }
            else
            {
                calisan = new Muhasebeci
                {
                    Ad = "Ayşe",
                    Soyad = "Yılmaz",
                    Pozisyon = "Muhasebe Uzmanı",
                    Maas = 12000,
                    MuhasebeYazilimi = "Logo"
                };
            }

            Console.WriteLine(calisan.BilgiYazdir());
        }
    }
}