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
    Ant a = new();

    int Income = 1;
    float Money = 0;
    int action;


    public void Start()
    {
        incomeTimer.Elapsed += AddIncome;
        incomeTimer.Start();

        while (true)
        {
            if (action == 1)
            {
                Console.ReadLine();
                b.Addbee(ref Money, ref Income);

            }

            if (action == 2)
            {
                Console.ReadLine();
                a.Addant(ref Money, ref Income);

            }
        }

    }

    private void AddIncome(object sender, EventArgs e)
    {
        Console.Clear();
        Money += Income;
        Console.WriteLine("Money:" + Money);
        Console.WriteLine("Income per second:" + Income);
        Console.WriteLine("Bee price:" + b.Price);
        Console.WriteLine("Ant price:" + a.Price);
        Console.WriteLine("Bee amount:" + HiveAnimal.animals.Count);
        string actionS = Console.ReadLine();
        bool lyckad = int.TryParse(actionS, out action);



    }
}
