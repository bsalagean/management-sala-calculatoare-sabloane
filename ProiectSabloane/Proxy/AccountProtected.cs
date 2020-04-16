using ProiectSabloane.Factory;
using ProiectSabloane.Flyweight;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProiectSabloane.Proxy
{
    public class AccountProtected : IAccount
    {
        public ComputerDealer computerDealer = new ComputerDealer();
        public Cashier cashier = new Cashier();
        

        public void DisplayStock()
        {
            computerDealer.StockComputer();
        }

        public void OrderComputer(int type, Cashier cash)
        {
            computerDealer.OrderComputer(type, cash);
        }

        public void DisplayCash()
        {
            cashier.GetTotalCash();
        }

        public void CashIn(int money, EMoneyType type)
        {
            cashier.CashIn(money, type);
        }

        public Cashier GetCashVar()
        {
            return cashier;
        }
    }
}
