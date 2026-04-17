namespace Selvsjekk.Models;

public class Fruit
{
    public static void Rng()
    {
        Random random = new Random();

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(random.Next(1, 21));
        }
    }
}