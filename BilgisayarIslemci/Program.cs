public class Islemci
{
    public int Cekirdekler { get; set; }
    public int Frekans { get; set; } // MHz cinsinden

    public Islemci(int cekirdekler, int frekans)
    {
        Cekirdekler = cekirdekler;
        Frekans = frekans;
    }

    public string IslemciBilgisi()
    {
        return $"İşlemci Çekirdek Sayısı: {Cekirdekler}, Frekans: {Frekans} MHz";
    }
}

public class Bilgisayar
{
    public string Model { get; set; }
    public Islemci Islemci { get; private set; }

    public Bilgisayar(string model, int cekirdekler, int frekans)
    {
        Model = model;
        Islemci = new Islemci(cekirdekler, frekans);
    }

    public string IslemciOlustur()
    {
        return $"Bilgisayar Modeli: {Model}, {Islemci.IslemciBilgisi()}";
    }
}