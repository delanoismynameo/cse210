using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int guessInt = -1;
        int magicNumber = random.Next(0,101);

        while (guessInt != magicNumber)
        {
            Console.Write("What is the magic number? ");
            String guessString = Console.ReadLine();
            guessInt = int.Parse(guessString);

            if (guessInt > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guessInt < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guessInt == magicNumber)
            {
                Console.WriteLine("You guessed it!");
            }
            else
            {
                Console.Write("");
            }
        }
    }
}