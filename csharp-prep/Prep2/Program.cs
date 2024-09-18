using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade precentage? ");
        string gradeString = Console.ReadLine();
        int gradeInt = int.Parse(gradeString);
        String letter = ("");
        if (gradeInt >= 90)
        {
            letter = ("A");
        }
        else if (gradeInt >= 80)
        {
            letter = ("B");
        }
        else if (gradeInt >= 70)
        {
            letter = ("C");
        }
        else if (gradeInt >= 60)
        {
            letter = ("D");
        }
        else if (gradeInt <= 60)
        {
            letter = ("F");
        }
        else
        {
            Console.Write("");
        }
        Console.WriteLine($"You have a(n) \"{letter}\" grade.");
        if (gradeInt >= 70)
        {
            Console.WriteLine("Congratulations! You have passed the class.");
        }
        else
        {
            Console.WriteLine("Unfortunately, you hav failed the class. You were almost there! ");
        }
    }
}