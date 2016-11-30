/* Concrete Factory */

using System;
using abstract_factory_c_sharp.product;

namespace abstract_factory_c_sharp.factories
{
    public class SamsungFactory : TechFactory
    {
        public override Telephone CreateTelephone(string type)
        {
            Console.WriteLine("Samsung {0} Created", type);
            return new SamsungTelephone();
        }

        public override Laptop CreateLaptop()
        {
            Console.WriteLine("Samsung Laptop Created");
            return new SamsungLaptop();
        }
    }
}
