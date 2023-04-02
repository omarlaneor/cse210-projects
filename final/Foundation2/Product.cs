using System;

namespace OrderProducts
{
class Product
    {
        private string name;
        private int idProduct;
        private double price;
        private int quantity;

        public Product(string name, int idProduct, double price, int quantity)
        {
            this.name = name;
            this.idProduct = idProduct;
            this.price = price;
            this.quantity = quantity;
        }

        public double GetTotalPrice()
        {
            return price * quantity;
        }

        public string GetName()
        {
            return name;
        }

        public int GetIdProduct()
        {
            return idProduct;
        }

        public int GetQuantity()
        {
            return quantity;
        }
    }
}

