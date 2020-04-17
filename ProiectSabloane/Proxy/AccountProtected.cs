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
       // public ComputerDealer computerDealer = new ComputerDealer();
        public Cashier cashier = new Cashier();
        //protected Computer comp;

        public void DisplayStock()
        {
           ManageComputer.computerDealer.StockComputer();
        }

        public void OrderComputer(int type, Cashier cash)
        {
            ManageComputer.computerDealer.OrderComputer(type, cash);
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
            if (ManageComputer.computerDealer.OrderedComputers.TryGetValue(id, out ManageComputer.computer))
            {
                ManageComputer.computerDealer.OrderedComputers.TryGetValue(id, out ManageComputer.computer);
                ManageComputer.computer.SetComputerState(EStateType.Free);
                ManageComputer.computer.Name = null;
                return true;
            }
            return false;
        }
    }
}

