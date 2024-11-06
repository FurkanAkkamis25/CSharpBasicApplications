using System;

public class KiralikArac
{
    // Özellikler
    public string Plaka { get; set; }
    public decimal GunlukUcret { get; set; }
    public bool MusaitMi { get; private set; }

    // Yapıcı Metot
    public KiralikArac(string plaka, decimal gunlukUcret)
    {
        Plaka = plaka;
        GunlukUcret = gunlukUcret;
        MusaitMi = true; // Varsayılan olarak araç müsait
    }

    // Aracı Kiralama Metodu
    public void AraciKirala()
    {
        if (MusaitMi)
        {
            MusaitMi = false;  // Araç artık müsait değil
            Console.WriteLine($"{Plaka} plaka numaralı araç kiralandı.");
        }
        else
        {
            Console.WriteLine($"{Plaka} plaka numaralı araç şu anda kiralanmış durumda.");
        }
    }

    // Aracı Teslim Etme Metodu
    public void AraciTeslimEt()
    {
        if (!MusaitMi)
        {
            MusaitMi = true;  // Araç artık müsait
            Console.WriteLine($"{Plaka} plaka numaralı araç teslim edildi.");
        }
        else
        {
            Console.WriteLine($"{Plaka} plaka numaralı araç zaten müsait.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Kiralık araç oluşturma
        KiralikArac arac = new KiralikArac("34ABC123", 200);

        // Araç kiralama işlemi
        arac.AraciKirala();  // Araç kiralandı

        // Tekrar kiralamaya çalışmak
        arac.AraciKirala();  // Araç zaten kiralanmış

        // Araç teslim etme işlemi
        arac.AraciTeslimEt();  // Araç teslim edildi

        // Araç teslim edildikten sonra tekrar teslim etmeye çalışmak
        arac.AraciTeslimEt();  // Araç zaten müsait
    }
}