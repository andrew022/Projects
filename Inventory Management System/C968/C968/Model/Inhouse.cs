using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968.Model
{
    public class Inhouse : Part
    {
        public Inhouse(int partID, string partName, int partInStock, decimal partPrice, int partMax, int partMin, int partMachineID)
        {
            PartID = partID;
            PartName = partName;
            PartInStock = partInStock;
            PartPrice = partPrice;
            PartMax = partMax;
            PartMin = partMin;
            PartMachineID = partMachineID;
        }

        public int MachineID { get; set; }
        public int PartID { get; }
        public string PartName { get; }
        public int PartInStock { get; }
        public decimal PartPrice { get; }
        public int PartMax { get; }
        public int PartMin { get; }
        public int PartMachineID { get; }
    }
}
