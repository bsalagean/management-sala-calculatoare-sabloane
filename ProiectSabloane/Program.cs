using ProiectSabloane.Flyweight;
using ProiectSabloane.Proxy;
using System;
using System.Collections.Generic;

namespace ProiectSabloane
{
    class Program
    {
        static void Main(string[] args)
        {
            var admin = new SafeAccountProxy();
            List<User> userList = new List<User>();
            ChatRoom chatRoom = new ChatRoom("nume");
            while (true)
            {
                Console.WriteLine("1.Admin \n2.User \n3.Existing user");
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
                            bool usr = true;
                            do
                            {
                                Console.WriteLine("1. Activate");
                                Console.WriteLine("2. Order computers");
                                Console.WriteLine("3. Display stock");
                                Console.WriteLine("4. Display cash in register");
                                Console.WriteLine("5. Add cash");
                                Console.WriteLine("6. Set computer free");
                                Console.WriteLine("7. Chatrooms");
                                Console.WriteLine("8. Summary");
                                Console.WriteLine("9. Exit");
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
                                        if (orderComputerChoice == 5)
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
                                        switch (type)
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
                                    case "7":
                                        chatRoom.DisplayUsers();
                                        Console.WriteLine($"{chatRoom.Name}");
                                        Console.WriteLine("Choose client");
                                        int selectedUserId = Convert.ToInt32(Console.ReadLine());
                                        User selectedUser = new User();
                                        if (userList.Find(x => userList.IndexOf(x) == selectedUserId) != null)
                                        {
                                            selectedUser = userList.Find(x => userList.IndexOf(x) == selectedUserId);
                                            Console.WriteLine("Message...");
                                            string message = Console.ReadLine();
                                            admin.Send(message, selectedUser, chatRoom);
                                        }
                                        break;
                                    case "8":
                                        admin.Summary();
                                        break;
                                    case "9":
                                        usr = false;
                                        break;
                                    default:
                                        break;
                                }
                            } while (usr);
                        }
                        else
                            Console.WriteLine("Credentials unavailable");
                        break;
                    case "2":
                        Console.WriteLine("Welcome user");
                        User user = new User();
                        Console.WriteLine("Enter username.");
                        user.Name = Console.ReadLine();
                        userList.Add(user);
                        break;
                    case "3":
                        userList.ForEach(element =>
                        {
                            Console.WriteLine($"Id: {userList.IndexOf(element)}, Name: {element.Name}");
                        });
                        Console.WriteLine("Type your id");
                        int userId = Convert.ToInt32(Console.ReadLine());
                        if (userList.Find(x => userList.IndexOf(x) == userId) != null)
                        {
                            User connectedUser = userList.Find(x => userList.IndexOf(x) == userId);
                            bool usr = true;
                            do
                            {
                                Console.WriteLine("1.Display computers. \n2.Notifications \n3.Exit ");
                                string optionUser = Console.ReadLine();
                                switch (optionUser)
                                {
                                    case "1":
                                        connectedUser.ViewComputers();
                                        Console.WriteLine("Enter the computer id you want.");
                                        int opt = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("For how many hours would you like the computer(min. 1H, max. 10H).");
                                        int optHours = Convert.ToInt32(Console.ReadLine());
                                        if (optHours > 1 && optHours < 10)
                                        {
                                            connectedUser.ChooseComputer(opt, optHours);
                                            chatRoom.Register(connectedUser);
                                            connectedUser.Accept(ManageComputer.summary);
                                            
                                        }else
                                            Console.WriteLine("The number of hours introduced is invalid");
                                        break;
                                    case "2":
                                        foreach (var item in connectedUser.messageList)
                                        {
                                            Console.WriteLine(item);
                                        }
                                        break;
                                    case "3":
                                        usr = false;
                                        break;
                                }
                            } while (usr);
                        }
                        else
                        {
                            Console.WriteLine("Incearca din nou");
                        }
                        break;
                    default:
                        break;
                }
            }

        }
    }
}
