using System;
using System.Collections.Generic;
using System.Text;

namespace ProiectSabloane.Flyweight
{
    public class Cashier
    {
        private CashRegisterPaper _paperMoney;
        private CashRegisterCard _cardMoney;
        private double sum { get; set; }

        public Cashier()
        {
            _paperMoney = new CashRegisterPaper();
            _cardMoney = new CashRegisterCard();
        }

        public void CashIn(double value)
        {
            Console.WriteLine("Choose cash in method:\n" + "    1. Card\n" + "    2. Paper");
            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    _cardMoney.CashIn(value);
                    break;
                case "2":
                    _paperMoney.CashIn(value);
                    break;
                default:
                    break;
            }
        }

        public bool CashOut(double value)
        {
            Console.WriteLine("Choose a method:");
            Console.WriteLine("1.Card");
            Console.WriteLine("2.Paper");
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
                default:
                    break;
            }
            return false;
        }

        public double GetTotalCash()
        {
            sum = _paperMoney.GetTotalCash() + _cardMoney.GetTotalCash();
            Console.WriteLine("\nTotal money = " + sum +
                "\n   Card = " + _cardMoney.GetTotalCash() + 
                "\n   Cash = " + _paperMoney.GetTotalCash() +
                "\n-------------");
            return sum;
        }
    }
}
