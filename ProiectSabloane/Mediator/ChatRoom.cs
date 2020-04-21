using ProiectSabloane.Proxy;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProiectSabloane
{
    public class ChatRoom : IChatRoom
    {
        public string Name { get; set; }
        public List<IUser> users { get; set; }

        public ChatRoom()
        {
            this.users = new List<IUser>();
        }

        public ChatRoom(string name)
        {
            Name = name;
            this.users = new List<IUser>();
        }

        public void Send(string message, AccountProtected sender, User reciver)
        {
            if (sender != null)
            {
                if (reciver != null)
                {
                    if (users.Contains(reciver))
                    {
                        reciver.Recive(message);
                        reciver.messageList.Add(message);
                    }
                    else
                        Console.WriteLine("Invalid reciever");
                }
            }

        }

        public bool Register(IUser user)
        {
            if (users.Contains(user))
            {
                return false;
            }

            users.Add(user);
            return true;
        }

        public bool UnRegister(IUser user)
        {
            if (!users.Contains(user))
            {
                return false;
            }

            users.Remove(user);
            return true;
        }

        public void DisplayUsers()
        {
            foreach (var u in users)
                Console.WriteLine($"Name: {u.Name}");
        }
    }
}
