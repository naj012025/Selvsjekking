using Selvsjekk.Models;

class Program
{
    static void Main()
    {
        FiskStorage lager = new FiskStorage();

        lager.AddProduct("torsk", 24231, 200);
        lager.AddProduct("Testfisk2", 20.00, 250);
        lager.AddProduct("Randoom", 49.90, 427);

        lager.ShowAll();

        Console.WriteLine($"Total Pris Av alle Producter: {lager.TotalPris()} kr");
        Console.WriteLine($"Total Vekt Av Alle Producter: {lager.TotalVekt()}g");


    }
}