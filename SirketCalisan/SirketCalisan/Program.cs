// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

public class Sirket
{
    public string Ad { get; set; }
    public List<Calisan> Calisanlar { get; set; }

    public Sirket()
    {
        Calisanlar = new List<Calisan>();
    }

    public void CalisanEkle(Calisan calisan)
    {
        Calisanlar.Add(calisan);
    }
}

public class Calisan
{
    public string Ad { get; set; }
    public string Pozisyon { get; set; }

    public string CalisanBilgisi()
    {
        return $"{Ad} - {Pozisyon}";
    }
}