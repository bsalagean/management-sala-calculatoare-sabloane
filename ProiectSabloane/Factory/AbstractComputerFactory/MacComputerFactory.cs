using System;
using System.Collections.Generic;
using System.Text;

namespace ProiectSabloane.Factory.AbstractComputerFactory
{
    public class MacComputerFactory : AbstractComputerFactory
    {
        public override Computer GetDesktop(int price)
        {
            return new Desktop(Id++, price, "Mac");
        }

        public override Computer GetLaptop(int price)
        {
            return new Laptop(Id++, price, "Mac");
        }
    }
}
