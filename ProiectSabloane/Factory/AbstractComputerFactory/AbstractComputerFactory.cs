using System;
using System.Collections.Generic;
using System.Text;

namespace ProiectSabloane.Factory.AbstractComputerFactory
{
    public abstract class AbstractComputerFactory
    {
        public abstract Computer GetDesktop(int price);

        public abstract Computer GetLaptop(int price);

        public static int Id { get; set; } = 0;
    }
}
