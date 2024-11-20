// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;

public class Ogrenci
{
    public string Ad { get; set; }
    public int Yas { get; set; }

    public Ogrenci(string ad, int yas)
    {
        Ad = ad;
        Yas = yas;
    }

    public string OgrenciBilgisi()
    {
        return $"Öğrenci Adı: {Ad}, Yaş: {Yas}";
    }
}

public class Okul
{
    public string Ad { get; set; }
    public List<Ogrenci> Ogrenciler { get; private set; }

    public Okul(string ad)
    {
        Ad = ad;
        Ogrenciler = new List<Ogrenci>();
    }

    public void OgrenciOlustur(string ad, int yas)
    {
        Ogrenciler.Add(new Ogrenci(ad, yas));
    }

    public string OkulBilgisi()
    {
        string bilgi = $"Okul Adı: {Ad}\nÖğrenciler:\n";
        foreach (var ogrenci in Ogrenciler)
        {
            bilgi += "- " + ogrenci.OgrenciBilgisi() + "\n";
        }
        return bilgi;
    }
}