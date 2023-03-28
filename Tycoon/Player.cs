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
            string actionS = Console.ReadLine();
            bool lyckad = int.TryParse(actionS, out action);

            if (!lyckad) continue;

            if (action == 1)
            {
                Console.ReadLine();
                gb.Addbee(ref Money, ref Income);

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
        var prev = Console.GetCursorPosition();
        Console.SetCursorPosition(0, 0);
        Money += Income;
        Console.WriteLine("Money:" + Money);
        Console.WriteLine("Income per second:" + Income);
        Console.WriteLine("Bee price:" + b.Price);
        Console.WriteLine("Ant price:" + a.Price);
        Console.WriteLine("Goldbee price:" + gb.Price);
        Console.WriteLine("Amount of animals:" + Animal.animals.Count);
        Console.SetCursorPosition(0, 6);
        Console.SetCursorPosition(prev.Left, prev.Top);



    }
}
