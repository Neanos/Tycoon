using System;


public class Goldbee : Bee
{
    public Goldbee()
    {
        Price = 1000;
    }

    public void Addgoldbee(ref float money, ref int Income)
    {
        if (money >= Price)
        {
            animals.Add(new Bee());
            money -= Price;
            Price *= 1.5f;
            Price = (float)Math.Round(Price, 2);
            Income += 50;

        }

         if (money <= Price)
        {
            Console.WriteLine("You don't have enough money, try again later.");

        }
    }
}
