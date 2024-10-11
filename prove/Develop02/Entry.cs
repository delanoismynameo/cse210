using System;
public class Entry
{
    public String _date;
    public String _promptText;
    public String _entryText;

    public void Display()
    {
        Console.WriteLine($"{_date} - Prompt: {_promptText}\n{_entryText}");
    }
}