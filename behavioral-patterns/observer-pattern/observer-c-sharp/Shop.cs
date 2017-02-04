using System;

namespace observer_c_sharp
{
    /// <summary>
    /// concrete observer
    /// </summary>
    public class Shop : IShop
    {
        private string _name;

        public Shop(string name)
        {
            _name = name;
        }

        public void Update(Product product)
        {
            Console.WriteLine($"Notified {_name} of {product.Symbol}'s " + $"price change to {product.Price}$");
        }

        public Product Product { get; set; }
    }
}
