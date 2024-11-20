// See https://aka.ms/new-console-template for more information
public class Calisan
{
    public string Ad { get; set; }
    public string Pozisyon { get; set; }
    public Departman Departman { get; set; }

    public void DepartmanAtama(Departman departman)
    {
        Departman = departman;
    }
}

public class Departman
{
    public string Ad { get; set; }
    public string Lokasyon { get; set; }
}
