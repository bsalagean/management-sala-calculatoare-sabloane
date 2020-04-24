using ProiectSabloane.Flyweight;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProiectSabloane.Proxy
{
    public interface IAccount
    {
        void DisplayStock();

        void OrderComputer(int type, Cashier cash);

        void DisplayCash();

        void CashIn(int money);

        Cashier GetCashVar();

        bool SetComputerFree(int id);

        void Send(string message, User reciver, ChatRoom chatRoom);

        void Summary();
    }
}
