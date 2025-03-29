using System;

class Program
{
    static void Main(string[] args)
    {
        Customer c1 = new Customer("John Smith", new Address("123 Main Street", "New York", "NY","USA"));
        Order o1 = new Order(c1);
        o1.AddProduct(new Product("Apple", "A123", 1, 2));
        o1.AddProduct(new Product("Banana", "B123", 2, 1));
        o1.OnlineOrdering();
        Customer c2 = new Customer("Emma Smith", new Address("456 Elm St", "Toronto", "ON", "Canada"));
        Order o2 = new Order(c2);
        o2.AddProduct(new Product("Laptop", "P001", 1200, 2));
        o2.AddProduct(new Product("Smartphone", "P002", 800, 3));
        o2.AddProduct(new Product("Headphones", "P003", 150, 5));
        o2.OnlineOrdering();
        Customer c3 = new Customer("Carlos Rodriguez", new Address("789 Oak St", "Madrid", "Madrid", "Spain"));
        Order o3 = new Order(c3);
        o3.AddProduct(new Product("Keyboard", "P004", 100, 4));
        o3.AddProduct(new Product("Mouse", "P005", 50, 6));
        o3.AddProduct(new Product("Monitor", "P006", 300, 2));
        o3.OnlineOrdering();
        
    }
}



