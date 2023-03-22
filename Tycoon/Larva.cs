using System;

namespace Tycoon;

public class Larva : Animal
{
    public Larva()
    {
        Price = 30;
    }

    public void Addlarva(ref float money, ref int Income)
    {
        if (money >= Price)
        {
            animals.Add(new Larva());
            money -= Price;
            Price *= 1.5f;
            Price = (float)Math.Round(Price, 2);
            Income += 3;

        }

        if (money <= Price)
        {
            Console.WriteLine("You don't have enough money, try again later.");

        }

    }
}
