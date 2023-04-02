using System;

namespace OrderProducts
{
    class Client
    {
        private string name;
        private Address address;

        public Client(string name, Address address)
        {
            this.name = name;
            this.address = address;
        }

        public string GetName()
        {
            return name;
        }

        public Address GetAddress()
        {
            return address;
        }

        public bool LiveInUnitedStates()
        {
            return address.GetCountry() == "United States";
        }
    }
}
