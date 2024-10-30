using System;

public class MainClass
{
    public static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        bool running = true;

        Console.WriteLine("Welcome to the Eternal Quest Game!");

        while (running)
        {
            Console.WriteLine("\nChoose an option:");
            Console.WriteLine("1. Display Player Info");
            Console.WriteLine("2. List All Goals");
            Console.WriteLine("3. Add a New Goal");
            Console.WriteLine("4. Record an Event for a Goal");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    goalManager.DisplayPlayerInfo();
                    break;

                case "2":
                    goalManager.ListGoalNames();
                    break;

                case "3":
                    CreateNewGoal(goalManager);
                    break;

                case "4":
                    RecordGoalEvent(goalManager);
                    break;

                case "5":
                    goalManager.SaveGoals();
                    Console.WriteLine("Goals have been saved.");
                    break;

                case "6":
                    goalManager.LoadGoals();
                    Console.WriteLine("Goals have been loaded.");
                    break;

                case "7":
                    running = false;
                    Console.WriteLine("Thank you for playing Eternal Quest!");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    private static void CreateNewGoal(GoalManager goalManager)
    {
        Console.WriteLine("\nChoose a goal type to create:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        string typeChoice = Console.ReadLine();
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter goal points: ");
        int points = int.Parse(Console.ReadLine());

        Goal newGoal = null;

        switch (typeChoice)
        {
            case "1": // Simple Goal
                newGoal = new SimpleGoal(name, description, points);
                break;

            case "2": // Eternal Goal
                newGoal = new EternalGoal(name, description, points);
                break;

            case "3": // Checklist Goal
                Console.Write("Enter target count for completion: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points for completing the checklist goal: ");
                int bonus = int.Parse(Console.ReadLine());
                newGoal = new ChecklistGoal(name, description, points, target, bonus);
                break;

            default:
                Console.WriteLine("Invalid choice. Returning to main menu.");
                return;
        }

        goalManager.CreateGoal(newGoal);
        Console.WriteLine($"Goal '{name}' created successfully!");
    }

    private static void RecordGoalEvent(GoalManager goalManager)
    {
        Console.WriteLine("\nEnter the number of the goal you want to record an event for:");
        goalManager.ListGoalNames();

        Console.Write("Goal number: ");
        int goalIndex;
        
        if (int.TryParse(Console.ReadLine(), out goalIndex) && goalIndex > 0 && goalIndex <= goalManager.GoalCount())
        {
            goalManager.RecordEvent(goalIndex - 1);
            Console.WriteLine("Event recorded successfully!");
        }
        else
        {
            Console.WriteLine("Invalid goal number. Please try again.");
        }
    }
}
