using c968.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c968
{
    public partial class ModifyPart : Form
    {
        MainScreen MainForm = (MainScreen)Application.OpenForms["MainScreen"];
        public ModifyPart(Part part)
        {
            InitializeComponent();

            modIDTxt.Text = part.PartID.ToString();
            modNameTxt.Text = part.Name;
            modInvTxt.Text = part.InStock.ToString();
            modPriceTxt.Text = part.Price.ToString();
            modMaxTxt.Text = part.Max.ToString();
            modMinTxt.Text = part.Min.ToString();

            if (part is Inhouse inhousePart)
            {
                modInhouseBtn.Checked = true;
                modDynamicLabel.Text = "Machine ID";
                ModDynamicTxt.Text = inhousePart.MachineID.ToString();
            }
            else if (part is Outsourced outsourcedPart)
            {
                modOutsourcedBtn.Checked = true;
                modDynamicLabel.Text = "Company Name";
                ModDynamicTxt.Text = outsourcedPart.CompanyName;
            }
        }

        public ModifyPart(Outsourced outPart)
        {
            InitializeComponent();

            modOutsourcedBtn.Checked = true;
            modInhouseBtn.Checked = false;

            modIDTxt.Text = outPart.PartID.ToString();
            modNameTxt.Text = outPart.Name;
            modInvTxt.Text = outPart.InStock.ToString();
            modPriceTxt.Text = outPart.Price.ToString();
            modMaxTxt.Text = outPart.Max.ToString();
            modMinTxt.Text = outPart.Min.ToString();
            ModDynamicTxt.Text = outPart.CompanyName;
        }

        private void modCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void modInhouseBtn_CheckedChanged(object sender, EventArgs e)
        {
            modDynamicLabel.Text = "Machine ID";
        }

        private void modOutsourcedBtn_CheckedChanged(object sender, EventArgs e)
        {
            modDynamicLabel.Text = "Company Name";
        }

        private void modSaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string modName = modNameTxt.Text;
                int partID = int.Parse(modIDTxt.Text);
                if (string.IsNullOrEmpty(modNameTxt.Text) || string.IsNullOrEmpty(modPriceTxt.Text) || string.IsNullOrEmpty(modMaxTxt.Text) || string.IsNullOrEmpty(modMinTxt.Text) || string.IsNullOrEmpty(ModDynamicTxt.Text))
                {
                    MessageBox.Show("You left a field(s) blank!");
                    return;
                }
                if (!decimal.TryParse(modPriceTxt.Text, out decimal modPrice) || !int.TryParse(modMaxTxt.Text, out int modMax) || !int.TryParse(modMinTxt.Text, out int modMin) || !int.TryParse(modInvTxt.Text, out int modInv))
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
                    MessageBox.Show("Inventory must be between max and min");
                    return;
                }

                int index = Inventory.AllParts.IndexOf(Inventory.lookupPart(partID));

                if (modInhouseBtn.Checked)
                {
                    if (!int.TryParse(ModDynamicTxt.Text, out int partMachineId))
                    {
                        MessageBox.Show("Please input a valid number for Machine ID!");
                        return;
                    }
                    Inhouse inhouse = new Inhouse(partID, modName, modInv, modPrice, modMin, modMax, partMachineId);
                    Inventory.AllParts.RemoveAt(index);
                    Inventory.AllParts.Insert(index, inhouse);
                }
                else
                {
                    string partCompanyName = ModDynamicTxt.Text;
                    Outsourced outsourcedPart = new Outsourced(partID, modName, modInv, modPrice, modMin, modMax, partCompanyName);
                    Inventory.AllParts.RemoveAt(index);
                    Inventory.AllParts.Insert(index, outsourcedPart);
                }

                this.Close();
                MainForm.dgvParts.Refresh();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
