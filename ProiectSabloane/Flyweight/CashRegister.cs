using System;
using System.Collections.Generic;
using System.Text;

namespace ProiectSabloane.Flyweight
{
    public abstract class CashRegister
    {
        private Dictionary<double, Money> _sharedMoneyMap;

        protected Money _unsharedMoney;

        public CashRegister()
        {
            _sharedMoneyMap = new Dictionary<double, Money>();
        }

        protected Money Lookup(double value)
        {
            if (_sharedMoneyMap.ContainsKey(value))
            {
                _sharedMoneyMap.TryGetValue(value, out Money returnValue);
                return returnValue;
            }
            else
            {
                if (this.IsSharedValue(value))
                {
                    _sharedMoneyMap.Add(value, CreateNewMoney());
                    _sharedMoneyMap.TryGetValue(value, out Money returnValue);

                    return returnValue;
                }
            }
            return _unsharedMoney;
        }
        public void CashIn(double value)
        {

            var money = Lookup(value);
            money.TotalCashValue += value;
        }

        public bool CashOut(double value)
        {
            var money = Lookup(value);
            if (money.TotalCashValue - value >= 0)
            {
                money.TotalCashValue -= value;
                return true;
            }
            else
            {
                Console.WriteLine("You do not have enough money!");
                return false;
            }
        }

        public double GetTotalCash()
        {
            var sum = 0.0;
            foreach (var item in _sharedMoneyMap)
            {
                sum += item.Value.TotalCashValue;
            }
            sum += _unsharedMoney.TotalCashValue;
            return sum;
        }

        public abstract Money CreateNewMoney();
        public abstract bool IsSharedValue(double value);
    }
}
