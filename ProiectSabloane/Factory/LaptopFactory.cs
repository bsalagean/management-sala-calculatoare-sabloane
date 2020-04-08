using System;
using System.Collections.Generic;
using System.Text;

namespace ProiectSabloane.Factory
{
    class LaptopFactory : IComputerFactory
    {
        public override Computer GetComputer(string brand, int price)
        {
            return new Laptop(Id++, price, brand);
        }
    }
}
