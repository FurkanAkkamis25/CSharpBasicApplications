using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medyanOrtalama
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            int input;

            Console.WriteLine("Pozitif tamsayılar girin (Sonucu görmek için 0 girin):");

            // Kullanıcıdan sayıları alıyoruz
            while (true)
            {
                Console.Write("Sayı: ");
                input = int.Parse(Console.ReadLine());

                if (input == 0) break; // Kullanıcı 0 girdiğinde döngüyü kırıyoruz

                if (input > 0)
                    numbers.Add(input);
                else
                    Console.WriteLine("Lütfen pozitif bir sayı girin.");
            }

            // Eğer liste boşsa işlem yapma
            if (numbers.Count == 0)
            {
                Console.WriteLine("Hiçbir pozitif sayı girilmedi.");
            }
            else
            {
                // Ortalama hesapla
                double average = numbers.Average();

                // Medyan hesapla
                numbers.Sort();
                double median;
                int n = numbers.Count;
                if (n % 2 == 1)
                    median = numbers[n / 2];
                else
                    median = (numbers[(n - 1) / 2] + numbers[n / 2]) / 2.0;

                // Sonuçları yazdır
                Console.WriteLine($"\nOrtalama: {average}");
                Console.WriteLine($"Medyan: {median}");
            }

            // Program kapanmadan önce bir tuşa basılmasını bekle
            Console.WriteLine("\nÇıkmak için bir tuşa basın...");
            Console.ReadLine();
        }
    }
}
