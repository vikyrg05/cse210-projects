using System;

class Address
{
    private string street;
    private string city;
    private string stateOrProvince;
    private string country;

    //Constructor
    public Address(string street, string city, string stateOrProvince, string country)
    {
        this.street = street;
        this.city = city;
        this.stateOrProvince = stateOrProvince;
        this.country = country;
    }

    //Getters
    public string Street { get { return street; } }
    public string City { get { return city; } }
    public string StateOrProvince { get { return stateOrProvince; } }
    public string Country { get { return country; } }

    //Check if address is in the USA 
    public bool IsInUSA()
    {
        return country == "USA";
    }
    
    //Return full address as a string
    public string GetFullAddress()
    {
        return street + "\n" + city + ", " + stateOrProvince + "\n" + country;
    }
}