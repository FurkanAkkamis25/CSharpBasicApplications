using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsalSayiToplami
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan hangi sayıya kadar toplayacağımızı bilmek için değer isteme.
            Console.Write("N değerini girin: ");
            int N = int.Parse(Console.ReadLine());

            int toplam = 0;

            for (int i = 2; i <= N; i++)
            {
                if (AsalMi(i))
                {
                    toplam += i; // Asal olan sayıyı toplama ekle
                }
            }

            Console.WriteLine($"1'den {N}'e kadar olan asal sayıların toplamı: {toplam}");
            Console.ReadKey(); // Konsol kapanmasın diye bekletme
        }

        // Asal sayıyı kontrol eden fonksiyon
        static bool AsalMi(int sayi)
        {
            if (sayi < 2)
                return false;

            for (int i = 2; i * i <= sayi; i++)
            {
                if (sayi % i == 0)
                    return false; // Eğer sayı herhangi bir i'ye bölünüyorsa asal değildir
            }
            return true; // Sayı asal ise true döner
        }
    }
}
