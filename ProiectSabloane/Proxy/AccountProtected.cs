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
       

        public IChatRoom Chatroom { get; set; }

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
            ManageComputer.cashier.GetTotalCash();
        }

        public void CashIn(int money)
        {
            ManageComputer.cashier.CashIn(money);
        }

        public Cashier GetCashVar()
        {
            return ManageComputer.cashier;
        }

        public bool SetComputerFree(int id)
        {
            if (ManageComputer.computerDealer.OrderedComputers.TryGetValue(id, out ManageComputer.computer))
            {
                ManageComputer.computerDealer.OrderedComputers.TryGetValue(id, out ManageComputer.computer);
                ManageComputer.computer.SetComputerState(EStateType.Free);
                ManageComputer.computer.Name = null;
                ManageComputer.computer.Hours = 0;
                return true;
            }
            return false;
        }

        public void Send(string message, User reciver, ChatRoom chatRoom)
        {
            chatRoom.Send(message, this, reciver);
        }

        public void Recive(IUser user, string message)
        {
            Console.WriteLine($"{user.Name}: {message} (message from admin)");
        }

        public void Summary()
        {
            ManageComputer.summary.Display();
        }
    }
}

