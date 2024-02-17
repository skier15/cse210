public class Product
{
    private string _name;
    private int _productId;
    private int _price;
    private int _quantity;

    public Product(string name, int productId, int price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    // Getter for _name
    public string GetProductName()
    {
        return _name;
    }

    // Getter for _productId
    public int GetProductID()
    {
        return _productId;
    }
    // This method gets total product cost
    public int GetTotalCost()
    {
        return _price * _quantity;
    }
}