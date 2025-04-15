using System;

class Program
{
    static void Main(string[] args)
    {
        Running R1 = new Running("02 Nov 2022", 25, 3.4);
        Console.WriteLine(R1.GetDistance());
        Console.WriteLine(R1.GetSpeed());
        Console.WriteLine(R1.GetPace());
        Console.WriteLine();
        Console.WriteLine();

        Swimming S1 = new Swimming("02 Nov 2024", 40, 2.4);
        Console.WriteLine(S1.GetDistance());
        Console.WriteLine(S1.GetSpeed());
        Console.WriteLine(S1.GetPace());
        Console.WriteLine();
        Console.WriteLine();

        Cycling C1 = new Cycling("02 Nov 2012", 30, 8.5);
        Console.WriteLine(C1.GetDistance());
        Console.WriteLine(C1.GetSpeed());
        Console.WriteLine(C1.GetPace());

        List<Activity> _activities = new List<Activity>();
        _activities.Add(R1);
        _activities.Add(S1);
        _activities.Add(C1);

        foreach (Activity activity in _activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}

