using System.Security.Cryptography.X509Certificates;

class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;
    
    public Order(Customer customer)
    {
        _customer = customer;
        
    }
    public void TotalPrice()
    {
        double total = 0;
        foreach (Product p in _products)
        {
            total += p.GetTotalCost();
        }
        double shippingCost = _customer.GetCustomerInfo() ? 5 : 35;
        total += shippingCost;
      
        Console.WriteLine($"Total Price: ${total:F2}");
    }
    public void PackingLabel()
    {
        string name = _customer.GetName();
        Console.WriteLine("Packing Label for "+ name);
        foreach (Product p in _products)
        {
            Console.WriteLine(p.GetId());
        }
    }
    public void ShippingLabel()
    {
      
        string Info = _customer.GetFullInfo();
        Console.WriteLine("Shipping Label for "+ Info);
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public void OnlineOrdering()
    {
        PackingLabel();
        ShippingLabel();
        TotalPrice();
        Console.WriteLine("\n");
    }
}