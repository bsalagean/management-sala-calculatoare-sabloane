using ProiectSabloane.Proxy;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProiectSabloane
{
    public interface IUser
    {
        string Name { get; set; }

        IChatRoom Chatroom { get; set; }

        void Recive(string message);
    }
}
