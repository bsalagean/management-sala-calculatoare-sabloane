using ProiectSabloane.Factory;
using ProiectSabloane.Proxy;
using ProiectSabloane.State;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProiectSabloane
{
    public class User : IUser
    {
        public string Name { get; set; }

        public List<string> messageList { get; set; }

        public void ViewComputers()
        {
            ManageComputer.computerDealer.StockComputer();
        }

        public bool ChooseComputer(int id)
        {
            if (ManageComputer.computerDealer.OrderedComputers.TryGetValue(id, out ManageComputer.computer))
            {
                ManageComputer.computerDealer.OrderedComputers.TryGetValue(id, out ManageComputer.computer);
                ManageComputer.computer.SetComputerState(EStateType.Occupied);
                ManageComputer.computer.Name = Name;
                return true;
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
    }
}
