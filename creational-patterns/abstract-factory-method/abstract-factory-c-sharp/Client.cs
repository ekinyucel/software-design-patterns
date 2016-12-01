using abstract_factory_c_sharp.factories;
using abstract_factory_c_sharp.product;

namespace abstract_factory_c_sharp
{
    public class Client<T> where T : ITechFactory, new()
    {
        private ITelephone _telephone;
        private ILaptop _laptop;
        private readonly T _factory;

        public Client()
        {
            _factory = new T();
        }

        public void CreateTelephone(string model)
        {
            _telephone = _factory.CreateTelephone(model);
        }

        public void CreateLaptop(string model)
        {
            _laptop = _factory.CreateLaptop(model);
        }
    }
}
