using System;

namespace ProiectSabloane
{
    class Program
    {
        static void Main(string[] args)
        {
            var computerDealer = new Factory.ComputerDealer();
            computerDealer.OrderComputer(6700, 1);
            computerDealer.OrderComputer(6800, 1);
            computerDealer.OrderComputer(6700, 2);
            computerDealer.OrderComputer(6700, 3);
            computerDealer.OrderComputer(6700, 4);
            computerDealer.StockComputer();

        }
    }
}
