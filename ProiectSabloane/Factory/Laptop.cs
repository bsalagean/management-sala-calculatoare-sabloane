using System;
using System.Collections.Generic;
using System.Text;

namespace ProiectSabloane.Factory
{
    class Laptop : Computer
    {
        public Laptop(int price, string brand, int id) : base(price, brand, id)
        {
        }

        public override EComputerType Type => EComputerType.ELaptop;
    }
}
