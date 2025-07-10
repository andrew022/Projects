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
    public partial class ModifyProduct : Form
    {
        private Product currentProd;
        MainScreen MainForm = (MainScreen)Application.OpenForms["MainScreen"];
        BindingList<Part> addingParts = new BindingList<Part>();
        public ModifyProduct(Product product)
        {
            InitializeComponent();
            currentProd = product;

            modProdIDTxt.Text = product.ProductID.ToString();
            modProdNameTxt.Text = product.Name;
            modProdInvTxt.Text = product.InStock.ToString();
            modProdPriceTxt.Text = product.Price.ToString();
            modProdMaxTxt.Text = product.Max.ToString();
            modProdMinTxt.Text = product.Min.ToString();

            var prodPart = new BindingSource();
            prodPart.DataSource = Inventory.AllParts;
            dgvModProd1.DataSource = prodPart;

            dgvModProd1.Columns["PartID"].HeaderText = "Part ID";
            dgvModProd1.Columns["InStock"].HeaderText = "Inventory";

            foreach (Part p in product.AssociatedParts)
            {
                addingParts.Add(p);
            }

            var prodAssoc = new BindingSource();
            prodAssoc.DataSource = addingParts;
            dgvModProd2.DataSource = prodAssoc;

            dgvModProd2.Columns["PartID"].HeaderText = "Part ID";
            dgvModProd2.Columns["InStock"].HeaderText = "Inventory";
        }
        private void modProdCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void modProdDeleteBtn_Click(object sender, EventArgs e)
        {
            if (dgvModProd2.CurrentRow != null)
            {
                Part selectedPart = (Part)dgvModProd2.CurrentRow.DataBoundItem;
                if (DialogResult.Yes == MessageBox.Show($"Are you sure you want to delete part '{selectedPart.Name}'?", "Confirm Delete", MessageBoxButtons.YesNo))
                {
                    addingParts.Remove(selectedPart);
                }
            }
        }

        private void modProdAddBtn_Click(object sender, EventArgs e)
        {
            Part addingPart = (Part)dgvModProd1.CurrentRow.DataBoundItem;
            addingParts.Add(addingPart);
        }

        private void modProdSaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string modName = modProdNameTxt.Text;
                int modID = int.Parse(modProdIDTxt.Text);
                if (string.IsNullOrEmpty(modProdNameTxt.Text) || string.IsNullOrEmpty(modProdPriceTxt.Text) || string.IsNullOrEmpty(modProdInvTxt.Text) || string.IsNullOrEmpty(modProdMinTxt.Text) || string.IsNullOrEmpty(modProdMaxTxt.Text))
                {
                    MessageBox.Show("You left a field(s) empty!");
                    return;
                }
                if (!decimal.TryParse(modProdPriceTxt.Text, out decimal modPrice) || !int.TryParse(modProdInvTxt.Text, out int modInv) || !int.TryParse(modProdMaxTxt.Text, out int modMax) || !int.TryParse(modProdMinTxt.Text, out int modMin))
                {
                    MessageBox.Show("Please input valid numbers for Price, Inventory, Max, Min, and Part ID!");
                    return;
                }
                if (modMax < modMin)
                {
                    MessageBox.Show("Max must be bigger than min!");
                    return;
                }
                if (modInv > modMax || modInv < modMin)
                {
                    MessageBox.Show("Inventory must be between max and min!");
                    return;
                }
                Product productAdding = new Product(modID, modName, modInv, modPrice, modMin, modMax);
                productAdding.AssociatedParts.Clear();
                foreach (Part p in addingParts)
                {
                    productAdding.addAssociatedPart(p);
                }
                Inventory.updateProduct(modID, productAdding);
                Close();
                MainForm.dgvParts.Refresh();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void modProdSearchBtn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(modProdSearchTxt.Text, out int id))
            {
                if (Inventory.lookupPart(id) != null)
                {
                    dgvModProd1.ClearSelection();
                    for (int i = 0; i < dgvModProd1.Rows.Count; i++)
                    {
                        if (Convert.ToInt32(dgvModProd1.Rows[i].Cells[0].Value) == Inventory.lookupPart(id).PartID)
                        {
                            dgvModProd1.Rows[i].Selected = true;
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

    }
}
