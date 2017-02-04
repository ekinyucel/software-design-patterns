using System;

namespace observer_c_sharp
{
    /// <summary>
    /// concrete observer
    /// </summary>
    public class Shop : IShop
    {
        private string _name;
        private Product _product;

        public Shop(string name)
        {
            _name = name;
        }

        public void Update(Product product)
        {
            Console.WriteLine($"Notified {_name} of {_product.Symbol}'s " + $"change to {_product.Price:C}");
        }

        public Product Product
        {
            get { return _product;  }
            set { _product = value; }
        }
    }
}
