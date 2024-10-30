using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\nChoose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            
            string choice = Console.ReadLine();
            if (choice == "4") break;

            Console.Write("Enter duration in seconds: ");
            int duration;
            if (!int.TryParse(Console.ReadLine(), out duration))
            {
                Console.WriteLine("Please enter a valid number.");
                continue;
            }

            Activity activity = choice switch
            {
                "1" => new BreathingActivity(duration),
                "2" => new ReflectingActivity(duration),
                "3" => new ListingActivity(duration),
                _ => null
            };

            if (activity != null)
                activity.Run();
            else
                Console.WriteLine("Invalid choice. Please try again.");
        }

        Console.WriteLine("Goodbye!");
    }
}
