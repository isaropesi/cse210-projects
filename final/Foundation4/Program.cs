using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running running = new Running
        {
            Date = new DateTime(2022, 11, 3),
            LengthInMinutes = 30,
            Distance = 3.0
        };
        activities.Add(running);

        Cycling cycling = new Cycling
        {
            Date = new DateTime(2022, 11, 3),
            LengthInMinutes = 30,
            Speed = 6.0
        };
        activities.Add(cycling);

        Swimming swimming = new Swimming
        {
            Date = new DateTime(2022, 11, 3),
            LengthInMinutes = 30,
            Laps = 60
        };
        activities.Add(swimming);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }

        Console.ReadLine();
    }
}