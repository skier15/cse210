using System;

class Program
{
    static void Main(string[] args)
    {
        
        int _selectedMenuItem = 0;

        while (_selectedMenuItem != 4)
        {
            DisplayMenu();
            _selectedMenuItem =  int.Parse(Console.ReadLine());

            switch (_selectedMenuItem)
            {
                case 1 :
                    StartBreathingActivity();
                    break;
                case 2 :
                    StartReflectingActivity();
                    break;
                case 3 :
                    StartListingActivity();
                    break;
                default:
                    break;
            }
        }
    }

    static public void DisplayMenu()
    {
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("Menu Options: ");
        Console.WriteLine();
        Console.WriteLine("1. Start Breathing Activity");
        Console.WriteLine("2. Start Reflecting Activity");
        Console.WriteLine("3. Start Listening Activity");
        Console.WriteLine("4. Quit");
        Console.WriteLine();
        Console.Write("Select a choice from the menu: ");
    }

    static public void StartBreathingActivity()
    {
        BreathingActivity breathingActivity = new BreathingActivity(
            "Breathing Activity",
            "relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing"
        );
        breathingActivity.DisplayStartMessage();
        breathingActivity.Run();
        breathingActivity.DisplayEndMessage();
    }

    static public void StartReflectingActivity()
    {
        ReflectingActivity reflectingActivity = new ReflectingActivity(
            "Reflecting Activity",
            "reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life"
        );
        reflectingActivity.DisplayStartMessage();
        reflectingActivity.Run();
        reflectingActivity.DisplayEndMessage();
    }

    static public void StartListingActivity()
    {
        ListingActivity listingActivity = new ListingActivity(
            "Listing Activity",
            "reflect on the good things in your life by having you list as many things as you can in a certain area"
        );
        listingActivity.DisplayStartMessage();
        listingActivity.Run();
        listingActivity.DisplayEndMessage();
    }
}