using System;
using System.Collections.Generic;
using System.Text;

namespace ProiectSabloane.Flyweight
{
    class CardMoney : Money
    {
        public Money Create()
        {
            return new CardMoney();
        }

        public override EMoneyType GetMoneyType()
        {
            return EMoneyType.Card;
        }

        public override bool IsSharedValue(double value)
        {
            return false;
        }
    }
}
