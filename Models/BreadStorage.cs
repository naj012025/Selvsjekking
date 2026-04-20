using System.Collections.Generic;
namespace Selvsjekk.Models;

public class BreadStorage
{

    //rotet det til pga jeg ikke brukte brød classes skikelig lagde listen som breadstorage ved feil skulle vært bread only.
    public List<Bread> Products { get; set; } = new List<Bread>();

    public void AddProduct(string name, double price, double weight, string type)
    {
        Products.Add(new Bread(name, price, weight, type));
    }

    public void ShowAll()
    {
        foreach (var p in Products)
        {
            Console.WriteLine($"{p.Name} - {p.Price} - {p.Weight} - {p.Type}");
        }
    }

    public double TotalPris()
    {
        return Products.Sum(p => p.Price);
    }

    public double TotalWeight()
    {
        return Products.Sum(p => p.Weight);
    }

}