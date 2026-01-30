using System;

class Product
{
    private string name;
    private string id;
    private double price;
    private int quantity;

    //Constructor
    public Product(string name, string id, double price, int quantity)
    {
        this.name = name;
        this.id = id;
        this.price = price;
        this.quantity = quantity;
    }

    //Getters
    public string Name { get { return name; } }
    public string Id { get { return id; } }
    public double Price { get { return price; } }
    public int Quantity { get { return quantity; } }

    //Calculate total cost for this product
    public double CalculateTotalCost()
    {
        return price * quantity;
    }
}