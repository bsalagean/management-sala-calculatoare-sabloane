using System;
using System.Collections.Generic;
using System.Text;

namespace ProiectSabloane.Factory
{
    public abstract class IComputerFactory
    {
        public abstract Computer GetComputer(string brand, int price);

        public static int Id { get; set; } = 0;
    }
}
