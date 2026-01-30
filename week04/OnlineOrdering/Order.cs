using System;
using System.Collections.Generic;

class Order
{
    private List<Product> products;
    private Customer customer;

    //Constructor: receives a customer and creates the product list
    public Order(Customer customer)
    {
        this.customer = customer;
        products = new List<Product>();
    }

    //Add a product to the order
    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    //Calculate total cost of the order
    public double CalculateTotalCost()
    {
        double total = 0;

        foreach (Product product in products)
        {
            total += product.CalculateTotalCost();
        }

        double shippingCost;
        if (customer.IsInUSA())
        {
            shippingCost = 5;
        }
        else
        {
            shippingCost = 35;
        }

        total += shippingCost;

        return total;
    }

    public string GetPackingLabel()
    {
        string label = "";

        foreach (Product product in products)
        {
            label += $"Product Name: {product.Name}, ID: {product.Id}\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return customer.Name + "\n" + customer.Address.GetFullAddress();
    }
}