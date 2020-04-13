using System;
using System.Collections.Generic;
using System.Text;

namespace ProiectSabloane.Flyweight
{
    class CashRegisterPaper : CashRegister
    {
        public CashRegisterPaper()
        {
            _unsharedMoney = CreateNewMoney();
        }

        public override Money CreateNewMoney()
        {
            return new PaperMoney();
        }

        public override bool IsSharedValue(double value)
        {
            return _unsharedMoney.IsSharedValue(value);
        }
    }
}
