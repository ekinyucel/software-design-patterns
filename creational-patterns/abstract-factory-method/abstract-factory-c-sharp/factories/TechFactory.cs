/* Abstract Factory Class */

using abstract_factory_c_sharp.product;

namespace abstract_factory_c_sharp.factories
{
    public abstract class TechFactory
    {
        public abstract Telephone CreateTelephone(string type);
        public abstract Laptop CreateLaptop();
    }
}
