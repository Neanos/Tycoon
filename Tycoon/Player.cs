using System;
using System.Timers;

public class Player
{
    System.Timers.Timer incomeTimer = new(1000)
    {
        AutoReset = true,
        Enabled = true,
    };

    Bee b = new();
    Goldbee gb = new();
    Ant a = new();
    Larva l = new();
    Goldenbeetle ge = new();

    int Income = 1;
    float Money = 0;
    int action;


    public void Start()
    {
        incomeTimer.Elapsed += AddIncome;
        incomeTimer.Start();

        while (true)
        {
            Console.Clear();
            Console.SetCursorPosition(0, 5);

            //Fångar upp vad spelaren skriver in för handling
            string actionS = Console.ReadLine();
            bool lyckad = int.TryParse(actionS, out action);

            if (!lyckad) continue;
            
            if (action == 1)
            {
                Console.ReadLine();
                b.Addbee(ref Money, ref Income);

            }

            
            if (action == 2)
            {
                Console.ReadLine();
                gb.Addbee(ref Money, ref Income);

            }

            if (action == 3)
            {
                Console.ReadLine();
                a.Addant(ref Money, ref Income);

            }

            if (action == 4)
            {
                Console.ReadLine();
                l.Addlarva(ref Money, ref Income);

            }
             if (action == 5)
            {
                Console.ReadLine();
                ge.Addgoldenbeetle(ref Money, ref Income);

            }
        }

    }
    //skriver ut instruktioner och information för spelaren
    private void AddIncome(object sender, EventArgs e)
    {
        var prev = Console.GetCursorPosition();
        Console.SetCursorPosition(0, 0);
        Money += Income;
        Console.WriteLine("Money:" + Money);
        Console.WriteLine("Income per second:" + Income);
        Console.WriteLine("Write the number coresponding with what you want to buy.");
        Console.WriteLine("1) Bee price:" + b.Price);
        Console.WriteLine("2) Goldbee price:" + gb.Price);
        Console.WriteLine("3) Ant price:" + a.Price);
        Console.WriteLine("4) Larva price:" + l.Price);
        Console.WriteLine("Amount of animals:" + Animal.animals.Count);
        


    }
}
