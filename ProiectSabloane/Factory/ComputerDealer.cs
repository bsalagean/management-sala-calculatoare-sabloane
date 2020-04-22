using ProiectSabloane.Flyweight;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProiectSabloane.Factory
{
    public class ComputerDealer
    {

        public ComputerDealer()
        {
            OrderedComputers = new Dictionary<int, Computer>();
            OrderedComputers.Add(AbstractComputerFactory.AsusComputerFactory.Id, new AbstractComputerFactory.AsusComputerFactory().GetDesktop(1500));
            OrderedComputers.Add(AbstractComputerFactory.HPComputerFactory.Id, new AbstractComputerFactory.HPComputerFactory().GetLaptop(2000));
            OrderedComputers.Add(AbstractComputerFactory.LenovoComputerFactory.Id, new AbstractComputerFactory.LenovoComputerFactory().GetDesktop(1500));
            OrderedComputers.Add(AbstractComputerFactory.MacComputerFactory.Id, new AbstractComputerFactory.MacComputerFactory().GetLaptop(5000));

        }

        public Dictionary<int, Computer> OrderedComputers { get; set; }

        public int OrderComputer(int computerBrand, Cashier cash)
        {
            int price;
            switch (computerBrand)
            {
                case 1:
                    price = 1500;
                    if (cash.CashOut(price))
                    {
                        OrderedComputers.Add(AbstractComputerFactory.AsusComputerFactory.Id, new AbstractComputerFactory.AsusComputerFactory().GetDesktop(price));
                        Console.WriteLine($"Computer was ordered : {price} => ID {DesktopFactory.Id} => AsusComputerFactory Desktop");
                        return AbstractComputerFactory.AsusComputerFactory.Id;
                    }
                    else
                    {
                        return 0;
                    }

                case 2:
                    price = 2000;

                    if (cash.CashOut(price))
                    {
                        OrderedComputers.Add(AbstractComputerFactory.HPComputerFactory.Id, new AbstractComputerFactory.HPComputerFactory().GetLaptop(2000));
                        Console.WriteLine($"Computer was ordered : {2000} => ID {LaptopFactory.Id} => HPComputerFactory Laptop");
                        return AbstractComputerFactory.HPComputerFactory.Id;
                    }

                    else
                    {
                        return 0;
                    }
                case 3:
                    price = 1500;
                    if (cash.CashOut(price))
                    {
                        OrderedComputers.Add(AbstractComputerFactory.LenovoComputerFactory.Id, new AbstractComputerFactory.LenovoComputerFactory().GetDesktop(1500));
                        Console.WriteLine($"Computer was ordered : {1500} => ID {DesktopFactory.Id} => LenovoComputerFactory Desktop");
                        return AbstractComputerFactory.LenovoComputerFactory.Id;
                    }
                    else
                    {
                        return 0;
                    }
                case 4:
                    price = 5000;
                    if (cash.CashOut(price))
                    {
                        OrderedComputers.Add(AbstractComputerFactory.MacComputerFactory.Id, new AbstractComputerFactory.MacComputerFactory().GetLaptop(5000));
                        Console.WriteLine($"Computer was ordered : {5000} => ID {DesktopFactory.Id} => MacComputerFactory Laptop");
                        return AbstractComputerFactory.MacComputerFactory.Id;
                    }
                    else
                    {
                        return 0;
                    }
                default:
                    return -1;
            }
        }

        public void StockComputer()
        {
            foreach (var computer in OrderedComputers)
            {
                Console.WriteLine("Stock From Order:" + computer.Value.Id + " " + computer.Value.Brand + " " + 
                    computer.Value.Price + " " + "state: " + computer.Value.computerState.ToString() + " Used by: " 
                    + computer.Value.Name + "Hours occupied : "+ computer.Value.Hours + " " + computer.Value.Type.ToString());
            }
        }

    }
}
