/* Abstract Factory Class */

using abstract_factory_c_sharp.product;

namespace abstract_factory_c_sharp.factories
{
    public interface ITechFactory
    {
        ITelephone CreateTelephone(string model);
        ILaptop CreateLaptop(string model);
    }
}
