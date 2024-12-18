using System;

class BreathingActivity : Activity
{
    public BreathingActivity(int duration) 
        : base("Breathing Activity", 
               "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", 
               duration) { }

    public override void Run()
    {
        DisplayStartingMessage();
        for (int i = 0; i < _duration / 4; i++) // Each cycle takes about 4 seconds
        {
            Console.WriteLine("Breathe in...");
            ShowCountdown(2);
            Console.WriteLine("Breathe out...");
            ShowCountdown(2);
        }
        DisplayEndingMessage();
    }
}
