using ProiectSabloane.Factory;
using ProiectSabloane.Flyweight;
using ProiectSabloane.State;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProiectSabloane.Proxy
{
    public class AccountProtected : IAccount
    {
        public ComputerDealer computerDealer = new ComputerDealer();
        public ManageComputer manageComputer = new ManageComputer();
        public Cashier cashier = new Cashier();
        protected Computer comp;

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

        public bool SetComputerFree(int id)
        {
            if (computerDealer.OrderedComputers.TryGetValue(id, out comp))
            {
                computerDealer.OrderedComputers.TryGetValue(id, out comp);
                comp.SetComputerState(EStateType.Free);
                comp.Name = null;
                return true;
            }
            return false;
        }
    }
}

