using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
            Product product1 = new Product("Shirt", 1001, 19.99, 1);
            Product product2 = new Product("Pants", 1002, 39.99, 1);
            Product product3 = new Product("Shoes", 1003, 59.99, 1);
    
            Address address1 = new Address("123 Main St", "Anytown", "UT", "USA");
    
            Customer customer1 = new Customer("John Doe", address1.GetAddress());
    
            Order order1 = new Order(customer1);
            order1.AddProduct(product1);
            order1.AddProduct(product3);

            Address address2 = new Address("234 Elm St", "Othertown", "Alberta", "Canada");

            Customer customer2 = new Customer("Jane Smith", address2.GetAddress());

            Order order2 = new Order(customer2);
            order2.AddProduct(product1);
            order2.AddProduct(product2);
            order2.AddProduct(product3);

            order1.DisplayShippingLabel();
            order1.DisplayPackingLabel();
            order1.DisplayOrder();
            
            order2.DisplayShippingLabel();
            order2.DisplayPackingLabel();
            order2.DisplayOrder();
    }
}