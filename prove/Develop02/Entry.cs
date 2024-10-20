using System;
using System.Collections.Generic;
public class Entry
{
    public String _date;
    public String _promptText;
    public String _entryText;

    public Entry(string promptText, string entryText)
    {
        _promptText = promptText;
        _entryText = entryText;
        _date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
    }



    public void Display()
    {
        Console.WriteLine($"{_date} - Prompt: {_promptText}\n{_entryText}");
    }
}