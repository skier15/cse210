abstract public class Event
{
    private string _description;
    private string _time;
    private Address _address;
    protected string _title;
    protected string _date;

    public Event(
        string title,
        string description,
        string time,
        string date,
        Address address
        )
    {
        _title = title;
        _description = description;
        _time = time;
        _date = date;
        _address = address;
    }

    virtual public string ShowStandardDetails()
    {
        return $"Title: {_title}.\nDescription: {_description}.\nDate: {_date}. Time: {_time}.\nAddress: {_address.GetFullAddress()}.";
    }

    abstract public string ShowShortDescription();
}