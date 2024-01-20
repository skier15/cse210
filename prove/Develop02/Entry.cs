public class Entry
{
    public string _date;
    public string _time;
    public string _promptText;
    public string _entryText;

    public void Display()
    {
        Console.WriteLine($"Date/Time: {_date}/{_time} - Prompt: {_promptText}\n{_entryText}\n");
    }
}