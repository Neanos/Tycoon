using System;


public class Bee : HiveAnimal
{
    public Bee()
    {
        Price = 10;
    }

     public void Addbee(ref float money , ref int Income)
    {
        if (money >= Price)
        {
            animals.Add(new Bee());
            money -= Price;
            Price += 2;
            Income += 1;
            
        }

        if (money <= Price)
        {
            Console.WriteLine("You don't have enough money, try again later.");
            
        }

    }

}

