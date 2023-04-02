using System;


// Class for addresses, containing member variables for street, city, state, and zip code
class Address
{
    private string street;
    private string city;
    private string country;

    public Address(string street, string city, string country)
    {
        this.street = street;
        this.city = city;
        this.country = country;
    }

    public override string ToString()
    {
        return $"{street}, {city}, {country}";
    }
}