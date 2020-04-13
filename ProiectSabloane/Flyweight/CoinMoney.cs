using System;
using System.Collections.Generic;
using System.Text;

namespace ProiectSabloane.Flyweight
{
    class CoinMoney : Money
    {
        public override EMoneyType GetMoneyType()
        {
            return EMoneyType.Coin;
        }

        public override bool IsSharedValue(double value)
        {
            return (value == 0.01 || value == 0.1 || value == 0.05 || value == 0.5);
        }
    }
}
