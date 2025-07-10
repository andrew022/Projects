using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace c968.Models
{
    public class Product : INotifyPropertyChanged
    {
        public BindingList<Part> AssociatedParts = new BindingList<Part>();

        private int productID;
        private string name;
        private int inStock;
        private decimal price;
        private int min;
        private int max;

        public int ProductID
        {
            get { return productID; }
            set
            {
                productID = value;
                updateFields();
            }
        }
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                updateFields();
            }
        }
        public int InStock
        {
            get { return inStock; }
            set
            {
                inStock = value;
                updateFields();
            }
        }
        public decimal Price
        {
            get { return price; }
            set
            {
                price = value;
                updateFields();
            }
        }
        public int Min
        {
            get { return min; }
            set
            {
                min = value;
                updateFields();
            }
        }
        public int Max
        {
            get { return max; }
            set
            {
                max = value;
                updateFields();
            }
        }
        public Product(int id, string name, int stock, decimal price, int min, int max)
        {
            ProductID = id;
            Name = name;
            InStock = stock;
            Price = price;
            Min = min;
            Max = max;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void updateFields([CallerMemberName] string fieldName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(fieldName));
        }

        public void addAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }

        public bool removeAssociatedPart(int partID)
        {
            for (int i = 0; i < AssociatedParts.Count; i++)
            {
                if (AssociatedParts[i].PartID == partID)
                {
                    AssociatedParts.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        public Part lookupAssociatedPart(int partID)
        {
            foreach (Part part in AssociatedParts)
            {
                if (part.PartID == partID)
                {
                    return part;
                }
            }
            return null;
        }
    }
}
