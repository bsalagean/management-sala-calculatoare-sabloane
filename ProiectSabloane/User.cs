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

        //protected Computer comp;

       // public ComputerDealer computerDealer = new ComputerDealer();

        public void ViewComputers()
        {
            ManageComputer.computerDealer.StockComputer();
        }

        public bool ChooseComputer(int id)
        {
            if (ManageComputer.computerDealer.OrderedComputers.TryGetValue(id, out ManageComputer.computer))
            {
                ManageComputer.computerDealer.OrderedComputers.TryGetValue(id, out ManageComputer.computer);
                ManageComputer.computer.SetComputerState(EStateType.Occupied);
                ManageComputer.computer.Name = Name;
                return true;
            }
            return false;
        }
    }
}
