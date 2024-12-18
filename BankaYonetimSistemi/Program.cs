using System;

namespace BankaSistemi
{
    // 1. Soyut Hesap sınıfı
    public abstract class Hesap
    {
        public string HesapNo { get; set; }
        public decimal Bakiye { get; protected set; }

        public abstract void ParaYatir(decimal miktar);
        public abstract void ParaCek(decimal miktar);
    }

    // 3. IBankaHesabi Arayüzü
    public interface IBankaHesabi
    {
        DateTime HesapAcilisTarihi { get; set; }
        void HesapOzeti();
    }

    // 2. BirikimHesabi sınıfı
    public class BirikimHesabi : Hesap, IBankaHesabi
    {
        public decimal FaizOrani { get; set; }
        public DateTime HesapAcilisTarihi { get; set; }

        public override void ParaYatir(decimal miktar)
        {
            decimal faiz = miktar * FaizOrani / 100;
            Bakiye += miktar + faiz;
            Console.WriteLine($"{miktar:C} yatırıldı. Faiz: {faiz:C}. Yeni Bakiye: {Bakiye:C}");
        }

        public override void ParaCek(decimal miktar)
        {
            if (Bakiye >= miktar)
            {
                Bakiye -= miktar;
                Console.WriteLine($"{miktar:C} çekildi. Yeni Bakiye: {Bakiye:C}");
            }
            else
            {
                Console.WriteLine("Yetersiz bakiye!");
            }
        }

        public void HesapOzeti()
        {
            Console.WriteLine($"\nBirikim Hesabı - Hesap No: {HesapNo}, Açılış Tarihi: {HesapAcilisTarihi:d}, Bakiye: {Bakiye:C}, Faiz Oranı: {FaizOrani}%");
        }
    }

    // 2. VadesizHesap sınıfı
    public class VadesizHesap : Hesap, IBankaHesabi
    {
        public decimal IslemUcreti { get; set; }
        public DateTime HesapAcilisTarihi { get; set; }

        public override void ParaYatir(decimal miktar)
        {
            Bakiye += miktar;
            Console.WriteLine($"{miktar:C} yatırıldı. Yeni Bakiye: {Bakiye:C}");
        }

        public override void ParaCek(decimal miktar)
        {
            decimal toplamTutar = miktar + IslemUcreti;

            if (Bakiye >= toplamTutar)
            {
                Bakiye -= toplamTutar;
                Console.WriteLine($"{miktar:C} çekildi. İşlem Ücreti: {IslemUcreti:C}. Yeni Bakiye: {Bakiye:C}");
            }
            else
            {
                Console.WriteLine("Yetersiz bakiye!");
            }
        }

        public void HesapOzeti()
        {
            Console.WriteLine($"\nVadesiz Hesap - Hesap No: {HesapNo}, Açılış Tarihi: {HesapAcilisTarihi:d}, Bakiye: {Bakiye:C}, İşlem Ücreti: {IslemUcreti:C}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 4. Banka hesabı yönetimini test etme
            BirikimHesabi birikimHesap = new BirikimHesabi
            {
                HesapNo = "B123456",
                FaizOrani = 5,
                HesapAcilisTarihi = DateTime.Now
            };

            VadesizHesap vadesizHesap = new VadesizHesap
            {
                HesapNo = "V987654",
                IslemUcreti = 2,
                HesapAcilisTarihi = DateTime.Now
            };

            // Birikim Hesabında İşlemler
            Console.WriteLine("Birikim Hesabı İşlemleri:");
            birikimHesap.ParaYatir(1000);
            birikimHesap.ParaCek(200);
            birikimHesap.HesapOzeti();

            // Vadesiz Hesapta İşlemler
            Console.WriteLine("\nVadesiz Hesap İşlemleri:");
            vadesizHesap.ParaYatir(500);
            vadesizHesap.ParaCek(100);
            vadesizHesap.HesapOzeti();
        }
    }
}