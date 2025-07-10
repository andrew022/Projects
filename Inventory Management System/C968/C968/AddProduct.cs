using c968.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c968
{
    public partial class AddProduct : Form
    {
        BindingList<Part> addingParts = new BindingList<Part>();
        private Product currentProd;
        public AddProduct(Product product)
        {
            InitializeComponent();
            LoadParts();
            addProdIDTxt.Text = autoFillID().ToString();
            currentProd = product;
        }

        public void LoadParts()
        {
            var prodPart = new BindingSource();
            prodPart.DataSource = Inventory.AllParts;
            dgvAddProd1.DataSource = prodPart;

            dgvAddProd1.Columns["PartID"].HeaderText = "Part ID";
            dgvAddProd1.Columns["InStock"].HeaderText = "Inventory";

            var prodAssocParts = new BindingSource();
            prodAssocParts.DataSource = addingParts;
            dgvAddProd2.DataSource = prodAssocParts;

            dgvAddProd2.Columns["PartID"].HeaderText = "Part ID";
            dgvAddProd2.Columns["InStock"].HeaderText = "Inventory";
        }

        private void addProdCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addProdDeleteBtn_Click(object sender, EventArgs e)
        {
            if (dgvAddProd2.CurrentRow != null)
            {
                Part selectedPart = (Part)dgvAddProd2.CurrentRow.DataBoundItem;
                currentProd.removeAssociatedPart(selectedPart.PartID);
                addingParts.Remove(selectedPart);
            }
        }

        private void addProdAddBtn_Click(object sender, EventArgs e)
        {
            Part addingPart = (Part)dgvAddProd1.CurrentRow.DataBoundItem;
            addingParts.Add(addingPart);
        }

        private void addProdSaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int prodAddID = Inventory.Products.Count + 1;
                string prodAddName = addProdNameTxt.Text;
                if (string.IsNullOrEmpty(addProdNameTxt.Text) || string.IsNullOrEmpty(addProdPriceTxt.Text) || string.IsNullOrEmpty(addProdInvTxt.Text) || string.IsNullOrEmpty(addProdMinTxt.Text) || string.IsNullOrEmpty(addProdMaxTxt.Text))
                {
                    MessageBox.Show("You left a field(s) empty!");
                    return;
                }
                if (!decimal.TryParse(addProdPriceTxt.Text, out decimal prodAddPrice) || !int.TryParse(addProdInvTxt.Text, out int prodAddStock) || !int.TryParse(addProdMaxTxt.Text, out int prodAddMax) || !int.TryParse(addProdMinTxt.Text, out int prodAddMin))
                {
                    MessageBox.Show("Please input valid numbers for Price, Inventory, Max, Min, and Part ID!");
                    return;
                }
                if (prodAddMax < prodAddMin)
                {
                    MessageBox.Show("Max must be bigger than min!");
                    return;
                }
                if (prodAddStock > prodAddMax || prodAddStock < prodAddMin)
                {
                    MessageBox.Show("Inventory must be between max and min");
                    return;
                }
                Product productAdding = new Product(prodAddID, prodAddName, prodAddStock, prodAddPrice, prodAddMin, prodAddMax);
                Inventory.addProduct(productAdding);

                foreach (Part p in addingParts)
                {
                    productAdding.addAssociatedPart(p);
                }
                this.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void addProdSearchBtn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(addProdSearchTxt.Text, out int id))
            {
                if (Inventory.lookupPart(id) != null)
                {
                    dgvAddProd1.ClearSelection();
                    for (int i = 0; i < dgvAddProd1.Rows.Count; i++)
                    {
                        if (Convert.ToInt32(dgvAddProd1.Rows[i].Cells[0].Value) == Inventory.lookupPart(id).PartID)
                        {
                            dgvAddProd1.Rows[i].Selected = true;
                            return;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No part found");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please enter an ID");
                return;
            }
        }
        private int autoFillID()
        {
            int maxID = 0;
            foreach (Product product in Inventory.Products)
            {
                if (product.ProductID > maxID)
                {
                    maxID = product.ProductID;
                }
            }
            return maxID + 1;
        }
    }
}
