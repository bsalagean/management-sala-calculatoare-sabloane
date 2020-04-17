using ProiectSabloane.Factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProiectSabloane.State
{
    public class OccupiedState : State
    {
        public OccupiedState(Computer computer) : base(computer)
        {
        }

        public override bool AssignComputer()
        {
            Console.WriteLine("Occupied state: computer already assigned !");
            return false;
        }

        public override bool FreeComputer()
        {
            Console.WriteLine("Occupied state: computer is free !");
            comp.SetComputerState(EStateType.Free);
            return true;
        }

        public override string ToString()
        {
            return EStateType.Occupied.ToString();
        }
    }
}
