public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool IsInNigeria()
    {
        return _address.IsInNigeria();
    }

    public string GetCustomerDetails()
    {
        return $"{_name}\n{_address.GetFullAddress()}";
    }
}
