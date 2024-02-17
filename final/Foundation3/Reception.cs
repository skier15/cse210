public class Reception : Event
{
    private string _email;

    public Reception(string title,
        string description,
        string time,
        string date,
        Address address,
        string email
        ) : base(title, description, time, date, address) 
    {
        _email = email;
    }

    override public string ShowStandardDetails()
    {
        return $"{base.ShowStandardDetails()}\nType: Reception.\nEmail for RSVP: {_email}.";
    }

    public override string ShowShortDescription()
    {
        return $"Type: Reception.\nTitle: {base._title}. Date: {base._date}.";
    }
}