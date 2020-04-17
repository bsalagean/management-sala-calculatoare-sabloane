using ProiectSabloane.Factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProiectSabloane.State
{
    public class FreeState : State
    {
        public FreeState(Computer computer) : base(computer)
        {

        }

        public override bool AssignComputer()
        {
            Console.WriteLine("Free state: assign computer !");
            comp.SetComputerState(EStateType.Occupied);
            return true;
        }

        public override bool FreeComputer()
        {
            Console.WriteLine("Free state: computer is free !");
            return false;
        }

        public override string ToString()
        {
            return EStateType.Free.ToString();
        }
    }
}
