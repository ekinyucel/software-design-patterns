/* Concrete Factory */

using System;
using abstract_factory_c_sharp.product;

namespace abstract_factory_c_sharp.factories
{
    public class SamsungFactory : TechFactory
    {
        public override Telephone CreateTelephone(string model)
        {
            Console.WriteLine("Samsung {0} has been created", model);
            return new SamsungTelephone();
        }

        public override Laptop CreateLaptop(string model)
        {
            Console.WriteLine("Samsung {0} Laptop has been created", model);
            return new SamsungLaptop();
        }
    }
}
