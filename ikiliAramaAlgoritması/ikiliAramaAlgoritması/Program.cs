using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ikiliAramaAlgoritması
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan dizinin boyutunu al
            Console.Write("Dizinin boyutunu girin: ");
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            // Kullanıcıdan dizinin elemanlarını al
            Console.WriteLine("Dizinin elemanlarını girin:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Eleman {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            // Diziyi sıralama
            Array.Sort(numbers);
            Console.WriteLine("Sıralı Dizi: " + string.Join(", ", numbers));

            // Kullanıcıdan aranacak sayıyı al
            Console.Write("Aramak istediğiniz sayıyı girin: ");
            int searchNumber = int.Parse(Console.ReadLine());

            // İkili arama ile sayının dizide olup olmadığını kontrol et
            int index = BinarySearch(numbers, searchNumber);

            // Sonucu ekrana yazdır
            if (index != -1)
            {
                Console.WriteLine($"{searchNumber} sayısı dizide mevcut, indeks: {index}.");
            }
            else
            {
                Console.WriteLine($"{searchNumber} sayısı dizide mevcut değil.");
            }

            // Kullanıcının bir tuşa basmasını bekle
            Console.WriteLine("Devam etmek için bir tuşa basın...");
            Console.ReadKey();
        }

        static int BinarySearch(int[] arr, int target)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                // Hedef sayıyı bulduysak
                if (arr[mid] == target)
                {
                    return mid;
                }
                // Hedef sayıya göre sol veya sağa hareket et
                if (arr[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            // Hedef sayı bulunamazsa -1 döndür
            return -1;
        }
    }
    }

