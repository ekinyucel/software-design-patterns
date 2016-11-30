using factory_c_sharp.products;

/* concrete creator */

namespace factory_c_sharp.creator
{
    class SmartHouse : House
    {
        public override void CreateFunctionality()
        {
            Functions.Add(new SmartAlarm());
            Functions.Add(new VoiceRecognition());
            Functions.Add(new PetControl());
            Functions.Add(new SteelDoor());
        }
    }
}
