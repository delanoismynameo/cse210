using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        int menuChoice = 0;

        // Start the loop
        while (menuChoice != 5)
            {
                // Show the menu
                DisplayMenu();

                String stringMenuChoice = Console.ReadLine();
                menuChoice = int.Parse(stringMenuChoice);
                if (menuChoice == 1)
                {
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine(prompt);
                    string response = Console.ReadLine();
                    Entry newEntry = new Entry(prompt, response);
                    journal.AddEntry(newEntry);
                }
                else if (menuChoice == 2)
                {
                    journal.DisplayAll();
                }
                else if (menuChoice == 3)
                {
                    Console.Write("Enter a filename to load the journal from: ");
                    string loadFilename = Console.ReadLine();
                    journal.LoadFromFile(loadFilename);
                }
                else if (menuChoice == 4)
                {
                    Console.Write("Enter a filename to save the journal: ");
                    string saveFilename = Console.ReadLine();
                    journal.SaveToFile(saveFilename);
                }
                else if (menuChoice == 5)
                {
                    Console.WriteLine("Quitting...");
                }
                else
                {
                    Console.WriteLine("Please enter a number 1-5");
                }
            }
    }
    static void DisplayMenu()
    {
        Console.WriteLine("Please select one of the following choices:\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
    }
}