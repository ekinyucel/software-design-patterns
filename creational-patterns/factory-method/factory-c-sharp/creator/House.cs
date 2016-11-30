using System.Collections.Generic;
using factory_c_sharp.products;

/* Creator */

namespace factory_c_sharp.creator
{
    abstract class House
    {
        private readonly List<Function> _functions = new List<Function>();

        public House()
        {
            this.CreateFunctionality();   
        }

        public List<Function> Functions => _functions;

        // factory method
        public abstract void CreateFunctionality();
    }
}
