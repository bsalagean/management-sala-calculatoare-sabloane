using System;
using System.Collections.Generic;
using System.Text;

namespace ProiectSabloane
{
    public interface Element
    {
        void Accept(IVisitor visitor);
    }
}
