using System;
using System.Collections.Generic;

public class Hasta
{
    public string Ad { get; set; }
    public string TCNo { get; set; }
    public Doktor Doktor { get; private set; }

    public Hasta(string ad, string tcNo)
    {
        Ad = ad;
        TCNo = tcNo;
    }

    public void DoktorAtama(Doktor doktor)
    {
        Doktor = doktor;
    }

    public string HastaBilgisi()
    {
        string doktorBilgisi = Doktor != null ? $"Doktor: {Doktor.Ad}" : "Doktor atanmadı.";
        return $"Hasta Adı: {Ad}, TC No: {TCNo}, {doktorBilgisi}";
    }
}

public class Doktor
{
    public string Ad { get; set; }
    public string Brans { get; set; }
    public List<Hasta> Hastalar { get; private set; }

    public Doktor(string ad, string brans)
    {
        Ad = ad;
        Brans = brans;
        Hastalar = new List<Hasta>();
    }

    public void HastaEkle(Hasta hasta)
    {
        Hastalar.Add(hasta);
        hasta.DoktorAtama(this);
    }

    public string DoktorBilgisi()
    {
        string hastaListesi = Hastalar.Count > 0 ? string.Join(", ", Hastalar.ConvertAll(h => h.Ad)) : "Hasta yok.";
        return $"Doktor Adı: {Ad}, Branş: {Brans}, Hastalar: {hastaListesi}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Doktor oluştur
        Doktor doktor1 = new Doktor("Dr. Ahmet", "Kardiyoloji");

        // Hastalar oluştur
        Hasta hasta1 = new Hasta("Ali Yılmaz", "12345678901");
        Hasta hasta2 = new Hasta("Ayşe Demir", "98765432109");

        // Hastaları doktora ekle
        doktor1.HastaEkle(hasta1);
        doktor1.HastaEkle(hasta2);

        // Doktor ve hasta bilgilerini yazdır
        Console.WriteLine(doktor1.DoktorBilgisi());
        Console.WriteLine(hasta1.HastaBilgisi());
        Console.WriteLine(hasta2.HastaBilgisi());
    }
}