using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uzayMadencisi
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] energyCosts = {
            { 1, 3, 1, 2 },
            { 2, 1, 4, 1 },
            { 1, 1, 1, 1 },
            { 3, 2, 1, 0 }
        };

            int minEnergy = FindMinEnergyPath(energyCosts);
            Console.WriteLine("En az enerji harcayan yolun maliyeti: " + minEnergy);
            // Kullanıcının bir tuşa basmasını bekle
            Console.WriteLine("Devam etmek için bir tuşa basın...");
            Console.ReadKey(); // Kullanıcı bir tuşa bastığında devam eder
        }

        static int FindMinEnergyPath(int[,] energyCosts)
        {
            int n = energyCosts.GetLength(0);
            int[,] dp = new int[n, n];

            // İlk hücre için başlangıç maliyeti
            dp[0, 0] = energyCosts[0, 0];

            // İlk satırı doldur
            for (int j = 1; j < n; j++)
            {
                dp[0, j] = dp[0, j - 1] + energyCosts[0, j];
            }

            // İlk sütunu doldur
            for (int i = 1; i < n; i++)
            {
                dp[i, 0] = dp[i - 1, 0] + energyCosts[i, 0];
            }

            // DP tablosunu doldur
            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    dp[i, j] = energyCosts[i, j] + Math.Min(
                        Math.Min(dp[i - 1, j], dp[i, j - 1]), // yukarıdan veya soldan gelme
                        dp[i - 1, j - 1]                       // çaprazdan gelme
                    );
                }
            }

            return dp[n - 1, n - 1]; // Hedef hücreye ulaşmanın maliyeti
        }
    }
}
    

