using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using c968.Models;

namespace c968
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
            FormLoad();
        }
        public void FormLoad()
        {
            Inventory.DummyList();

            var Part = new BindingSource();
            Part.DataSource = Inventory.AllParts;
            dgvParts.DataSource = Part;

            dgvParts.Columns["PartID"].HeaderText = "Part ID";
            dgvParts.Columns["InStock"].HeaderText = "Inventory";

            var Prod = new BindingSource();
            Prod.DataSource = Inventory.Products;
            dgvProducts.DataSource = Prod;

            dgvProducts.Columns["ProductID"].HeaderText = "Product ID";
            dgvProducts.Columns["InStock"].HeaderText = "Inventory";
        }

        private void partAddBtn_Click(object sender, EventArgs e)
        {
            AddPart addPart = new AddPart();
            addPart.ShowDialog();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void partModBtn_Click(object sender, EventArgs e)
        {
            if (dgvParts.CurrentRow.DataBoundItem.GetType() == typeof(c968.Models.Inhouse))
            {
                Inhouse inhousePart = (Inhouse)dgvParts.CurrentRow.DataBoundItem;
                new ModifyPart(inhousePart).ShowDialog();
            }
            else
            {
                Outsourced outPart = (Outsourced)dgvParts.CurrentRow.DataBoundItem;
                new ModifyPart(outPart).ShowDialog();
            }
        }

        private void prodAddBtn_Click(object sender, EventArgs e)
        {
            Product selectProd = (Product)dgvProducts.CurrentRow.DataBoundItem;
            new AddProduct(selectProd).ShowDialog();
        }

        private void prodModBtn_Click(object sender, EventArgs e)
        {
            Product selectProd = (Product)dgvProducts.CurrentRow.DataBoundItem;
            new ModifyProduct(selectProd).ShowDialog();
        }

        private void partSearchBtn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(partSearchBox.Text, out int id))
            {
                Inventory.lookupPart(id);
                if (Inventory.lookupPart(id) != null)
                {
                    dgvParts.ClearSelection();
                    for (int i = 0; i < dgvParts.Rows.Count; i++)
                    {
                        if (Convert.ToInt32(dgvParts.Rows[i].Cells[0].Value) == Inventory.lookupPart(id).PartID)
                        {
                            dgvParts.Rows[i].Selected = true;
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

        private void partDelBtn_Click(object sender, EventArgs e)
        {
            if (dgvParts.CurrentRow == null)
            {
                MessageBox.Show("Please select a part to delete.");
                return;
            }
            Part selectedPart = (Part)dgvParts.CurrentRow.DataBoundItem;
            if (DialogResult.Yes == MessageBox.Show($"Are you sure you want to delete part '{selectedPart.Name}'?", "Confirm Delete", MessageBoxButtons.YesNo))
            {
                Inventory.deletePart(selectedPart);
            }
        }

        private void prodDelBtn_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null)
            {
                MessageBox.Show("Please select a product to delete.");
                return;
            }
            Product selectedProduct = (Product)dgvProducts.CurrentRow.DataBoundItem;
            if (selectedProduct.AssociatedParts.Count > 0)
            {
                MessageBox.Show("A product with associated parts cannot be deleted.");
                return;
            }
            if (DialogResult.Yes == MessageBox.Show($"Are you sure you want to delete product '{selectedProduct.Name}'?", "Confirm Delete", MessageBoxButtons.YesNo))
            {
                Inventory.removeProduct(selectedProduct.ProductID);
            }
        }

        private void prodSearchBtn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(prodSearchBox.Text, out int id))
            {
                Inventory.lookupProduct(id);
                if (Inventory.lookupProduct(id) != null)
                {
                    dgvProducts.ClearSelection();
                    for (int i = 0; i < dgvProducts.Rows.Count; i++)
                    {
                        if (Convert.ToInt32(dgvProducts.Rows[i].Cells[0].Value) == Inventory.lookupProduct(id).ProductID)
                        {
                            dgvProducts.Rows[i].Selected = true;
                            return;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No product found");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please enter an ID");
                return;
            }
        }
    }
}
