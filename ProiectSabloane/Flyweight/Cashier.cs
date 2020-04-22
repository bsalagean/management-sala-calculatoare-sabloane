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
        private double sum { get; set; }

        public Cashier()
        {
            _coinMoney = new CashRegisterCoin();
            _paperMoney = new CashRegisterPaper();
            _cardMoney = new CashRegisterCard();
            //this.CashIn(10000, EMoneyType.Card);
            //this.CashIn(0.5, EMoneyType.Coin);
            //this.CashIn(100, EMoneyType.Paper);
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

        public bool CashOut(double value)
        {
            Console.WriteLine("Choose a method:");
            Console.WriteLine("1.Card");
            Console.WriteLine("2.Paper");
            Console.WriteLine("3.Coin");
            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    if (_cardMoney.CashOut(value))
                        return true;
                    return false;
                case "2":
                    if (_paperMoney.CashOut(value))
                        return true;
                    return false;
                case "3":
                    if (_coinMoney.CashOut(value))
                        return true;
                    return false;
            }
            return false;
        }

        public double GetTotalCash()
        {
            sum = _coinMoney.GetTotalCash() + _paperMoney.GetTotalCash() + _cardMoney.GetTotalCash();
            Console.WriteLine("Total money = " + sum);
            Console.WriteLine("Card=" + _cardMoney.GetTotalCash() + " Paper=" + _paperMoney.GetTotalCash()
                + " Coin=" + _coinMoney.GetTotalCash());
            return sum;
        }
    }
}
