using System;
using System.Collections.Generic;
using System.Text;

namespace ProiectSabloane.Flyweight
{
    public class CashRegisterCard : CashRegister
    {

        public CashRegisterCard()
        {
            _unsharedMoney = CreateNewMoney();
        }

        public override Money CreateNewMoney()
        {
            return new CardMoney();
        }

        public override bool IsSharedValue(double value)
        {
            return _unsharedMoney.IsSharedValue(value);
        }
    }
}
