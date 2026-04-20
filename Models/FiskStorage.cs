using System.Collections.Generic;
namespace Selvsjekk.Models;

public class FiskStorage
{
    public List<FiskProdukter> Products { get; set; } = new List<FiskProdukter>();

    public void AddProduct(string name, double pris, int vekt)
    {
        Products.Add(new FiskProdukter(name, pris, vekt));
    }


    public void ShowAll()
    {
        foreach (var p in Products)
        {
            Console.WriteLine($"{p.Name} - {p.Pris} - {p.Vekt}");
        }
    }

    //disse 2 under er LINQ for gi meg total pris og vekt i denne listen.
    public double TotalPris()
    {
        return Products.Sum(p => p.Pris);
    }

    public int TotalVekt()
    {
        return Products.Sum(p => p.Vekt);
    }
}
