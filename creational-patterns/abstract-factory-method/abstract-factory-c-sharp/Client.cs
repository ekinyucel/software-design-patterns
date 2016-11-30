using abstract_factory_c_sharp.factories;
using abstract_factory_c_sharp.product;

namespace abstract_factory_c_sharp
{
    class Client
    {
        private TechFactory _techFactory;
        private Telephone _telephone;
        private Laptop _laptop;

        public Client(TechFactory techFactory)
        {
            //_telephone = techFactory.CreateTelephone();
            //_laptop = techFactory.CreateLaptop();
            _techFactory = techFactory;
        }

        public void CreateTelephone(string type)
        {
            _techFactory.CreateTelephone(type);
        }
    }
}
