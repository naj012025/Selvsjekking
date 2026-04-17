using Selvsjekk.Models;

Fisk.DisplayRandomNumbers();
Console.WriteLine("Frukt under her\n");
Fruit.Rng();
Console.WriteLine("BREAK");

FiskeProdukter fisk = new FiskeProdukter("Findus", 39.90, 150, 25);

Console.WriteLine($"Produkt navnet: {fisk.Name}\nkoster: {fisk.Pris}vkr\nSingle produkt vekt er: {fisk.Vekt}g\nDu har {fisk.Antall} på lager.");

for (int i = 0; i < 10; i++)
{

    Random random = new Random();
    Console.WriteLine(random.NextDouble() * (1.0 - 0.1) + 0.1);
}

