using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968.Model
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public BindingList<Part> AssociatedParts { get; } = new BindingList<Part>();

        public void addAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }

        public bool removeAssociatedPart(int partID)
        {
            Part partRemove = null;
            foreach (Part part in AssociatedParts)
            {
                if (part.ID == partID)
                {
                    partRemove = part;
                    break;
                }
            }
            if (partRemove != null)
            {
                AssociatedParts.Remove(partRemove);
                return true;
            }
            return false;
        }

        public Part lookupAssociatedPart(int partID)
        {
            foreach (Part part in AssociatedParts)
            {
                if (part.ID == partID)
                {
                    return part;
                }
            }
            return null;
        }
    }
}
