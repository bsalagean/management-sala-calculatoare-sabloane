using ProiectSabloane.Factory;
using ProiectSabloane.Flyweight;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProiectSabloane.Proxy
{
    public class SafeAccountProxy : IAccount
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

        public void OrderComputer(int type, Cashier cash)
        {
            if (this.RealSubject != null)
                RealSubject.OrderComputer(type, cash);
            else
                Console.WriteLine("Inactive");
        }

        public void DisplayCash()
        {
            if (this.RealSubject != null)
                RealSubject.DisplayCash();
            else
                Console.WriteLine("Inactive");
        }

        public void CashIn(int money, EMoneyType type)
        {
            if (this.RealSubject != null)
                RealSubject.CashIn(money, type);
            else
                Console.WriteLine("Inactive");
        }

        public Cashier GetCashVar()
        {
            if (this.RealSubject != null)
                return RealSubject.GetCashVar();
            else
            {
                Console.WriteLine("Inactive");
                return null;
            }
        }

        public bool SetComputerFree(int id)
        {
            if (this.RealSubject != null)
                return RealSubject.SetComputerFree(id);
            else
            {
                Console.WriteLine("Inactive");
                return false;
            }
        }

        public void Send(string message, User reciver, ChatRoom chatRoom)
        {
            if (this.RealSubject != null)
                RealSubject.Send(message, reciver, chatRoom);
            else
            {
                Console.WriteLine("Inactive");
            }
        }
    }
}
