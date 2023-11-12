using System;
using System.Collections.Generic;

public class Team
{
    private List<IWorker> workers = new List<IWorker>();

    public void AddWorker(IWorker worker)
    {
        workers.Add(worker);
    }

    public void Work(House house)
    {
        Console.WriteLine("Строительство началось...");
        foreach (var worker in workers)
        {
            worker.Work();
        }
        Console.WriteLine("Строительство завершено!");
        house.Show();
    }
}
