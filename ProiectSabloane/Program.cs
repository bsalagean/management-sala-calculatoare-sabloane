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
            ChatRoom chatRoom = new ChatRoom("Notifications");
            while (true)
            {
                Console.WriteLine("----------------" + "\n1. Admin " + "\n2. User " + "\n3. Existing user" + "\n----------------");
                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        Console.WriteLine("\nPlease log in as admin: ");
                        Console.Write("     Username: ");
                        string username = Console.ReadLine();
                        Console.Write("     Password: ");
                        string password = Console.ReadLine();

                        if (password == admin.Password && username == admin.Username)
                        {
                            Console.WriteLine("\n----------------------------------------------------------" +"\nWelcome Admin");
                            bool usr = true;
                            do
                            {
                                Console.WriteLine("-------------\n"+
                                    "1. Activate \n" +
                                    "2. Order computers \n" +
                                    "3. Display stock \n" +
                                    "4. Display cash in register \n" +
                                    "5. Add cash \n" +
                                    "6. Set computer free \n" +
                                    "7. Chatrooms \n" +
                                    "8. Summary \n" +
                                    "9. Exit \n" +
                                    "-----------------");
                                string optionAdmin = Console.ReadLine();
                                switch (optionAdmin)
                                {
                                    case "1":
                                        if (admin.isActivated == false)
                                        {
                                            Console.WriteLine("\nPlease select a new password to activate your account");
                                            Console.Write("     New Password: ");
                                            string newPass = Console.ReadLine();
                                            admin.Activate(newPass);
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("     Account already active  !");
                                            break;
                                        }

                                    case "2":
                                        Console.WriteLine("\n--------------------------\n" +
                                            "1. Asus Desktop   -  1500$\n" +
                                            "2. HP Laptop      -  2000$\n" +
                                            "3. Lenovo Desktop -  1500$\n" +
                                            "4. Mac Laptop     -  5000$\n" +
                                            "5. Back\n" +
                                            "--------------------------");
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
                                        Console.Write("\nInsert amount of money you want to cash in: ");
                                        int money = Convert.ToInt32(Console.ReadLine());
                                        admin.CashIn(money);
                                        break;
                                    case "6":
                                        admin.DisplayStock();
                                        Console.Write("Select computer id to change the state: ");
                                        int opt = Convert.ToInt32(Console.ReadLine());
                                        admin.SetComputerFree(opt);
                                        break;
                                    case "7":
                                        chatRoom.DisplayUsers();
                                        Console.WriteLine($"\n{chatRoom.Name}" + "\nChoose client:");
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
                            Console.WriteLine("\n     Credentials unavailable   !!!\n");
                        break;
                    case "2":
                        Console.WriteLine("\nWelcome user");
                        User user = new User();
                        Console.Write("Enter username: ");
                        user.Name = Console.ReadLine();
                        userList.Add(user);
                        break;
                    case "3":
                        userList.ForEach(element =>
                        {
                            Console.WriteLine($"Id: {userList.IndexOf(element)} Username: {element.Name}");
                        });
                        Console.Write("Type your id: ");
                        int userId = Convert.ToInt32(Console.ReadLine());
                        if (userList.Find(x => userList.IndexOf(x) == userId) != null)
                        {
                            User connectedUser = userList.Find(x => userList.IndexOf(x) == userId);
                            bool usr = true;
                            do
                            {
                                Console.WriteLine("\n1.Display computers. \n2.Notifications \n3.Exit ");
                                string optionUser = Console.ReadLine();
                                switch (optionUser)
                                {
                                    case "1":
                                        connectedUser.ViewComputers();
                                        Console.Write("Enter the computer id you want: ");
                                        int opt = Convert.ToInt32(Console.ReadLine());
                                        Console.Write("For how many hours would you like the computer(min. 1H, max. 10H): ");
                                        int optHours = Convert.ToInt32(Console.ReadLine());
                                        if (optHours >= 1 && optHours <= 10)
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
                            Console.WriteLine("Try again.");
                        }
                        break;
                    default:
                        break;
                }
            }

        }
    }
}
