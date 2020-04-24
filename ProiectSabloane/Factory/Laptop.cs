using System;
using System.Collections.Generic;
using System.Text;

namespace ProiectSabloane.Factory
{
    class Laptop : Computer
    {
        public Laptop(int id, int price, string brand) : base(id, price, brand) {}

        public override EComputerType Type => EComputerType.ELaptop;
    }
}
