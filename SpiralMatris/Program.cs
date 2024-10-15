using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpiralMatris
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan matris boyutu alma ve matris oluşturma.
            Console.Write(" Lütfen Matris boyutunu giriniz (NxN için N): ");
            int N= int.Parse(Console.ReadLine());

            int[,] matris = new int[N, N];

            // Spiral matrisi doldurma
            int deger = 1;
            int sol = 0, sag = N - 1, ust = 0, alt = N - 1;

            while (deger <= N * N)
            {
                // Sağa git (üst satır boyunca)
                for (int i = sol; i <= sag; i++)
                {
                    matris[ust, i] = deger++;
                }
                ust++;

                // Aşağı git (sağ sütun boyunca)
                for (int i = ust; i <= alt; i++)
                {
                    matris[i, sag] = deger++;
                }
                sag--;

                // Sola git (alt satır boyunca)
                for (int i = sag; i >= sol; i--)
                {
                    matris[alt, i] = deger++;
                }
                alt--;

                // Yukarı git (sol sütun boyunca)
                for (int i = alt; i >= ust; i--)
                {
                    matris[i, sol] = deger++;
                }
                sol++;
            }

            // Spiral matrisi yazdırma
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(matris[i, j].ToString("D2") + " ");
                }
                Console.WriteLine();
            }

            // Konsolun kapanmasını engellemek için.
            Console.WriteLine("Devam etmek için bir tuşa basın...");
            Console.ReadKey(); 
        }
    }
}