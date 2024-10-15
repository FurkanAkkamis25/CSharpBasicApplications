using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrisCarpim
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan matris boyutu isteme.
            Console.Write(" Lütfen Matrislerin boyutunu giriniz (NxN için N): ");
            int N = int.Parse(Console.ReadLine());

            // İlk matrisin oluşturulması ve kullanıcıdan alınması
            int[,] matris1 = new int[N, N];
            Console.WriteLine("Birinci matrisin elemanlarını girin:");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write($"matris1[{i},{j}] = ");
                    matris1[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // İkinci matrisin oluşturulması ve kullanıcıdan alınması
            int[,] matris2 = new int[N, N];
            Console.WriteLine("İkinci matrisin elemanlarını girin:");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write($"matris2[{i},{j}] = ");
                    matris2[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Matris çarpımı için sonuç matrisi
            int[,] carpimMatrisi = new int[N, N];

            // Matris çarpımının hesaplanması
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    for (int k = 0; k < N; k++)
                    {
                        carpimMatrisi[i, j] += matris1[i, k] * matris2[k, j];
                    }
                }
            }

            // Çarpım matrisinin ekrana yazdırılması
            Console.WriteLine("Matrislerin çarpımı sonucu:");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(carpimMatrisi[i, j] + "\t");
                }
                Console.WriteLine();
            }

            // Konsol kapanmasın diye bekle
            Console.ReadKey();
        }
    }
}
