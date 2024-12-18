using System;

namespace BankaSistemi
{
    // Temel Hesap sınıfı
    public class Hesap
    {
        public string HesapNo { get; set; }
        public string HesapSahibi { get; set; }
        public decimal Bakiye { get; set; }

        public virtual void ParaYatir(decimal miktar)
        {
            Bakiye += miktar;
            Console.WriteLine($"{miktar:C} yatırıldı. Yeni bakiye: {Bakiye:C}");
        }

        public virtual void ParaCek(decimal miktar)
        {
            if (Bakiye >= miktar)
            {
                Bakiye -= miktar;
                Console.WriteLine($"{miktar:C} çekildi. Yeni bakiye: {Bakiye:C}");
            }
            else
            {
                Console.WriteLine("Yetersiz bakiye!");
            }
        }

        public virtual void BilgiYazdir()
        {
            Console.WriteLine($"Hesap No: {HesapNo}, Hesap Sahibi: {HesapSahibi}, Bakiye: {Bakiye:C}");
        }
    }

    // Vadesiz Hesap sınıfı
    public class VadesizHesap : Hesap
    {
        public decimal EkHesapLimiti { get; set; }

        public override void ParaCek(decimal miktar)
        {
            if (Bakiye + EkHesapLimiti >= miktar)
            {
                decimal kalan = miktar - Bakiye;
                Bakiye = 0;

                if (kalan > 0)
                {
                    EkHesapLimiti -= kalan;
                }
                Console.WriteLine($"{miktar:C} çekildi. Yeni bakiye: {Bakiye:C}, Ek Hesap Limiti: {EkHesapLimiti:C}");
            }
            else
            {
                Console.WriteLine("Yetersiz bakiye ve ek hesap limiti!");
            }
        }

        public override void BilgiYazdir()
        {
            base.BilgiYazdir();
            Console.WriteLine($"Ek Hesap Limiti: {EkHesapLimiti:C}");
        }
    }

    // Vadeli Hesap sınıfı
    public class VadeliHesap : Hesap
    {
        public int VadeSuresi { get; set; } // Ay cinsinden vade süresi
        public decimal FaizOrani { get; set; } // Yüzde cinsinden faiz oranı
        public bool VadeDolduMu { get; set; }

        public override void ParaCek(decimal miktar)
        {
            if (!VadeDolduMu)
            {
                Console.WriteLine("Vade dolmadan para çekemezsiniz!");
            }
            else
            {
                base.ParaCek(miktar);
            }
        }

        public override void BilgiYazdir()
        {
            base.BilgiYazdir();
            Console.WriteLine($"Vade Süresi: {VadeSuresi} ay, Faiz Oranı: %{FaizOrani}, Vade Durumu: {(VadeDolduMu ? "Doldu" : "Dolmadı")}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hesap türünü seçin (1: Vadesiz Hesap, 2: Vadeli Hesap): ");
            int secim = int.Parse(Console.ReadLine());

            Hesap hesap;

            if (secim == 1)
            {
                hesap = new VadesizHesap
                {
                    HesapNo = "123456789",
                    HesapSahibi = "Ali Veli",
                    Bakiye = 1000,
                    EkHesapLimiti = 500
                };
            }
            else
            {
                hesap = new VadeliHesap
                {
                    HesapNo = "987654321",
                    HesapSahibi = "Ayşe Yılmaz",
                    Bakiye = 5000,
                    VadeSuresi = 12,
                    FaizOrani = 10,
                    VadeDolduMu = false
                };
            }

            Console.WriteLine("\nHesap Bilgileri:");
            hesap.BilgiYazdir();

            Console.WriteLine("\nİşlem Seçin: (1: Para Yatır, 2: Para Çek): ");
            int islem = int.Parse(Console.ReadLine());

            Console.WriteLine("Miktar girin: ");
            decimal miktar = decimal.Parse(Console.ReadLine());

            if (islem == 1)
            {
                hesap.ParaYatir(miktar);
            }
            else if (islem == 2)
            {
                hesap.ParaCek(miktar);
            }
            else
            {
                Console.WriteLine("Geçersiz işlem!");
            }

            Console.WriteLine("\nGüncel Hesap Bilgileri:");
            hesap.BilgiYazdir();
        }
    }
}
