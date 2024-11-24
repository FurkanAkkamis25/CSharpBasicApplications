using System;
using System.Collections.Generic;

class NotSistemi
{
    private Dictionary<string, int> dersNotlari = new Dictionary<string, int>();

    public int this[string ders]
    {
        get
        {
            if (dersNotlari.ContainsKey(ders))
            {
                return dersNotlari[ders];
            }
            throw new Exception("Hata: Ders bulunamadı!");
        }
        set
        {
            dersNotlari[ders] = value;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        NotSistemi notlar = new NotSistemi();
        notlar["Matematik"] = 90;
        notlar["Fizik"] = 85;

        Console.WriteLine("Matematik: " + notlar["Matematik"]); // 90

        try
        {
            Console.WriteLine("Kimya: " + notlar["Kimya"]);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message); // Hata: Ders bulunamadı!
        }
    }
}