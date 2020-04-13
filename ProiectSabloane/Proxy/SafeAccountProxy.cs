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

        public bool isActivated { get; set; }

        public SafeAccountProxy()
        {
            this.Username = "admin";
            this.Password = "admin";
            isActivated = false;
        }

        public bool Activate(string newPass)
        {
            if (Password != newPass) 
            {
                Password = newPass;
                this.RealSubject = new AccountProtected();
                Console.WriteLine("Activated");
                isActivated = true;
                return true;
            }
            else
            {
                Console.WriteLine("Cannot use the same password as before ");
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

        public void OrderComputer(int type)
        {
            if (this.RealSubject != null)
                RealSubject.OrderComputer(type);
            else
                Console.WriteLine("Inactive");
        }
    }
}
