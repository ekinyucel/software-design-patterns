/* Product */

using System;

namespace abstract_factory_c_sharp.product
{
    class AsusLaptop : ILaptop
    {
        public void Create()
        {
            Console.WriteLine($"Asus {Model} laptop has been created");
        }

        public string Model { get; set; }
    }
}
