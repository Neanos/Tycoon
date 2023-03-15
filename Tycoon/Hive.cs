using System;

public class HiveAnimal
{
    public float Price { get; set; }

    public static List<HiveAnimal> animals = new();

    public void UpPrice()
    {
        Price *= 1.5f;
        Console.WriteLine(Price);
    }


    public void Addbee(ref float money)
    {
        if (money >= Price)
        {
            animals.Add(new Bee());
            money -= Price;
            Price += 2;
        }

    }
}
