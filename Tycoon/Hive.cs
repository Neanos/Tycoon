using System;

public class Hive
{
    public float Price { get; set; }


    public void UpPrice (){
        while (true)
        {
            Price *= 1.5f;

            Console.WriteLine(Price);
        }
    }
}
