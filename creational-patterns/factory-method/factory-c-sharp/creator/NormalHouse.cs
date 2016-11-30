using factory_c_sharp.products;

/* concrete creator */

namespace factory_c_sharp.creator
{
    class NormalHouse : House
    {
        public override void CreateFunctionality()
        {
            Functions.Add(new Alarm());
            Functions.Add(new SteelDoor());
        }
    }
}
