using System;

class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _products = new List<Product>();
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    
        public double GetShippingCost(bool isDomestic)
    {
        if (isDomestic)
        {
            return 5.00;
        }
        else
        {
            return 35.00;
        }
    }
    
    public double GetTotalPrice()
    {
        double totalPrice = 0;
        foreach (Product product in _products)
        {
            totalPrice += product.GetTotalPrice();
        }
        totalPrice += GetShippingCost(_customer.GetCustomer().Contains("USA"));
        return totalPrice;
    }

    public string GetShippingLabel()
    {
        return _customer.GetCustomer();
    }

    public void DisplayOrder()
    {
        Console.WriteLine("\nProducts:\n");
        foreach (Product product in _products)
        {
            Console.WriteLine(product.GetProduct());
        }
        Console.WriteLine($"\nTotal Price: ${GetTotalPrice() - GetShippingCost(_customer.GetCustomer().Contains("USA")):F2}");
        Console.WriteLine($"Shipping Cost: ${GetShippingCost(_customer.GetCustomer().Contains("USA"))}");
        Console.WriteLine($"Total Price w/ Shipping: ${GetTotalPrice():F2}");
    }

    public void DisplayPackingLabel()
    {
        Console.WriteLine("Product Label:");
        foreach (Product product in _products)
        {
            Console.WriteLine(product.GetProduct());
        }
    }

    public void DisplayShippingLabel()
    {
        Console.WriteLine("------------------------------");
        Console.WriteLine($"Shipping Label: \n{GetShippingLabel()}\n");
    }
}