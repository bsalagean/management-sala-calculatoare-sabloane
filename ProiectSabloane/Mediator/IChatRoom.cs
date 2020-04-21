using ProiectSabloane.Proxy;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProiectSabloane
{
    public interface IChatRoom
    {
        bool Register(IUser user);

        bool UnRegister(IUser user);
        void Send(string message, AccountProtected accountProtected, User reciver);
    }
}
