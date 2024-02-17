public class Outdoor : Event
{
    private string _weatherStatement;

    public Outdoor(string title,
        string description,
        string time,
        string date,
        Address address,
        string weatherStatement
        ) : base(title, description, time, date, address) 
    {
        _weatherStatement = weatherStatement;
    }

    override public string ShowStandardDetails()
    {
        return $"{base.ShowStandardDetails()}\nType: Outdoor.\nWeather: {_weatherStatement}.";
    }

    public override string ShowShortDescription()
    {
        return $"Type: Outdoor.\nTitle: {base._title}. Date: {base._date}.";
    }
}