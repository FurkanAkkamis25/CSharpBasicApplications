using System;

namespace HayvanatBahcesiYonetimSistemi
{
    // Temel Hayvan sınıfı
    public class Hayvan
    {
        public string Ad { get; set; }
        public string Tur { get; set; }
        public string Yas { get; set; }

        public virtual string SesCikar()
        {
            return "Genel bir hayvan sesi çıkarıyor.";
        }

        public override string ToString()
        {
            return $"Ad: {Ad}, Tür: {Tur}, Yaş: {Yas}";
        }
    }

    // Memeli sınıfı
    public class Memeli : Hayvan
    {
        public string TuyRengi { get; set; }

        public override string SesCikar()
        {
            return "Memeli ses çıkarıyor.";
        }

        public override string ToString()
        {
            return base.ToString() + $", Tüy Rengi: {TuyRengi}";
        }
    }

    // Kus sınıfı
    public class Kus : Hayvan
    {
        public double KanatGenisligi { get; set; }

        public override string SesCikar()
        {
            return "Kuş ses çıkarıyor.";
        }

        public override string ToString()
        {
            return base.ToString() + $", Kanat Genişliği: {KanatGenisligi} metre";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hayvan türünü seçin (1: Memeli, 2: Kuş): ");
            int hayvanSecim = int.Parse(Console.ReadLine());

            Hayvan hayvan;

            if (hayvanSecim == 1)
            {
                hayvan = new Memeli
                {
                    Ad = "Aslan",
                    Tur = "Memeli",
                    Yas = "5",
                    TuyRengi = "Altın Sarısı"
                };
            }
            else
            {
                hayvan = new Kus
                {
                    Ad = "Kartal",
                    Tur = "Kuş",
                    Yas = "3",
                    KanatGenisligi = 2.5
                };
            }

            Console.WriteLine(hayvan.ToString());
            Console.WriteLine($"Ses: {hayvan.SesCikar()}");
        }
    }
}