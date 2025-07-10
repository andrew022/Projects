using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c968.Models
{
    public class Inhouse : Part
    {
        public Inhouse(int id, string name, int stock, decimal price, int min, int max)
        {
            PartID = id;
            Name = name;
            InStock = stock;
            Price = price;
            Min = min;
            Max = max;
        }
        public Inhouse(int id, string name, int stock, decimal price, int min, int max, int machineID)
        {
            PartID = id;
            Name = name;
            InStock = stock;
            Price = price;
            Min = min;
            Max = max;
            MachineID = machineID;
        }
        public int MachineID { get; set; }
    }
}
