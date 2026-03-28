using System;

class Customer
{
    private string _name;
    private string _address;

    public Customer(string name, string address)
    {
        _name = name;
        _address = address;
    }

    public string GetCustomer()
    {
        return $"{_name}\n{_address}";
    }
}