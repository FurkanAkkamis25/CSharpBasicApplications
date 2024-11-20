// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

public class Ev
{
    public string Ad { get; set; }
    public List<Oda> Odalar { get; set; }

    public Ev()
    {
        Odalar = new List<Oda>();
    }

    public void OdaEkle(Oda oda)
    {
        Odalar.Add(oda);
    }
}

public class Oda
{
    public string Boyut { get; set; }
    public string Tip { get; set; }
}
