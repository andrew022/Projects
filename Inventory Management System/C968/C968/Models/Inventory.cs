using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c968.Models
{
    using System.ComponentModel;
    using System.IO.Ports;

    public static class Inventory
    {
        private static BindingList<Product> products = new BindingList<Product>();
        private static BindingList<Part> allParts = new BindingList<Part>();

        public static void DummyList()
        {
            Product prod1 = new Product(1, "Prod 1", 15, 19.00m, 10, 25);
            Product prod2 = new Product(2, "Prod 2", 4, 7.00m, 1, 10);
            Product prod3 = new Product(3, "Prod 3", 67, 9.4m, 5, 100);
            Product prod4 = new Product(4, "Prod 4", 12, 6.9m, 10, 50);
            Product prod5 = new Product(5, "Prod 5", 25, 55.4m, 15, 45);

            Products.Add(prod1);
            Products.Add(prod2);
            Products.Add(prod3);
            Products.Add(prod4);
            Products.Add(prod5);

            Part partA = new Inhouse(1, "In Part A", 67, 77.60m, 4, 90,5001);
            Part partB = new Inhouse(2, "In Part B", 14, 6.5m, 7, 87, 5002);
            Part partC = new Inhouse(3, "In Part C", 55, 9.2m, 11, 99, 5003);
            Part partD = new Outsourced(4, "Out Part D", 32, 3.3m, 25, 101, "Example 1");
            Part partE = new Outsourced(5, "Out Part E", 32, 3.3m, 25, 101, "Example 2");

            AllParts.Add(partA);
            AllParts.Add(partB);
            AllParts.Add(partC);
            AllParts.Add(partD);
            AllParts.Add(partE);

            prod1.AssociatedParts.Add(partA);
            prod2.AssociatedParts.Add(partB);
            prod3.AssociatedParts.Add(partC);
            prod4.AssociatedParts.Add(partD);
        }
        public static BindingList<Product> Products
        {
            get { return products; }
        }

        public static BindingList<Part> AllParts
        {
            get { return allParts; }
        }

        public static void addProduct(Product product)
        {
            products.Add(product);
        }

        public static bool removeProduct(int productID)
        {
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].ProductID == productID)
                {
                    products.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        public static Product lookupProduct(int productID)
        {
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].ProductID == productID)
                {
                    return products[i];
                }
            }
            return null;
        }

        public static void updateProduct(int index, Product product)
        {
            foreach (Product currentProd in Products)
            {
                if (currentProd.ProductID == index)
                {
                    currentProd.Name = product.Name;
                    currentProd.InStock = product.InStock;
                    currentProd.Price = product.Price;
                    currentProd.Max = product.Max;
                    currentProd.Min = product.Min;
                    currentProd.AssociatedParts = product.AssociatedParts;
                    return;
                }
            }
        }

        public static void addPart(int index, Part part)
        {
            allParts.Add(part);
        }

        public static bool deletePart(Part part)
        {
            return allParts.Remove(part);
        }

        public static Part lookupPart(int partID)
        {
            for (int i = 0; i < allParts.Count; i++)
            {
                if (allParts[i].PartID == partID)
                {
                    return allParts[i];
                }
            }
            return null;
        }

        public static void updatePart(int selectedPartID, Part updatePart)
        {
            for (int i = 0; i < allParts.Count; i++)
            {
                if (allParts[i].PartID == selectedPartID)
                {
                    allParts[i].Name = updatePart.Name;
                    allParts[i].InStock = updatePart.InStock;
                    allParts[i].Price = updatePart.Price;
                    allParts[i].Max = updatePart.Max;
                    allParts[i].Min = updatePart.Min;

                    if (allParts[i] is Inhouse && updatePart is Inhouse)
                    {
                        ((Inhouse)allParts[i]).MachineID = ((Inhouse)updatePart).MachineID;
                    }
                    else if (allParts[i] is Outsourced && updatePart is Outsourced)
                    {
                        ((Outsourced)allParts[i]).CompanyName = ((Outsourced)updatePart).CompanyName;
                    }
                    break;
                }
            }
        }
    }

}
