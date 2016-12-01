/* Product */

using System;

namespace abstract_factory_c_sharp.product
{
    class SamsungTelephone : ITelephone
    {
        public void Create()
        {
            Console.WriteLine($"Samsung {Model} smart phone has been created");
        }

        public string Model { get; set; }
    }
}
