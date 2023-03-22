using System;

public class Ant : Animal
{
    public Ant()
    {
        Price = 20;
    }

    public void Addant(ref float money, ref int Income)
    {
        if (money >= Price)
        {
            animals.Add(new Ant());
            money -= Price;
            Price *= 1.5f;
            Price = (float)Math.Round(Price, 2);
            Income += 2;

        }

        if (money <= Price)
        {
            Console.WriteLine("You don't have enough money, try again later.");

        }

    }
}
