using System;
using abstract_factory_c_sharp.factories;

namespace abstract_factory_c_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            TechFactory samsung = new SamsungFactory();
            var client = new Client(samsung);
            client.CreateTelephone("Galaxy S5");

            Console.ReadKey();
        }
    }
}
