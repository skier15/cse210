public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }

    // This method prints packing label
    public void GetPackingLabel()
    {
        Console.WriteLine("Packing Label.");
        foreach (Product product in _products)
        {
            Console.WriteLine($"Product name: [{product.GetProductName()}]. Product ID: {product.GetProductID()}");
        }
    }

    // This method prints shipping label
    public void GetShippingLabel()
    {
        Console.WriteLine("Shipping label.");
        Console.WriteLine($"Customer: [{_customer}].");
        Console.WriteLine($"Address: [{_customer.GetAddress().GetFullAddress()}].");
    }

    // This function calculates the total cost of the order (products price + shipping cost)
    public void CalculateAndPrintTotalCost()
    {
        int shippingCostUSA = 5;
        int shippingCostNotUSA = 35;
        int totalCost = 0;

        int productsPrice = _products.Sum(product => product.GetTotalCost());
        if (_customer.LiveInUSA())
        {
            totalCost = productsPrice + shippingCostUSA;
        }
        else
        {
            totalCost = productsPrice + shippingCostNotUSA;
        }

        Console.WriteLine($"Total Cost: {totalCost}");
    }
}