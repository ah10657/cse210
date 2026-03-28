using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        Prompt promptGenerator = new Prompt();

        string choice = "";

        while (choice != "5")
        {
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            choice = Console.ReadLine();

            if (choice == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(prompt);

                Console.Write("Your response: ");
                string response = Console.ReadLine();

                Entry newEntry = new Entry();
                newEntry._date = DateTime.Now.ToShortDateString();
                newEntry._prompt = prompt;
                newEntry._response = response;

                journal.AddEntry(newEntry);
            }
            else if (choice == "2")
            {
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.Write("Enter filename you want to load: ");
                string filename = Console.ReadLine();
                journal.Load(filename);
                journal.DisplayAll();
            }
            else if (choice == "4")
            {
                Console.Write("Enter filename you want to save to: ");
                string filename = Console.ReadLine();
                journal.Save(filename);
            }
        }
    }
}