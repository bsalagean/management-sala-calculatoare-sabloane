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
        }

        public Dictionary<int, Computer> OrderedComputers { get; set; }

        public int OrderComputer(int price, int computerBrand)
        {
            switch (computerBrand)
            {
                case 1:
                    OrderedComputers.Add(AbstractComputerFactory.AsusComputerFactory.Id, new AbstractComputerFactory.AsusComputerFactory().GetDesktop(price));
                    Console.WriteLine($"Computer was ordered : {price} => ID {DesktopFactory.Id} => AsusComputerFactory Desktop");
                    return AbstractComputerFactory.AsusComputerFactory.Id;
                case 2:
                    OrderedComputers.Add(AbstractComputerFactory.HPComputerFactory.Id, new AbstractComputerFactory.HPComputerFactory().GetLaptop(price));
                    Console.WriteLine($"Computer was ordered : {price} => ID {LaptopFactory.Id} => HPComputerFactory Laptop");
                    return AbstractComputerFactory.HPComputerFactory.Id;
                case 3:
                    OrderedComputers.Add(AbstractComputerFactory.LenovoComputerFactory.Id, new AbstractComputerFactory.LenovoComputerFactory().GetDesktop(price));
                    Console.WriteLine($"Computer was ordered : {price} => ID {DesktopFactory.Id} => AsusComputerFactory Desktop");
                    return AbstractComputerFactory.LenovoComputerFactory.Id;
                case 4:
                    OrderedComputers.Add(AbstractComputerFactory.MacComputerFactory.Id, new AbstractComputerFactory.MacComputerFactory().GetLaptop(price));
                    Console.WriteLine($"Computer was ordered : {price} => ID {DesktopFactory.Id} => MacComputerFactory Laptop");
                    return AbstractComputerFactory.MacComputerFactory.Id;
                default:
                    return -1;
            }


        }

        public void StockComputer()
        {
            foreach (var computer in OrderedComputers)
            {
                Console.WriteLine("Stock From Order:" + computer.Value.Id + " " + computer.Value.Brand + " "  + computer.Value.Price + " " + computer.Value.Type.ToString());
            }
        }

    }
}
