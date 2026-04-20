namespace Selvsjekk.Models;

public class Bread
{
    public string? Name { get; set; }

    public double Price { get; set; }

    public double Weight { get; set; }

    public string Type { get; set; }

    public Bread(string? name, double price, double weight, string type)
    {
        Name = name;
        Price = price;
        Weight = weight;
        Type = type;
    }


}