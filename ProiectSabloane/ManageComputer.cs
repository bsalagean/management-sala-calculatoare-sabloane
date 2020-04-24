using ProiectSabloane.Factory;
using ProiectSabloane.Flyweight;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProiectSabloane
{
    public class ManageComputer
    {
        public static ComputerDealer computerDealer { get; set; }
        public static Computer computer;
        public static Cashier cashier { get; set; }

        public static Summary summary { get; set; }

        static ManageComputer()
        {
            computerDealer = new ComputerDealer();
            summary = new Summary();
            cashier = new Cashier();
        }
    }
}
