using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sayiKontrol
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                // Kullanıcıdan tam sayı dizisi alalım
                Console.Write("Dizi elemanlarını aralarında boşluk bırakarak girin: ");
                string[] inputs = Console.ReadLine().Split(' ');
                int[] numbers = Array.ConvertAll(inputs, int.Parse);

                // Diziyi sıralayalım
                Array.Sort(numbers);
                Console.WriteLine("Sıralanmış dizi: " + string.Join(" ", numbers));

                // Kullanıcıdan aramak istediği sayıyı alalım
                Console.Write("Aramak istediğiniz sayıyı girin: ");
                int target = int.Parse(Console.ReadLine());

                // İkili arama algoritması ile sayıyı arayalım
                bool found = BinarySearch(numbers, target);
                if (found)
                    Console.WriteLine($"{target} sayısı dizide bulundu.");
                else
                    Console.WriteLine($"{target} sayısı dizide bulunamadı.");
                Console.WriteLine("\nÇıkmak için bir tuşa basın...");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: " + ex.Message);
            }
        }

        // İkili arama algoritması
        static bool BinarySearch(int[] array, int target)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (array[mid] == target)
                    return true;
                else if (array[mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return false;
        }
            
           
        }
    }

