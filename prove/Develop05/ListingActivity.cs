using System;

class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "Who are some of your personal heroes?",
        "What are things you are grateful for?"
    };

    public ListingActivity(int duration) 
        : base("Listing Activity", 
               "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 
               duration) { }

    private string GetRandomPrompt()
    {
        Random rnd = new Random();
        return _prompts[rnd.Next(_prompts.Count)];
    }

    public override void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine(GetRandomPrompt());
        ShowCountdown(5);
        int count = 0;
        DateTime startTime = DateTime.Now;
        
        while ((DateTime.Now - startTime).TotalSeconds < _duration)
        {
            Console.Write("List an item: ");
            Console.ReadLine();
            count++;
        }
        
        Console.WriteLine($"You listed {count} items.");
        DisplayEndingMessage();
    }
}
