using System;

namespace observer_c_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var grocery = new Shop("Grocery");
            var mall = new Shop("Mall");
            var butchery = new Shop("Butchery");

            var producta = new ProductA("Product A", 150.0);
            producta.Attach(grocery);
            producta.Attach(mall);

            var productb = new ProductA("Product B", 20.0);
            productb.Attach(grocery);
            productb.Attach(butchery);

            //notify changed prices to observers(shops)
            Console.WriteLine($"First price of Product A is {producta.Price}$" + "\n");
            Console.WriteLine($"First price of Product B is {productb.Price}$" + "\n");
            producta.Price = 145.0;
            producta.Price = 140.5;
            productb.Price = 25.0;

            Console.ReadKey();
        }
    }
}
