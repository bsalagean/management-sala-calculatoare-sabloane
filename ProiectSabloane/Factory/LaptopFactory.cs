using System;
using System.Collections.Generic;
using System.Text;

namespace ProiectSabloane.Factory
{
    class LaptopFactory : IComputerFactory
    {
        public override Laptop GetComputer(string brand, int price)
        {
            return new Laptop(price, brand, Id++);
        }
    }
}
