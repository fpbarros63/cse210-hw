using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine() ?? "";

            if (choice == "1")
            {
                BreathingActivity a = new BreathingActivity();
                a.Run();
            }
            else if (choice == "2")
            {
                ReflectingActivity a = new ReflectingActivity();
                a.Run();
            }
            else if (choice == "3")
            {
                ListingActivity a = new ListingActivity();
                a.Run();
            }
            else if (choice == "4")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid option. Press Enter to try again...");
                Console.ReadLine();
            }
        }
    }
}