using System;
using System.Collections.Generic;
using System.Text;

namespace ProiectSabloane.Factory
{
    class Desktop : Computer
    {
        public Desktop(int price, string brand, int id) : base(price, brand, id)
        {
        }

        public override EComputerType Type => EComputerType.EDesktop;
    }
}
