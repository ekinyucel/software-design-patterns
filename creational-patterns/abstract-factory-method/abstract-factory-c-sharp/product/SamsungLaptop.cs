/* Producct */

using System;

namespace abstract_factory_c_sharp.product
{
    class SamsungLaptop : ILaptop
    {
        public void Create()
        {
            Console.WriteLine($"Samsung {Model} laptop has been created");
        }

        public string Model { get; set; }
    }
}
