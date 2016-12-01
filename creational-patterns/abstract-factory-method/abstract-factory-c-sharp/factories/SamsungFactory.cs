/* Concrete Factory */

using System;
using abstract_factory_c_sharp.product;

namespace abstract_factory_c_sharp.factories
{
    public class SamsungFactory : ITechFactory
    {
        public ITelephone CreateTelephone(string model)
        {
            var telephone = new SamsungTelephone {Model = model};
            telephone.Create();
            return telephone;
        }

        public ILaptop CreateLaptop(string model)
        {
            var laptop = new SamsungLaptop {Model = model};
            laptop.Create();
            return laptop;
        }
    }
}
