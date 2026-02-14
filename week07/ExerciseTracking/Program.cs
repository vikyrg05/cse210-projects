using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running run = new Running("03 Nov 2022", 30, 5.0);
        Cycling cycle = new Cycling("04 Nov 2022", 45, 20.0);
        Swimming swim = new Swimming("05 Nov 2022", 40, 30);

        activities.Add(run);
        activities.Add(cycle);
        activities.Add(swim);

        double totalDistance = 0;
        int totalMinutes = 0;

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());

            totalDistance += activity.GetDistance();
            totalMinutes += activity.GetMinutes();
        }

        Console.WriteLine();
        Console.WriteLine("----- Overall Summary -----");
        Console.WriteLine($"Total Time: {totalMinutes} minutes");
        Console.WriteLine($"Total Distance: {totalDistance:F2} km");
        Console.WriteLine($"Average Speed: {(totalDistance / totalMinutes) * 60:F2} kph");
    }
}