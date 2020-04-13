using ProiectSabloane.Factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProiectSabloane.Proxy
{
    public class AccountProtected : IAccount
    {
        public ComputerDealer computerDealer = new ComputerDealer();

        public void DisplayStock()
        {
            computerDealer.StockComputer();
        }

        public void OrderComputer(int type)
        {
            computerDealer.OrderComputer(type);
        }
    }
}
