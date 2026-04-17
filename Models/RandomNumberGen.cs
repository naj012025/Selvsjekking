namespace Selvsjekk.Models;

public class Fisk
{
    /* public string? Name { get; set; }

    public double Price { get; set; }

    public double Count { get; set; } */

    public static void DisplayRandomNumbers()
    {
        Random random = new Random();
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(random.Next(1, 101));

        }



    }


}