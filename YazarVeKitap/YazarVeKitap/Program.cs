// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

public class Yazar
{
    public string Ad { get; set; }
    public string Ulke { get; set; }
    public List<Kitap> Kitaplar { get; set; }

    public Yazar()
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
    public string ISBN { get; set; }
}