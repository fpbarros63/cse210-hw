using System;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    public string _mood;
    public string _tags;

    public Entry(string date, string promptText, string entryText, string mood, string tags)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
        _mood = mood;
        _tags = tags;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Mood: {_mood}");
        Console.WriteLine($"Tags: {_tags}");
        Console.WriteLine(_entryText);
        Console.WriteLine();
    }
}
