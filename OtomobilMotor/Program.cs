// See https://aka.ms/new-console-template for more information
public class Motor
{
    public int Güç { get; set; }
    public string Tip { get; set; }

    public Motor(int güç, string tip)
    {
        Güç = güç;
        Tip = tip;
    }

    public string MotorBilgisi()
    {
        return $"Motor Gücü: {Güç}, Tip: {Tip}";
    }
}

public class Otomobil
{
    public string Marka { get; set; }
    public Motor Motor { get; private set; }

    public Otomobil(string marka, int motorGüç, string motorTip)
    {
        Marka = marka;
        Motor = new Motor(motorGüç, motorTip);
    }

    public string MotorOlustur()
    {
        return $"Otomobil Markası: {Marka}, {Motor.MotorBilgisi()}";
    }
}