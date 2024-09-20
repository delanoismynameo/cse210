using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        String name = PromptUserName();
        int favoriteNumberInt = PromptUserNumber();
        int squaredNumber = SquareNumber(favoriteNumberInt);
        DisplayResult(name, squaredNumber);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static String PromptUserName()
    {
        Console.Write("Please enter your name: ");
        String name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string favoriteNumberString = Console.ReadLine();
        int favoriteNumberInt = int.Parse(favoriteNumberString);
        return favoriteNumberInt;
    }

    static int SquareNumber(int unsquaredNumber)
    {
       int squaredNumber = unsquaredNumber * unsquaredNumber;
       return squaredNumber;
    }

    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
    }
}