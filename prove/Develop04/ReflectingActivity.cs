public class ReflectingActivity : Activity
{

    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity(
        string name, 
        string description
        ) : base(name, description)
        {
            _prompts = new List<string>()
                {
                    "Think of a time when you stood up for someone else",
                    "Think of a time when you did something really difficult",
                    "Think of a time when you helped someone in need",
                    "Think of a time when you did something truly selfless"
                };
            _questions = new List<string>()
                {
                    "Why was this experience meaningful to you?",
                    "Have you ever done anything like this before?",
                    "How did you get started?",
                    "How did you feel when it was complete?",
                    "What made this time different than other times when you were not as successful?",
                    "What is your favorite thing about this experience?",
                    "What could you learn from this experience that applies to other situations?",
                    "What did you learn about yourself through this experience?",
                    "How can you keep this experience in mind in the future?"
                };
        }

    public void Run()
    {
        Console.WriteLine("Get Ready...");
        ShowSpinner(5);
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        DisplayPrompt();
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.Clear();
        DisplayQuestions();
    }

    private string GetRandomPrompt()
    {
        Random _random = new Random();
        int randomIndex = _random.Next(_prompts.Count);
        return _prompts[randomIndex];
    }

    private string GetRandomQuestion()
    {
        Random _random = new Random();
        int randomIndex = _random.Next(_questions.Count);
        return _questions[randomIndex];
    }

    private void DisplayQuestions()
    { 
        int numberOfquestions = base._duration/10;

        for (int i = numberOfquestions; i > 0; i--)
        {
            Console.Write($"> {GetRandomQuestion()} ");
            ShowSpinner(10);
            Console.WriteLine();
        }
    }

    private void DisplayPrompt()
    {
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
    }
}