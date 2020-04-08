using ProiectSabloane.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProiectSabloane.Factory
{
    public abstract class Computer
    {
        public Computer(int id, int price, string brand)
        {
            this.Id = id;
            this.Price = price;
            this.Brand = brand;
        }

        public int Id { get; set; }

        public int Price { get; set; }

        public string Brand { get; set; }

        public EUsedFor UsedFor { get; set; }

        public string Description { get; set; }

        public List<EPeripherals> Peripherals { get; set; }

        public abstract EComputerType Type { get; }

        public EComputerType ComputerType { get; set; }

        public bool Availability { get; set; }
    }
}
