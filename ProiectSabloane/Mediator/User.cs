using ProiectSabloane.Factory;
using ProiectSabloane.Proxy;
using ProiectSabloane.State;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProiectSabloane
{
    public class User : IUser, Element
    {
        public string Name { get; set; }

        public List<string> messageList { get; set; }

        public void ViewComputers()
        {
            ManageComputer.computerDealer.StockComputer();
        }

        public bool ChooseComputer(int id, int hours)
        {
            if (ManageComputer.computerDealer.OrderedComputers.TryGetValue(id, out ManageComputer.computer))
            {
                if(ManageComputer.computer.Name == null)
                {
                    ManageComputer.computerDealer.OrderedComputers.TryGetValue(id, out ManageComputer.computer);
                    ManageComputer.computer.SetComputerState(EStateType.Occupied);
                    ManageComputer.computer.Name = Name;
                    ManageComputer.computer.Hours = hours;
                    ManageComputer.cashier.CashIn(10 * hours);
                    ManageComputer.computer.Accept(ManageComputer.summary);
                    return true;
                }
                else
                {
                    Console.WriteLine("Computer is not free !");
                    return false;
                }
            }
            return false;
        }

        public IChatRoom Chatroom { get; set; }

        public User()
        {
            this.messageList = new List<String>();
        }

        public User(IChatRoom Chatroom)
        {
            this.Chatroom = Chatroom;
        }

        public void Recive(string message)
        {
            Console.WriteLine($"Admin ai trimis urmatorul mesaj: {message} !");
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
