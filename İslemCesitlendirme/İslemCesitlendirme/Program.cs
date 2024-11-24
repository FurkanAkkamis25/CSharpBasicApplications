using System;

class Program
{
    //İki tam sayı toplama
    static int Topla(int a, int b)
    {
        return a + b;
    }

    // Üç tam sayı toplama
    static int Topla(int a, int b, int c)
    {
        return a + b + c;
    }

    //Bir dizi (array) tam sayı toplama
    static int Topla(int[] sayilar)
    {
        int toplam = 0;
        foreach (int sayi in sayilar)
        {
            toplam += sayi;
        }
        return toplam;
    }

    static void Main(string[] args)
    {
        Console.WriteLine(Topla(3, 5)); 
        Console.WriteLine(Topla(1, 2, 3)); 
        Console.WriteLine(Topla(new int[] { 1, 2, 3, 4 }));
    }
}