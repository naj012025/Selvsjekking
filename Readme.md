Forskjelling info for megselv
###Classes###
Prøvde og lage min egen class via fiskepinner etc:

//for og hente fra classe og gjøre dette product class synnlig så må jeg få product tik og eksistere via koden under.
Products products = new Products();
FindusFiskePinner findusFiskePinner = new FindusFiskePinner();
Console.WriteLine(findusFiskePinner);

//Har Hardcodet Product med Fisk og en pris som er ganget sammen via totalvalue som har en return.
/_ Console.WriteLine($"The Product {} Has a Total Value of {Products.TotalValue}"); _/
/\* product.Name = "FiskePinner";
product.Price = 25;
product.Count = 10;

\*/
//Console.WriteLine($"The Name {product.Name} Costs You have {product.Count} in stock total value {product.TotalValue}");

####END####

####Creating Methods####

Tester freecode camp på nytt igjen via og lage mine egne Methods():

Finnes to måter og gjøre en class call i program.cs filen en er for en public static class som trenger kun se exempel under:

Exempel på class med med object class dvs en ting for exempel en Goblin se exempel på random tall som jeg lagde først her : Program.cs: using Selvsjekk.Classes;

RandomNumberGen rng = new RandomNumberGen();
rng.DisplayRandomNumbers();

Classes her:
namespace Selvsjekk.Classes;

public class RandomNumberGen
{

    public void DisplayRandomNumbers()
    {
        Random random = new Random();
        //Ikke Glem Int eller en number variable for exempel double i i for loopen eller eksisterer ikke i.
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"{random.Next(1, 100)} ");

        }

        Console.WriteLine();
    }

}

Static class exempel:
using Selvsjekk.Classes;
##Programm.cs##
//hvis 10 tall ut ifra class static blueprinten jeg lagde trengte kun en linje kode for og kjøre der du husker feil hele tiden.
RandomNumberGen.DisplayRandomNumbers();

##Staticclassfilen##

namespace Selvsjekk.Classes;

public class RandomNumberGen
{
public static void DisplayRandomNumbers()
{
Random random = new Random();

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(random.Next(1, 101));
        }
    }

}

public class Fiskepinner
{
public string Name { get; set; } = "Findus";

        public double Pris { get; set; } = 24.99;

        public double Vekt { get; set; } = 150;

    }

// her skaeper jeg objektet som jeg lagde i Findusobject.cs og consolewrite ut hardcoded name pris vekt etc.
Fiskepinner test = new Fiskepinner();
Console.WriteLine(test.Name);
Console.WriteLine(test.Pris);
Console.WriteLine(test.Vekt);
