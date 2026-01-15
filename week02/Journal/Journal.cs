using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    private string _separator = "|";

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter writer = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine(
                    $"{entry._date}{_separator}" +
                    $"{entry._promptText}{_separator}" +
                    $"{entry._entryText}{_separator}" +
                    $"{entry._mood}{_separator}" +
                    $"{entry._tags}"
                );
            }
        }

        Console.WriteLine("Journal saved.");
    }

    public void LoadFromFile(string file)
    {
        _entries.Clear();

        string[] lines = File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split(_separator);

            string date = parts[0];
            string prompt = parts[1];
            string text = parts[2];
            string mood = parts[3];
            string tags = parts[4];

            Entry entry = new Entry(date, prompt, text, mood, tags);
            _entries.Add(entry);
        }

        Console.WriteLine("Journal loaded.");
    }
}
