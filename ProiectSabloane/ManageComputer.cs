using ProiectSabloane.Factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProiectSabloane
{
    public class ManageComputer
    {
        public static ComputerDealer computerDealer { get; set; }
        public static Computer computer;

        static ManageComputer()
        {
            computerDealer = new ComputerDealer();
            
        }
    }
}
