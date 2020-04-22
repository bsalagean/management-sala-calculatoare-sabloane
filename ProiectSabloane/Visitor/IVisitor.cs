using ProiectSabloane.Factory;
using ProiectSabloane.Flyweight;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProiectSabloane
{
    public interface IVisitor
    {
        void Visit(User element);

        void VisitTotalDayliHours(Computer comp);
    }
}
