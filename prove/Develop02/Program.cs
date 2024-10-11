using System;

class Program
{
    static void Main(string[] args)
    {
        // Set up instances and variables
         PromptGenerator prompt1 = new PromptGenerator();
        prompt1._prompts.Add("What was the best thing that happened to you today? ");
        prompt1._prompts.Add("Who did you talk to today? What did you talk about? ");
        prompt1._prompts.Add("What activities did you do today? ");
        prompt1._prompts.Add("What was one nice thing someone did for you today? ");
        prompt1._prompts.Add("Who do you feel wronged you today? ");
        prompt1._prompts.Add("What was the worst part of your day today? ");
        prompt1._prompts.Add("What do you want to do tomorrow? ");
        prompt1._prompts.Add("What did you do right after you woke up this morning? ");

        Entry entry1 = new Entry();
        entry1._promptText = prompt1.GetRandomPrompt();

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
                    
                }
                else if (menuChoice == 2)
                {

                }
                else if (menuChoice == 3)
                {

                }
                else if (menuChoice == 4)
                {

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