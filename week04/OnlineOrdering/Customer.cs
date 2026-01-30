using System;

class Customer
{
    private string name;
    private Address address;

    //Constructor
    public Customer(string name, Address address)
    {
        this.name = name;
        this.address = address;
    }

    //Getters
    public string Name { get { return name; } }
    public Address Address { get { return address; } }

    //Check if customer is in the USA
    public bool IsInUSA()
    {
        return address.IsInUSA();
    }
}