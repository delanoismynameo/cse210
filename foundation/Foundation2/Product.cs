using System;

public class Product
{
    private string _productId;
    private string _name;
    private double _price; // Price per unit
    private int _quantity;

    public Product(string productId, string name, double price, int quantity)
    {
        _productId = productId;
        _name = name;
        _price = price;
        _quantity = quantity;
    }

    public double GetTotalCost()
    {
        return _price * _quantity;
    }

    public string GetPackingLabel()
    {
        return $"Product: {_name}, ID: {_productId}, Quantity: {_quantity}";
    }
}
