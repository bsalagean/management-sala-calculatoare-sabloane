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
        public Cashier cashier = new Cashier();

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

        public void Send(string message, User reciver, ChatRoom chatRoom)
        {
            chatRoom.Send(message, this, reciver);
        }

        public void Recive(IUser user, string message)
        {
            Console.WriteLine($"{user.Name}: {message} (mesaj de la admin)");
        }

        public void Summary()
        {
            ManageComputer.summary.Display();
        }
    }
}

