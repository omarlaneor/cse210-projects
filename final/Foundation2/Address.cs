using System;

namespace OrderProducts
{

class Address
    {
        private string street;
        private string city;
        private string country;
        private string state;

            public Address(string street, string city, string country, string state)
            {
                this.street = street;
                this.city = city;
                this.country = country;
                this.state = state;
            }

            public string GetStreet()
            {
                return street;
            }

            public string GetCity()
            {
                return city;
            }

            public string GetCountry()
            {
                return country;
            }

            public string GetState()
            {
                return state;
            }
    }
}


