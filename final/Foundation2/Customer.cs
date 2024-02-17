public class Customer
{
    private string _name; 
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // getter _address
    public Address GetAddress()
    {
        return _address;
    }
    // This method returns whether they live in the USA or not. 
    public bool LiveInUSA()
    {
        return _address.IsUSA();
    }
}