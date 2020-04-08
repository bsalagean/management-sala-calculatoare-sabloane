using System;
using System.Collections.Generic;
using System.Text;

namespace ProiectSabloane.Factory
{
    class DesktopFactory : IComputerFactory
    {
        public override Computer GetComputer(string brand, int price)
        {
            return new Desktop(Id++, price, brand);
        }
    }
}
