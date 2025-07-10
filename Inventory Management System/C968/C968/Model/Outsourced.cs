using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968.Model
{
    public class Outsourced : Part
    {
        public Outsourced(int partID, string partName, int partInStock, decimal partPrice, int partMax, int partMin, string partCompanyName)
        {
            PartID = partID;
            PartName = partName;
            PartInStock = partInStock;
            PartPrice = partPrice;
            PartMax = partMax;
            PartMin = partMin;
            PartCompanyName = partCompanyName;
        }

        public string CompanyName { get; set; }
        public int PartID { get; }
        public string PartName { get; }
        public int PartInStock { get; }
        public decimal PartPrice { get; }
        public int PartMax { get; }
        public int PartMin { get; }
        public string PartCompanyName { get; }
    }
}
