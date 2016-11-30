using System;
using factory_c_sharp.creator;

namespace factory_c_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var houses = new House[2];
            houses[0] = new NormalHouse();
            houses[1] = new SmartHouse();

            foreach (var house in houses)
            {
                Console.WriteLine("\n" + house.GetType().Name + "--");
                foreach (var function in house.Functions)
                {
                    Console.WriteLine(" " + function.GetType().Name);
                }
            }

            Console.ReadKey();
        }
    }
}
