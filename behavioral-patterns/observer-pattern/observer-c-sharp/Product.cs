using System;
using System.Collections.Generic;

namespace observer_c_sharp
{
    /// <summary>
    /// "subject" abstract class
    /// </summary>
    public abstract class Product
    {
        private string _symbol;
        private double _price;
        private List<IShop> _shops = new List<IShop>();

        protected Product(string symbol, double price)
        {
            _symbol = symbol;
            _price = price;
        }

        public void Attach(IShop shop)
        {
            _shops.Add(shop);
        }

        public void Detach(IShop shop)
        {
            _shops.Remove(shop);
        }

        public void Notify()
        {
            foreach (var shop in _shops)
            {
                shop.Update(this);
            }

            Console.WriteLine("");
        }

        public double Price
        {
            get { return _price; }
            set
            {
                if (_price != value)
                {
                    _price = value;
                    Notify();
                }
            }
        }

        public string Symbol
        {
            get { return _symbol; }
        }
    }
}
