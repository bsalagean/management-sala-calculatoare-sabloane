using ProiectSabloane.Flyweight;
using ProiectSabloane.Proxy;
using System;

namespace ProiectSabloane
{
    class Program
    {
        static void Main(string[] args)
        {
            var admin = new SafeAccountProxy();
            while (true)
            {
                Console.WriteLine("1.Admin \n2.User");
                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        Console.WriteLine("Please log in as admin: ");
                        Console.WriteLine("Username: ");
                        string username = Console.ReadLine();
                        Console.WriteLine("Password: ");
                        string password = Console.ReadLine();
                        if (password == admin.Password && username == admin.Username)
                        {
                            Console.WriteLine("Welcome Admin");
                            while (true)
                            {
                                Console.WriteLine("1. Activate");
                                Console.WriteLine("2. Order computers");
                                Console.WriteLine("3. Display stock");
                                Console.WriteLine("4. Displa.y cash in register");
                                Console.WriteLine("5. Add cash");
                                Console.WriteLine("6. Set computer occ");
                                string optionAdmin = Console.ReadLine();
                                switch (optionAdmin)
                                {
                                    case "1":
                                        if (admin.isActivated == false)
                                        {
                                            Console.WriteLine("Please select a new password to activate your account");
                                            Console.WriteLine("New Password: ");
                                            string newPass = Console.ReadLine();
                                            admin.Activate(newPass);
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Account already active");
                                            break;
                                        }

                                    case "2":
                                        Console.WriteLine("1. Asus Desktop - 1500$");
                                        Console.WriteLine("2. HP Laptop - 2000$");
                                        Console.WriteLine("3. Lenovo Desktop - 1500$");
                                        Console.WriteLine("4. Mac Laptop - 5000$");
                                        Console.WriteLine("5. Back");
                                        admin.DisplayCash();
                                        int orderComputerChoice = Convert.ToInt32(Console.ReadLine());
                                        if(orderComputerChoice==5)
                                            break;
                                        admin.OrderComputer(orderComputerChoice, admin.GetCashVar());

                                        break;
                                    case "3":
                                        admin.DisplayStock();
                                        break;
                                    case "4":
                                        admin.DisplayCash();
                                        break;
                                    case "5":
                                        Console.WriteLine("Choose type:\n1.Card\n2.Paper\n3.Coins");
                                        string type = Console.ReadLine();
                                        EMoneyType eMoneyType = new EMoneyType();
                                        switch(type)
                                        {
                                            case "1":
                                                eMoneyType = EMoneyType.Card;
                                                break;
                                            case "2":
                                                eMoneyType = EMoneyType.Paper;
                                                break;
                                            case "3":
                                                eMoneyType = EMoneyType.Coin;
                                                break;
                                        }
                                        Console.WriteLine("Insert amount:");
                                        int money = Convert.ToInt32(Console.ReadLine());
                                        admin.CashIn(money, eMoneyType);
                                        break;
                                    case "6":
                                        admin.DisplayStock();
                                        Console.WriteLine("Select computer id to change the state.");
                                        int opt = Convert.ToInt32(Console.ReadLine());
                                        admin.SetComputerFree(opt);
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
                        User user = new User();
                        Console.WriteLine("Enter username.");
                        user.Name = Console.ReadLine();
                        bool usr = true;
                        do
                        {
                            Console.WriteLine("1.Display computers. \n2.Exit.");
                            string optionUser = Console.ReadLine();
                            switch (optionUser)
                            {
                                case "1":
                                    user.ViewComputers();
                                    Console.WriteLine("Enter the computer id you want.");
                                    int opt = Convert.ToInt32(Console.ReadLine());
                                    user.ChooseComputer(opt);
                                    break;
                                case "2":
                                    usr = false;
                                    break;
                            }
                        } while (usr);
                        break;
                    default:
                        break;
                }
            }

        }
    }
}
