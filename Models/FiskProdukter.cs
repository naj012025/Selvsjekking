namespace Selvsjekk.Models;

public class FiskeProdukter
{
    public string? Name { get; set; }
    public double Pris { get; set; }
    public int Vekt { get; set; }

    public int Antall { get; set; }


    public FiskeProdukter(string name, double pris, int vekt, int antall)
    {
        Name = name;
        Pris = pris;
        Vekt = vekt;
        Antall = antall;
    }
}

