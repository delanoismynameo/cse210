using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Creating activities
        Activity running = new Running("03 Nov 2022", 30, 4.8); // Distance in km
        Activity cycling = new Cycling("03 Nov 2022", 40, 25.0); // Speed in kph
        Activity swimming = new Swimming("03 Nov 2022", 30, 20); // Laps in the pool

        // Storing activities in a list
        List<Activity> activities = new List<Activity> { running, cycling, swimming };

        // Displaying summaries
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
