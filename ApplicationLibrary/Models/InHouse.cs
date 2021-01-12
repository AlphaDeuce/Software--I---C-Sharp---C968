using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationLibrary.Models
{
    public class InHouse : Part
    {
        public int MachineID { get; set; }

        public InHouse(int partID, string name, decimal price, int inStock, int min, int max, int machineID) 
            : base (partID, name, price, inStock, min, max)
        {
            MachineID = machineID;
        }
    }
}
