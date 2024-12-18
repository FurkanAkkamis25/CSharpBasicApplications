using System;
using System.Collections.Generic;

namespace ObserverPattern
{
    // 1. IYayinci Arayüzü
    public interface IYayinci
    {
        void AboneEkle(IAbone abone);
        void AboneCikart(IAbone abone);
        void BildirimGonder();
    }

    // 1. IAbone Arayüzü
    public interface IAbone
    {
        void BilgiAl(string mesaj);
    }

    // 2. Yayinci Sınıfı
    public class Yayinci : IYayinci
    {
        private List<IAbone> aboneler = new List<IAbone>();
        public string Durum { get; set; }

        public void AboneEkle(IAbone abone)
        {
            aboneler.Add(abone);
            Console.WriteLine("Yeni bir abone eklendi.");
        }

        public void AboneCikart(IAbone abone)
        {
            aboneler.Remove(abone);
            Console.WriteLine("Bir abone çıkarıldı.");
        }

        public void BildirimGonder()
        {
            foreach (IAbone abone in aboneler)
            {
                abone.BilgiAl($"Yayinci güncellendi: {Durum}");
            }
        }
    }

    // 3. Abone Sınıfı
    public class Abone : IAbone
    {
        public string Ad { get; set; }

        public Abone(string ad)
        {
            Ad = ad;
        }

        public void BilgiAl(string mesaj)
        {
            Console.WriteLine($"{Ad} bildirim aldı: {mesaj}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 4. Observer Pattern Testi
            Yayinci yayinci = new Yayinci();

            // Aboneler oluşturuluyor
            Abone abone1 = new Abone("Ahmet");
            Abone abone2 = new Abone("Mehmet");
            Abone abone3 = new Abone("Ayşe");

            // Aboneleri ekle
            yayinci.AboneEkle(abone1);
            yayinci.AboneEkle(abone2);
            yayinci.AboneEkle(abone3);

            // Yayıncı güncelleme yapıyor
            yayinci.Durum = "Yeni bir video yayınlandı!";
            yayinci.BildirimGonder();

            // Bir aboneyi çıkar
            yayinci.AboneCikart(abone2);

            // Yayıncı güncelleme yapıyor
            yayinci.Durum = "Canlı yayın başladı!";
            yayinci.BildirimGonder();
        }
    }
}