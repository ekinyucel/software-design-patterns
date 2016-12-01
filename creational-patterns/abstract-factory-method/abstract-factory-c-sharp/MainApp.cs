using System;
using abstract_factory_c_sharp.factories;

namespace abstract_factory_c_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var samsungClient = new Client<SamsungFactory>();
            samsungClient.CreateTelephone("Galaxy S5");
            samsungClient.CreateLaptop("Hive 9");

            Console.ReadKey();
        }
    }
}
