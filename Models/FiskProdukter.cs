namespace Selvsjekk.Models;

public class FiskProdukter
{
    public string? Name { get; set; }

    public double Pris { get; set; }

    public int Vekt { get; set; }

    public FiskProdukter(string? name, double pris, int vekt)
    {
        Name = name;

        Pris = pris;

        Vekt = vekt;



    }


}