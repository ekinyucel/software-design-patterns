using abstract_factory_c_sharp.factories;
using abstract_factory_c_sharp.product;

namespace abstract_factory_c_sharp
{
    class Client
    {
        private readonly TechFactory _techFactory;

        public Client(TechFactory techFactory)
        {
            _techFactory = techFactory;
        }

        public void CreateTelephone(string model)
        {
            _techFactory.CreateTelephone(model);
        }

        public void CreateLaptop(string model)
        {
            _techFactory.CreateLaptop(model);
        }
    }
}
