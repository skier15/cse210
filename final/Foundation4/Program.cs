using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation4 World!");
        Console.WriteLine("Polymorphism with Exercise Tracking");
        Console.WriteLine();

        List<Activity> activities = new List<Activity>();

        activities.Add(new Running("2022-11-03", 30, 4.8));
        activities.Add(new Cycling("2022-11-04", 30, 10));
        activities.Add(new Swimming("2022-11-05", 30, 5));

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}