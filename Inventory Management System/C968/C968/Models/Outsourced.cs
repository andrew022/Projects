using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c968.Models
{
    public class Outsourced : Part
    {
        public Outsourced(int id, string name, int stock, decimal price, int min, int max, string companyName)
        {
            PartID = id;
            Name = name;
            Price = price;
            InStock = stock;
            Min = min;
            Max = max;
            CompanyName = companyName;
        }

        public string CompanyName { get; set; }
    }
}
