public class Address
{
    private string _country;
    private string _state;
    private string _city;
    private string _street;
    

    public Address(string country, string state, string city, string street)
    {
        _country = country;
        _state = state;
        _city = city;
        _street = street;
    }

    // This method returns Full Address as string
    public string GetFullAddress()
    {
        return $"Country: {_country}. State: {_state}.\nCity: {_city}. Street: {_street}.";
    }

}