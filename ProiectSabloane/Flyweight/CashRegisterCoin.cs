using System;
using System.Collections.Generic;
using System.Text;

namespace ProiectSabloane.Flyweight
{
    public class CashRegisterCoin : CashRegister
    {

        public CashRegisterCoin()
        {
            _unsharedMoney = CreateNewMoney();
        }

        public override Money CreateNewMoney()
        {
            return new CoinMoney();
        }

        public override bool IsSharedValue(double value)
        {
            return _unsharedMoney.IsSharedValue(value);
        }
    }
}
