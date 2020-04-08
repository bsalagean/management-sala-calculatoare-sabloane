using System;
using System.Collections.Generic;
using System.Text;

namespace ProiectSabloane.Factory.AbstractComputerFactory
{
    public class HPComputerFactory : AbstractComputerFactory
    {
        public override Computer GetDesktop(int price)
        {
            return new Desktop(Id++, price, "Hp");
        }

        public override Computer GetLaptop(int price)
        {
            return new Laptop(Id++, price, "Hp");
        }
    }
}
