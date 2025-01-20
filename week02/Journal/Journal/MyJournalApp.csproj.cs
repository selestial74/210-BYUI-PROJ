using System;
using System.Collections.Generic;
using System.IO;

class Journal
{
    private List<string> entries = new List<string>();

    public void AddEntry(string entry)
    {
        if (!string.IsNullOrEmpty(entry))
        {
            entries.Add(entry);
        }
        else
        {
            Console.WriteLine("Entry cannot be empty.");
        }
    }

    public void DisplayEntries()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("No entries found.");
        }
        else
        {
            foreach (var entry in entries)
            {
                Console.WriteLine($"- {entry}");
            }
        }
    }

    public void SaveToFile(string filename)
    {
        if (!string.IsNullOrEmpty(filename))
        {
            File.WriteAllLines(filename, entries);
            Console.WriteLine($"Entries saved to {filename}.");
        }
        else
        {
            Console.WriteLine("Filename cannot be empty.");
        }
    }

    public void LoadFromFile(string filename)
    {
        if (File.Exists(filename))
        {
            entries = new List<string>(File.ReadAllLines(filename));
            Console.WriteLine($"Entries loaded from {filename}.");
        }
        else
        {
            Console.WriteLine($"File {filename} does not exist.");
        }
    }
}

class MyJournalApp
{
    static void Main()
    {
        Journal journal = new Journal();

        while (true)
        {
            Console.WriteLine("\nJournal Manager");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display all entries");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Enter your journal entry: ");
                string entry = Console.ReadLine();
                journal.AddEntry(entry);
            }
            else if (choice == "2")
            {
                journal.DisplayEntries();
            }
            else if (choice == "3")
            {
                Console.Write("Enter filename to save: ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }
            else if (choice == "4")
            {
                Console.Write("Enter filename to load: ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
            }
            else if (choice == "5")
            {
                Console.WriteLine("Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
}
