using ProiectSabloane.Factory;
using ProiectSabloane.Flyweight;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProiectSabloane
{
    public class Summary : IVisitor
    {

        private int Users;
        private int Hours;

        public void Display()
        {
            Console.WriteLine(Users + " useri");
            Console.WriteLine(10 * Hours + "total money made today");
            Console.WriteLine(Hours + " number of hours spent today in the shop for all clients");
        }

        public void Visit(User element)
        {
            Users++;
        }

        public void VisitTotalDayliHours(Computer comp)
        {
            Hours += comp.Hours;
        }
    }
}
