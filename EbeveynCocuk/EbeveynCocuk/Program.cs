// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

public class Ebeveyn
{
    public string Ad { get; set; }
    public int Yas { get; set; }
    public List<Cocuk> Cocuklar { get; set; }

    public Ebeveyn()
    {
        Cocuklar = new List<Cocuk>();
    }

    public void CocukEkle(Cocuk cocuk)
    {
        Cocuklar.Add(cocuk);
        cocuk.EbeveynAtama(this); // Çocuğun ebeveynini ayarla
    }
}

public class Cocuk
{
    public string Ad { get; set; }
    public int Yas { get; set; }
    public Ebeveyn Ebeveyn { get; private set; }

    public void EbeveynAtama(Ebeveyn ebeveyn)
    {
        Ebeveyn = ebeveyn;
    }
}