// Exceeding Requirements:
// 1) Prompts do not repeat on the same day.
// 2) Each entry stores a mood (1-5) and tags, and saves/loads them from the file.

using System;


class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator prompts = new PromptGenerator();

        string choice = "";

        while (choice != "5")
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            choice = Console.ReadLine();

            if (choice == "1")
            {
                string today = DateTime.Now.ToShortDateString();
                List<string> usedToday = journal.GetUsedPromptsForDate(today);

                string prompt = prompts.GetRandomPrompt(usedToday);

                if (prompt == "All prompts for today have already been used.")
                {
                    Console.WriteLine(prompt);
                }
                else
                {
                    Console.WriteLine(prompt);
                    Console.Write("> ");
                    string response = Console.ReadLine();

                    Console.Write("Mood (1-5): ");
                    string mood = Console.ReadLine();

                    Console.Write("Tags (comma separated): ");
                    string tags = Console.ReadLine();

                    string date = DateTime.Now.ToShortDateString();

                    Entry entry = new Entry(date, prompt, response, mood, tags);
                    journal.AddEntry(entry);
                }
            }
            else if (choice == "2")
            {
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
            }
            else if (choice == "4")
            {
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }
        }
    }
}
