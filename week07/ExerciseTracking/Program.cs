using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running("17 Feb 2026", 30, 3.0));
        activities.Add(new Cycling("17 Feb 2026", 30, 12.0));
        activities.Add(new Swimming("17 Feb 2026", 30, 40));

        foreach (Activity a in activities)
        {
            Console.WriteLine(a.GetSummary());
        }
    }
}
