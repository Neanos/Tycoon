using System;

public class Ant : HiveAnimal
{
     public Ant()
    {
        Price = 20;
    }

     public void Addant(ref float money , ref int Income)
    {
        if (money >= Price)
        {
            animals.Add(new Ant());
            money -= Price;
            Price += 5;
            Income += 1;
            
        }

        if (money <= Price)
        {
            Console.WriteLine("You don't have enough money, try again later.");
            
        }

    }
}
