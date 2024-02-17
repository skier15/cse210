public class Lecture : Event
{
    private string _speakerName;
    private int _capacity;

    public Lecture(string title,
        string description,
        string time,
        string date,
        Address address,
        string speakerName,
        int capacity
        ) : base(title, description, time, date, address) 
    {
        _speakerName = speakerName;
        _capacity = capacity;
    }

    override public string ShowStandardDetails()
    {
        return $"{base.ShowStandardDetails()}\nType: Lecture.\nSpeaker name: {_speakerName}. Capacity: {_capacity}";
    }

    public override string ShowShortDescription()
    {
        return $"Type: Lecture.\nTitle: {base._title}. Date: {base._date}";
    }
}