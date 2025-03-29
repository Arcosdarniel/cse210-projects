public class Customer
{
    private string _name;
    private Address _address;

    
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
    public string GetName()
    {
        return _name;
    }
    public string GetFullInfo()
    {
        _address.GetAddress();
        return $"{_name}\n{_address.GetAddress()}";
    }
    public bool GetCustomerInfo()
    {
        return _address.IsUnitedStates();
    }
}