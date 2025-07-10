using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using c968.Models;

namespace c968
{
    public partial class AddPart : Form
    {
        public AddPart()
        {
            InitializeComponent();
            partAddIDTxt.Text = autoFillID().ToString();
        }
        private void inhouseBtn_CheckedChanged(object sender, EventArgs e)
        {
            partAddDynamicLabel.Text = "Machine ID";
            partAddDynamicTxt.Text = "";
        }

        private void outsourcedBtn_CheckedChanged(object sender, EventArgs e)
        {
            partAddDynamicLabel.Text = "Company Name";
            partAddDynamicTxt.Text = "";
        }

        private void partAddCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void partAddSaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int partAddID = Inventory.AllParts.Count + 1;
                string partAddName = partAddNameTxt.Text;
                if (string.IsNullOrEmpty(partAddNameTxt.Text) || string.IsNullOrEmpty(partAddInvTxt.Text) || string.IsNullOrEmpty(partAddPriceTxt.Text) || string.IsNullOrEmpty(partAddMinTxt.Text) || string.IsNullOrEmpty(partAddMaxTxt.Text) || string.IsNullOrEmpty(partAddDynamicTxt.Text))
                {
                    MessageBox.Show("You left a field(s) blank!");
                    return;
                }
                if (!decimal.TryParse(partAddPriceTxt.Text, out decimal partAddPrice) || !int.TryParse(partAddInvTxt.Text, out int partAddStock) || !int.TryParse(partAddMaxTxt.Text, out int partAddMax) || !int.TryParse(partAddMinTxt.Text, out int partAddMin))
                {
                    MessageBox.Show("Please input numbers for Price, Inventory, Max, and Min!");
                    return;
                }

                if (partAddMax < partAddMin)
                {
                    MessageBox.Show("Max must be greater than min!");
                    return;
                }
                if (partAddStock < partAddMin || partAddStock > partAddMax)
                {
                    MessageBox.Show("Inventory must be between max and min!");
                    return;
                }
                if (inhouseBtn.Checked)
                {
                    if (!int.TryParse(partAddDynamicTxt.Text, out int partAddMachineID))
                    {
                        MessageBox.Show("Please input a valid number for Machine ID!");
                        return;
                    }
                    Inhouse inhousePart = new Inhouse(partAddID, partAddName, partAddStock, partAddPrice, partAddMin, partAddMax, partAddMachineID);
                    int index = partAddID;
                    Inventory.addPart(index, inhousePart);
                }
                if (outsourcedBtn.Checked)
                {
                    string partAddCompanyName = partAddDynamicTxt.Text;
                    Outsourced outsourcedPart = new Outsourced(partAddID, partAddName, partAddStock, partAddPrice, partAddMin, partAddMax, partAddCompanyName);
                    int index = partAddID;
                    Inventory.addPart(index, outsourcedPart);
                }
                this.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private int autoFillID()
        {
            int maxID = 0;
            foreach (Part part in Inventory.AllParts)
            {
                if (part.PartID > maxID)
                {
                    maxID = part.PartID;
                }
            }
            return maxID + 1;
        }
    }
}
