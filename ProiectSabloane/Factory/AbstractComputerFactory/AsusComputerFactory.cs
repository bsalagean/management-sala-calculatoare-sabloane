using System;
using System.Collections.Generic;
using System.Text;

namespace ProiectSabloane.Factory.AbstractComputerFactory
{
    public class AsusComputerFactory : AbstractComputerFactory
    {
        public override Computer GetDesktop(int price)
        {
            return new Desktop(price, "Asus", Id++);
        }

        public override Computer GetLaptop(int price)
        {
            return new Laptop(price, "Asus", Id++);
        }
    }
}
