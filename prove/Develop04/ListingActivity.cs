public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity(
        string name, 
        string description
        ) : base(name, description)
    {
        _count = 0;
        _prompts = new List<string>()
            {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
            };
    }

    public void Run()
    {
        Console.WriteLine("Get Ready...");
        ShowSpinner(5);
        Console.WriteLine();
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(base._duration);
        
        while (DateTime.Now < endTime)
        {
            GetAnswerFromUser();
            _count++;
        }

        Console.WriteLine($"You listed {_count} items!");
    }

    private string GetRandomPrompt()
    {
        Random _random = new Random();
        int randomIndex = _random.Next(_prompts.Count);
        return _prompts[randomIndex];
    }

    private void GetAnswerFromUser()
    {
        Console.Write(">");
        Console.ReadLine();        
    }
}