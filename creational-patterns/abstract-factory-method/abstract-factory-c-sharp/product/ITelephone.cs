/* Abstract Product Class */

namespace abstract_factory_c_sharp.product
{
    public interface ITelephone
    {
        void Create();
        string Model { get; set; }
    }
}
