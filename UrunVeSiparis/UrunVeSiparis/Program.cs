// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

public class Urun
{
    public string Ad { get; set; }
    public int Fiyat { get; set; }
}

public class Siparis
{
    public DateTime Tarih { get; set; }
    public decimal Toplam { get; set; }
    public List<Urun> UrunBilgisi { get; set; }

    public Siparis()
    {
        UrunBilgisi = new List<Urun>();
    }
}
