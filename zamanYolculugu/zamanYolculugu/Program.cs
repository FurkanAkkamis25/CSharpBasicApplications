using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zamanYolculugu
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> uygunTarihler = new List<string>();
            DateTime bugun = DateTime.Today;

            // 2000-3000 yılları arasındaki tüm tarihleri tarıyoruz.
            for (int yil = 2000; yil <= 3000; yil++)
            {
                // Yıl koşulunu kontrol et
                if (!YilKosulunuSaglar(yil)) continue;

                for (int ay = 1; ay <= 12; ay++)
                {
                    // Ay koşulunu kontrol et
                    if (!AyKosulunuSaglar(ay)) continue;

                    int gunSayisi = DateTime.DaysInMonth(yil, ay);
                    for (int gun = 1; gun <= gunSayisi; gun++)
                    {
                        DateTime tarih = new DateTime(yil, ay, gun);

                        // Gelecek tarihlerle sınırlama yap
                        if (tarih <= bugun) continue;

                        // Gün asal olmalı
                        if (!AsalMi(gun)) continue;

                        // Tüm koşullar sağlanıyorsa listeye ekle
                        uygunTarihler.Add($"{gun:D2}/{ay:D2}/{yil}");
                    }
                }
            }

            // Sonuçları ekrana yazdır
            Console.WriteLine("Uygun tarihler:");
            foreach (string tarih in uygunTarihler)
            {
                Console.WriteLine(tarih);
            }
        }

        // Günün asal olup olmadığını kontrol eden fonksiyon
        static bool AsalMi(int sayi)
        {
            if (sayi < 2) return false;
            for (int i = 2; i <= Math.Sqrt(sayi); i++)
            {
                if (sayi % i == 0) return false;
            }
            return true;
        }

        // Ayın basamakları toplamının çift olup olmadığını kontrol eden fonksiyon
        static bool AyKosulunuSaglar(int ay)
        {
            int toplam = 0;
            while (ay > 0)
            {
                toplam += ay % 10;
                ay /= 10;
            }
            return toplam % 2 == 0;
        }

        // Yılın koşulunu kontrol eden fonksiyon
        static bool YilKosulunuSaglar(int yil)
        {
            int toplam = 0;
            int temp = yil;

            while (temp > 0)
            {
                toplam += temp % 10;
                temp /= 10;
            }

            return toplam < (yil / 4);
        }
    }


}
    

