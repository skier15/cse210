public class BreathingActivity : Activity
{
    public BreathingActivity(
        string name, 
        string description
        ) : base(name, description)
    {}

    public void Run()
    {
        Console.WriteLine("Get Ready...");
        ShowSpinner(5);
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(base._duration); 
        Console.WriteLine();
        Console.Write("\nBreathe in...");
        ShowCountDown(2);
        Console.WriteLine();
        Console.Write("Breathe out...");
        ShowCountDown(3);
        Console.WriteLine();

        while(DateTime.Now < endTime)
        {
            Console.WriteLine();
            Console.Write("Breathe in...");
            ShowCountDown(4);
            Console.WriteLine();
            Console.Write("Breathe out...");
            ShowCountDown(6);
            Console.WriteLine();
        }
    }
}