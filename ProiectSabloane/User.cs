using ProiectSabloane.Factory;
using ProiectSabloane.State;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProiectSabloane
{
    public class User
    {
        public string Name { get; set; }

        protected Computer comp;

        public ComputerDealer computerDealer = new ComputerDealer();

        public void ViewComputers()
        {
            computerDealer.StockComputer();
        }

        public bool ChooseComputer(int id)
        {
            if (computerDealer.OrderedComputers.TryGetValue(id, out comp))
            {
                computerDealer.OrderedComputers.TryGetValue(id, out comp);
                comp.SetComputerState(EStateType.Occupied);
                comp.Name = Name;
                return true;
            }
            return false;
        }
    }
}
