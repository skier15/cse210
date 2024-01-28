using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");
        string book = "Proverbs";
        int chapter = 3;
        int verse = 5;
        int endVerse = 6;
        string text = "Trust in the Lord with all thine heart and lean not into thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.";

        Reference reference = new Reference(book, chapter, verse, endVerse);
        Scripture scripture = new Scripture(reference, text);

        
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine();
        Console.WriteLine("Please enter to continue or type 'quit' to finish:");

        string answer = "";

        while (answer.ToLower() != "quit" && !scripture.IsCompletelyHidden())
        {
            answer = Console.ReadLine();
            Console.Clear();
            scripture.HideRandomWords();
            Console.WriteLine(scripture.GetDisplayText());   
        }

    }
}