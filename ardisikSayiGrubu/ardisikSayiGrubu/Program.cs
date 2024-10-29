using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ardisikSayiGrubu
{
    class Program
    {
        static void Main(string[] args)
        {
            
                List<int> numbers = new List<int>();
                int input;

                Console.WriteLine("Bir dizi tamsayı girin (bitirmek için 0 girin):");

                // Kullanıcıdan sayıları al
                while (true)
                {
                    Console.Write("Sayı: ");
                    input = int.Parse(Console.ReadLine());

                    if (input == 0) break; // 0 girildiğinde döngüyü sonlandır
                    numbers.Add(input);
                }

                // Eğer liste boşsa işlem yapma
                if (numbers.Count == 0)
                {
                    Console.WriteLine("Hiçbir sayı girilmedi.");
                }
                else
                {
                    // Listeyi sıralıyoruz
                    numbers.Sort();
                    List<string> ranges = FindConsecutiveRanges(numbers);

                    // Sonuçları yazdır
                    Console.WriteLine("\nArdışık sayı grupları:");
                    Console.WriteLine(string.Join(", ", ranges));
                }

                // Program kapanmadan önce bir tuşa basılmasını bekle
                Console.WriteLine("\nÇıkmak için bir tuşa basın...");
                Console.ReadLine();
            }

            // Ardışık sayı gruplarını bulmak için fonksiyon
            static List<string> FindConsecutiveRanges(List<int> sortedNumbers)
            {
                List<string> ranges = new List<string>();
                int start = sortedNumbers[0];
                int end = start;

                for (int i = 1; i < sortedNumbers.Count; i++)
                {
                    if (sortedNumbers[i] == end + 1)
                    {
                        // Sayı ardışık ise, "end"i güncelle
                        end = sortedNumbers[i];
                    }
                    else
                    {
                        // Ardışıklık sona erdiğinde grubu ekleyip baştan başla
                        AddRange(ranges, start, end);
                        start = sortedNumbers[i];
                        end = start;
                    }
                }

                // Son grubu ekle
                AddRange(ranges, start, end);

                return ranges;
            }

            // Başlangıç ve bitişe göre grubu diziye ekle
            static void AddRange(List<string> ranges, int start, int end)
            {
                if (start == end)
                    ranges.Add(start.ToString());
                else
                    ranges.Add($"{start}-{end}");
            }
        }
    }
    

