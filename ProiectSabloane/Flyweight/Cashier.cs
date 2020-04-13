using System;
using System.Collections.Generic;
using System.Text;

namespace ProiectSabloane.Flyweight
{
    public class Cashier
    {
        private CashRegisterCoin _coinMoney;
        private CashRegisterPaper _paperMoney;
        private CashRegisterCard _cardMoney;

        public Cashier()
        {
            _coinMoney = new CashRegisterCoin();
            _paperMoney = new CashRegisterPaper();
            _cardMoney = new CashRegisterCard();
        }

        public void CashIn(double value, EMoneyType type)
        {
            switch (type)
            {
                case EMoneyType.Card:
                    _cardMoney.CashIn(value);
                    break;
                case EMoneyType.Coin:
                    _coinMoney.CashIn(value);
                    break;
                case EMoneyType.Paper:
                    _paperMoney.CashIn(value);
                    break;
            }
        }

        public void CashOut(double value, EMoneyType type)
        {
            switch (type)
            {
                case EMoneyType.Card:
                    _cardMoney.CashOut(value);
                    break;
                case EMoneyType.Coin:
                    _coinMoney.CashOut(value);
                    break;
                case EMoneyType.Paper:
                    _paperMoney.CashOut(value);
                    break;
            }
        }

        public void GetTotalCash()
        {
            var sum = _coinMoney.GetTotalCash() + _paperMoney.GetTotalCash() + _cardMoney.GetTotalCash();
            Console.WriteLine(" Total money = " + sum);
        }
    }
}
