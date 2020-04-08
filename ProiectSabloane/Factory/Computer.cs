using System;
using System.Collections.Generic;
using System.Text;

namespace ProiectSabloane.Factory
{
    public abstract class Computer
    {
        public Computer(int id, int price, string brand)
        {
            this.Brand = brand;
            this.Id = id;
            this.Price = price;
        }

        public int Id { get; set; }

        public int Price { get; set; }

        public string Brand { get; set; }

        public abstract EComputerType Type { get; }
    }
}
