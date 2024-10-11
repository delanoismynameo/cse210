using System;

public class PromptGenerator
{
    public List<String> _prompts = new List<String>();

    public String GetRandomPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(_prompts.Count);
        string randomPrompt = _prompts[randomIndex];
        // Console.WriteLine(randomPrompt);
        return randomPrompt;
    }
}