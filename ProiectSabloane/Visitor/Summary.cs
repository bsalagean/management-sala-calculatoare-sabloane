using System;
using System.Collections.Generic;
using System.Text;

namespace ProiectSabloane
{
    public class Summary : IVisitor
    {
        private int nrUseri;


        public void Display()
        {
            Console.WriteLine(nrUseri + " useri");
        }

        public void Visit(User element)
        {
            nrUseri++;
        }
    }
}
