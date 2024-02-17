public class Address
{
    private string _country;
    private string _stateOrProvince;
    private string _city;
    private string _street;
    

    public Address(string country, string stateOrProvince, string city, string street)
    {
        _country = country;
        _stateOrProvince = stateOrProvince;
        _city = city;
        _street = street;
    }

    //  This method returns whether it is in the USA or not.
    public bool IsUSA()
    {
        return _country.ToUpper() == "USA";
    }

    // This method returns a string all of its fields together in one string 
    public string GetFullAddress()
    {
        return $"Country: {_country}. State/Province: {_stateOrProvince}.\nCity: {_city}. Street: {_street}.";
    }

}