using System;

class Product
{
    private string _name;
    private int _id;
    private double _price;
    private int _quantity;

    public Product(string name, int id, double price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    public string GetProduct()
    {
        return $"Item: {_name} #{_id}\nPrice: ${_price}\nQnt: {_quantity}";
    }

    public double GetTotalPrice()
    {
        return _price * _quantity;
    }
}