public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string county)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = county;
    }

    public bool IsUnitedStates()
    {
        return _country.ToLower() == "united states" || _country.ToLower() == "usa";
    
    }
    public string GetAddress()
    {
        string fullAddress = _street + ", " + _city + ", " + _state + ", " + _country;
        return fullAddress;
    }
    
}