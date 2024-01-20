// Exceeding the requirements
// Add time variable to menu and Entry class

using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        int selectedMenuItem = 0;

        Console.WriteLine("Welcome to the Journal Program!");

        while (selectedMenuItem != 5)
        {
            
            Menu();

            string selectedMenuItemString = Console.ReadLine();
            selectedMenuItem = int.Parse(selectedMenuItemString);

            if (selectedMenuItem == 1)
            {
                Write(journal, promptGenerator);
            }
            if (selectedMenuItem == 2)
            {
                Display(journal);
            }
            if (selectedMenuItem == 3)
            {
                Load(journal);
            }
            if (selectedMenuItem == 4)
            {
                Save(journal);
            }
            if (selectedMenuItem == 5)
            {
                break;
            }

        }
    
    }

    
    



    static public void Menu()
    {
        Console.WriteLine();
        Console.WriteLine("\nPlease select one of the following choices [1-5]: ");
        Console.WriteLine();
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.WriteLine();
        Console.WriteLine("\nWhat would you like to do? ");
    }

    static public void Write(Journal journal, PromptGenerator promptGenerator)
    {
        Entry entry = new Entry();
        DateTime theCurrentTime = DateTime.Now;
        
        string dateText = theCurrentTime.ToShortDateString();
        string timeText = theCurrentTime.ToShortTimeString();

        string randomPrompt = promptGenerator.GetRandomPrompt();
        Console.WriteLine(randomPrompt);

        string entryText = Console.ReadLine();

        entry._date = dateText;
        entry._time = timeText;
        entry._promptText = randomPrompt;
        entry._entryText = entryText;

        journal.AddEntry(entry);
    }

    static public void Display(Journal journal)
    {
        journal.Display();
    }

    static public void Load(Journal journal)
    {   
        Console.Write("Please enter file name: ");
        string file = Console.ReadLine();
        journal.LoadFromFile(file);
    }

    static public void Save(Journal journal)
    {
        Console.Write("Please enter file name: ");
        string file = Console.ReadLine();
        journal.SaveToFile(file);
    }
}

    