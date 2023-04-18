using System;

public class Goldenbeetle : Animal
{
    public Goldenbeetle()
    {
        Price = 2000;
    }
    public void Addgoldenbeetle(ref float money, ref int Income)
    {
        if (money >= Price)
        {
            animals.Add(new Goldenbeetle());
            money -= Price;
            Price *= 1.5f;
            Price = (float)Math.Round(Price, 2);
            Income += 100;

        }
    }
}
