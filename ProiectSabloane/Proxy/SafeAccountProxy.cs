using ProiectSabloane.Factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProiectSabloane.Proxy
{
    class SafeAccountProxy : IAccount
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public AccountProtected RealSubject { get; set; }

        public SafeAccountProxy()
        {
            this.Username = "user";
            this.Password = "0000";
        }

        public bool Activate(string username, string pass)
        {
            if (this.Username == username && this.Password == pass)
            {
                this.RealSubject = new AccountProtected();
                Console.WriteLine("Activated");
                return true;
            }
            else
            {
                Console.WriteLine("Inactive account");
                return false;
            }
        }

        public void DisplayStock()
        {
            if (this.RealSubject != null)
                RealSubject.DisplayStock();
            else
                Console.WriteLine("Inactive");
        }

        public void OrderComputer(int price, int type)
        {
            if (this.RealSubject != null)
                RealSubject.OrderComputer(price, type);
            else
                Console.WriteLine("Inactive");
        }
    }
}
