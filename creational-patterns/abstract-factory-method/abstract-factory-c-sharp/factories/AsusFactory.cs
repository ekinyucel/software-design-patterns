/* Concrete Factory */

using System;
using abstract_factory_c_sharp.product;

namespace abstract_factory_c_sharp.factories
{
    public class AsusFactory : TechFactory
    {
        public override Telephone CreateTelephone(string type)
        {
            Console.WriteLine("Asus {0} has been created", type);
            return new AsusTelephone();
        }

        public override Laptop CreateLaptop()
        {
            Console.WriteLine("Asus Laptop has been created");
            return new AsusLaptop();
        }
    }
}
