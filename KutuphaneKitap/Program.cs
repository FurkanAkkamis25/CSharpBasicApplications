// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

public class Kutuphane
{
    public string Ad { get; set; }
    public List<Kitap> Kitaplar { get; set; }

    public Kutuphane()
    {
        Kitaplar = new List<Kitap>();
    }

    public void KitapEkle(Kitap kitap)
    {
        Kitaplar.Add(kitap);
    }
}

public class Kitap
{
    public string Baslik { get; set; }
    public string Yazar { get; set; }
}