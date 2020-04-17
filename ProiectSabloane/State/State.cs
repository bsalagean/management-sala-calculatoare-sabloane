using ProiectSabloane.Factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProiectSabloane.State
{
    public abstract class State
    {
        protected Computer comp;

        public State(Computer computer)
        {
            comp  = computer;
        }

        public abstract bool AssignComputer();

        public abstract bool FreeComputer();

        public abstract override string ToString();
    }
}
