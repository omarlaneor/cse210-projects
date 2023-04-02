using System;
using System.Text;


namespace OrderProducts
{

    class Order
        {
        private Client client;
        private List<Product> products;

        public Order(Client client)
        {
            this.client = client;
            this.products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public double GetFinalPrice()
        {
            double totalPrice = 0.0;
            foreach (Product product in products)
            {
                totalPrice += product.GetTotalPrice();
            }
            return totalPrice;
        }

        public string GetPackingLabel()
        {
            StringBuilder label = new StringBuilder();
            label.AppendLine("Packing Label:");
            label.AppendLine("======================");
            label.AppendLine($"Receiver: {client.GetName()}");
            label.AppendLine($"Street: {client.GetAddress().GetStreet()}");
            label.AppendLine($"City: {client.GetAddress().GetCity()}");
            label.AppendLine($"Country: {client.GetAddress().GetCountry()}");
            label.AppendLine($"State: {client.GetAddress().GetState()}");
            label.AppendLine("======================");
            label.AppendLine("Products:");
            label.AppendLine("----------------------");
            foreach (Product product in products)
            {
                label.AppendLine($"{product.GetName()} x{product.GetQuantity()}");
            }
            label.AppendLine("======================");
            return label.ToString();
        }

        public string GetShippingLabel()
        {
            StringBuilder label = new StringBuilder();
            label.AppendLine("Shipping Label:");
            label.AppendLine("======================");
            label.AppendLine($"Receiver: {client.GetName()}");
            label.AppendLine($"Street: {client.GetAddress().GetStreet()}");
            label.AppendLine($"City: {client.GetAddress().GetCity()}");
            label.AppendLine($"Country: {client.GetAddress().GetCountry()}");
            label.AppendLine($"State: {client.GetAddress().GetState()}");
            label.AppendLine("======================");
            return label.ToString();
        }
    }

}