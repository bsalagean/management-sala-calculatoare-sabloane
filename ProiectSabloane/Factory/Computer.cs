using ProiectSabloane.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using ProiectSabloane.State;

namespace ProiectSabloane.Factory
{
    public abstract class Computer : Element
    {
        public State.State computerState;
        public string Name { get; set; }

        public int Hours { get; set; }

        public Computer(int id, int price, string brand)
        {
            this.Id = id;
            this.Price = price;
            this.Brand = brand;

            computerState = new FreeState(this);
            this.Name = null;

            Hours = 0;
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

        public void SetComputerState(EStateType state)
        {
            switch(state)
            {
                case EStateType.Free:
                    this.computerState = new FreeState(this);
                    return;
                case EStateType.Occupied:
                    this.computerState = new OccupiedState(this);
                    return;
            }
        }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitTotalDayliHours(this);
        }
    }
}
