using Selvsjekk.Models;

class Program
{
    static void Main()
    {
        FiskStorage fiskStorage = new FiskStorage();

        fiskStorage.AddProduct("torsk", 24231, 200);
        fiskStorage.AddProduct("Testfisk2", 20.00, 250);
        fiskStorage.AddProduct("Randoom", 49.90, 427);

        fiskStorage.ShowAll();

        Console.WriteLine($"Total Pris Av alle Producter: {fiskStorage.TotalPris()} kr");
        Console.WriteLine($"Total Vekt Av Alle Producter: {fiskStorage.TotalVekt()}g");

        Console.WriteLine("\n####BreadList####\n");
        BreadStorage breadStorage = new BreadStorage();

        breadStorage.AddProduct("WhiteBread", 29.90, 500, "White");
        breadStorage.AddProduct("BrownBread", 34.90, 500, "Brown");
        breadStorage.AddProduct("FancyBread", 89, 500, "Brown/nutty");

        breadStorage.ShowAll();

        Console.WriteLine("\n####Bread####\n");

        Console.WriteLine($"Total Price: {breadStorage.TotalPris()} kr");
        Console.WriteLine($"Total Vekt: {breadStorage.TotalWeight()} g");


    }
}