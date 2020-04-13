using System;
using System.Collections.Generic;
using System.Text;

namespace ProiectSabloane.Flyweight
{
    public abstract class Money
    {
        public double TotalCashValue { get; set; }

        public abstract EMoneyType GetMoneyType();

        public abstract bool IsSharedValue(double value);
    }
}
