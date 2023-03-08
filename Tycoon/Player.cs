using System;
using System.Timers;

public class Player
{
    System.Timers.Timer incomeTimer = new(1000)
    {
        AutoReset = true,
        Enabled = true,
    };


    int Income = 1;
    float Money = 0;

    public void Start()
    {
        incomeTimer.Elapsed += AddIncome;
        incomeTimer.Start();

        while (true)
        {
            Console.ReadLine();
        }
    }

    private void AddIncome(object sender, EventArgs e)
    {
        Console.Clear();
        Money += Income;
        Console.WriteLine(Money);
    }
}
