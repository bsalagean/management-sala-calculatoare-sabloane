using ProiectSabloane.Flyweight;
using ProiectSabloane.Proxy;
using System;

namespace ProiectSabloane
{
    class Program
    {
        static void Main(string[] args)
        {
            //Factory
            //var computerDealer = new Factory.ComputerDealer();
            //computerDealer.OrderComputer(6700, 1);
            //computerDealer.OrderComputer(6800, 1);
            //computerDealer.OrderComputer(6700, 2);
            //computerDealer.OrderComputer(6700, 3);
            //computerDealer.OrderComputer(6700, 4);
            //computerDealer.StockComputer();

            //Proxy
            //acc.OrderComputer(1, 1);
            //acc.DisplayStock();
            //acc.Activate("user", "0000");
            //acc.OrderComputer(1, 1);
            //acc.DisplayStock();

            var admin = new SafeAccountProxy();
            var cash = new Cashier();

            //cash.CashIn(20, EMoneyType.Paper);
            //cash.CashIn(50, EMoneyType.Card);
            //cash.CashIn(0.5, EMoneyType.Coin);

            //cash.CashOut(10, EMoneyType.Paper);

            //cash.GetTotalCash();

            //cash.CashOut(20, EMoneyType.Card);

            //cash.GetTotalCash();
            //Console.ReadKey();

            string option;
            string optionAdmin;
            string username;
            string password;
            string newPass;
            string optionUser;

            while (true)
            {
                Console.WriteLine("1.Admin");
                Console.WriteLine("2.User");
                option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        Console.WriteLine("Please log in as admin: ");
                        Console.WriteLine("Username: ");
                        username = Console.ReadLine();
                        Console.WriteLine("Password: ");
                        password = Console.ReadLine();
                        if (password == admin.Password && username == admin.Username)
                        {
                            Console.WriteLine("Welcome Admin");
                            while (true)
                            {
                                Console.WriteLine("1. Activate");
                                Console.WriteLine("2. Order computers");
                                Console.WriteLine("3. Display stock");
                                optionAdmin = Console.ReadLine();
                                switch (optionAdmin)
                                {
                                    case "1":
                                        if (admin.isActivated == false)
                                        {
                                            Console.WriteLine("Please select a new password to activate your account");
                                            Console.WriteLine("New Password: ");
                                            newPass = Console.ReadLine();
                                            admin.Activate(newPass);
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Account already active");
                                            break;
                                        }

                                    case "2":
                                        Console.WriteLine("1. Asus Desktop");
                                        Console.WriteLine("2. HP Laptop");
                                        Console.WriteLine("3. Lenovo Desktop");
                                        Console.WriteLine("4. Mac Laptop");
                                        int orderComputerChoice;
                                        orderComputerChoice = Convert.ToInt32(Console.ReadLine());
                                        admin.OrderComputer(orderComputerChoice);
                                        break;
                                    case "3":
                                        admin.DisplayStock();
                                        break;
                                    default:
                                        break;
                                }
                            }
                        }
                        else
                            Console.WriteLine("Credentials unavailable");
                        break;
                    case "2":
                        Console.WriteLine("Welcome user");
                        while (true)
                        {
                            optionUser = Console.ReadLine();
                            switch (optionUser)
                            {
                                case "1":
                                    Console.WriteLine("Case 1");
                                    break;
                                default:
                                    break;
                            }
                        }
                    default:
                        break;
                }
            }

        }
    }
}
